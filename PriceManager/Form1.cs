using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PriceManager
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Controller.priceList = itemView;

            var properties = ModelData.GetProperties(false);

            foreach (var prop in properties)
            {

                Controller.priceList.Columns.Add(Controller.CreateColumm(prop.Name, prop.PropertyType));

            }

            Controller.GetPriceList();

        }

        private ModelData GetModelData(DataGridViewRow row)
        {
            var data = new ModelData();

            for (int i = 0; i < row.Cells.Count; i++)
            {

                var property = typeof(ModelData).GetProperty(itemView.Columns[i].Name);

                if (property.Name.ToLower().Contains("icon"))
                {

                }
                else
                {
                    property.SetValue(data, row.Cells[i].Value);
                }
            }

            return data;
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < Controller.modelData.Count; i++)
            {

                ModelData data = Controller.modelData[i];
                DataGridViewRow row = Controller.priceList.Rows[i];

                string name = row.Cells[1].Value.ToString();
                if (name != data.Name)
                {
                    //Name changed
                    data.OldNames.Add(data.Name);
                    
                }
                data.Name = name;

                for (int c = 0; c < row.Cells.Count; c++)
                {

                    var col = Controller.priceList.Columns[c];
                    var cell = row.Cells[c];

                    if (col.Name.ToLower().Contains("icon"))
                    {
                        data.IconPath = "";
                    }
                    else
                    {
                        typeof(ModelData).GetProperty(col.Name).SetValue(data, cell.Value);
                    }
                }
            }

            Controller.GenerateRequest("Home", "SavePriceList", "POST", Controller.modelData);
        }
    }

    public class ModelData
    {

        public ModelData()
        {
            OldNames = new List<string>();
            Type = "";
            Name = "";
            Width = Height = Thickness = 0;
            Angle = 0;
            _PriceMode = PriceMode.Unit;
            Price = Discount = 0;
            IconPath = "";
        }

        public ModelData(string name)
        {
            OldNames = new List<string>();
            Type = "";
            Name = name;
            Width = 0;
            Height = 0;
            Thickness = 0;
            Angle = 0;
            _PriceMode = PriceMode.Unit;
            Price = 0;
            Discount = 0;
            IconPath = "";
        }

        public enum PriceMode
        {
            Sqm,
            M,
            Unit
        }

        public static List<System.Reflection.PropertyInfo> GetProperties(bool includeOldNames)
        {
            System.Reflection.PropertyInfo[] props = typeof(ModelData).GetProperties();
            List<System.Reflection.PropertyInfo> proplist = new List<System.Reflection.PropertyInfo>();

            if (includeOldNames)
            {
                proplist = props.ToList();
            }
            else
            {
                foreach (var item in props)
                {
                    if (item.Name != "OldNames")
                    {
                        proplist.Add(item);
                    }
                }
            }
            

            return proplist;
        }

        public List<string> OldNames { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Thickness { get; set; }
        public double Angle { get; set; }
        public PriceMode _PriceMode { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public string IconPath { get; set; }
    }

}
