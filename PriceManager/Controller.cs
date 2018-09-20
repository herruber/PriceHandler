using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Drawing;

namespace PriceManager
{
    public class Controller
    {

        public static string Url = "http://localhost:63918/"; //Home/GetPriceList
        public static DataGridView priceList;
        public static List<ModelData> modelData = new List<ModelData>();

        public class PriceResult
        {
            public string[] Items { get; set; }
            public string[] JsonDatas { get; set; }
        }

        public static string GenerateRequest(string controller, string action, string method, object data)
        {
            // Create a request for the URL. 
            string json = JsonConvert.SerializeObject(data);

            string url = Url + "/" + controller + "/" + action;

            if (method.ToLower().Equals("post"))
            {
                //url = string.Format(Url + "/?data={0}", json);
            }

            WebRequest request = WebRequest.Create(url);
            request.Method = method;
            Stream dataStream;

            if (data != null)
            {
                request.ContentType = "application/json";
                byte[] byteArray = Encoding.UTF8.GetBytes(json);
                request.ContentLength = byteArray.Length;

                using (var streamwriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamwriter.Write(json);
                    streamwriter.Flush();
                    streamwriter.Close();
                }

            }
            
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.

            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            response.Close();
            return responseFromServer;
        }

        public static DataGridViewColumn CreateColumm(string name, Type type)
        {
            
            if (type.IsEnum)
            {
                DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();

                col.Name = name;
                col.DataPropertyName = name;
                col.DataSource = Enum.GetValues(typeof(ModelData.PriceMode));
                col.ValueType = typeof(ModelData.PriceMode);
                return col;
            }
            else if (name.ToLower().Contains("icon"))
            {
                //Create Image column
                DataGridViewImageColumn col = new DataGridViewImageColumn();
                col.Name = name;
                col.DataPropertyName = name;
                col.ValueType = typeof(Image);
                return col;
            }
            else
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = name;
                col.DataPropertyName = name;
                return col;
            }

        }

        private static DataGridViewRow AddRow(ModelData data)
        {
            var row = new DataGridViewRow();

            var properties = ModelData.GetProperties(false);

            foreach (var prop in properties)
            {
                if (prop.PropertyType.IsEnum)
                {
                    DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                    cell.ValueType = typeof(ModelData.PriceMode);
                    cell.DataSource = Enum.GetValues(typeof(ModelData.PriceMode));
                    cell.Value = typeof(ModelData).GetProperty(prop.Name).GetValue(data, null);
                    row.Cells.Add(cell);
                }
                else if (prop.Name.ToLower().Contains("icon"))
                {
                    //Create Image column
                    DataGridViewImageCell cell = new DataGridViewImageCell();

                    cell.ValueType = typeof(Image);
                    //cell.Value = typeof(ModelData).GetProperty(prop.Name).GetValue(data, null);

                    row.Cells.Add(cell);
                }
                else
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    var property = typeof(ModelData).GetProperty(prop.Name);
                    cell.ValueType = property.PropertyType;
                    cell.Value = property.GetValue(data, null);
                    row.Cells.Add(cell);
                }
            }

            return row;
        }

        public static int HasData(string name, List<ModelData> data)
        {
            //If item has data
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Name.ToLower().Contains(name.ToLower()))
                {
                    return i;
                }
            }

            return -1;         
        }

        public static void ParseAndAddItem(string name, List<ModelData> data)
        {


            string[] info = name.Split(' ');

            //If item has data

            int hasData = HasData(name, data);

            if (hasData == -1)
            {
                ModelData newdata = new ModelData();
                newdata.Name = name;

                modelData.Add(newdata);
            }
            else
            {
                modelData.Add(data[hasData]);
            }

        }

        public static void GetPriceList()
        {

            modelData = new List<ModelData>();
            priceList.Rows.Clear();
           
            string responseFromServer = GenerateRequest("Home", "GetPriceList", "GET", null);

            PriceResult result = JsonConvert.DeserializeObject<PriceResult>(responseFromServer);

            List<ModelData> data = new List<ModelData>();

            foreach (var jsonData in result.JsonDatas)
            {

                try
                {
                    data.Add(JsonConvert.DeserializeObject<ModelData>(jsonData));
                }
                catch (Exception)
                {

                    throw;
                }
            }

            foreach (var item in result.Items)
            {
                ParseAndAddItem(item, data);
            }

            foreach (var d in modelData)
            {
               priceList.Rows.Add(AddRow(d));
            }

        }


    }
}
