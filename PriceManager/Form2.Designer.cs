namespace PriceManager
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_map = new System.Windows.Forms.Panel();
            this.select1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_normalMap = new System.Windows.Forms.Panel();
            this.select2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_roughnessMap = new System.Windows.Forms.Panel();
            this.select3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_displacementMap = new System.Windows.Forms.Panel();
            this.select5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.normalScale = new System.Windows.Forms.TrackBar();
            this.roughness = new System.Windows.Forms.TrackBar();
            this.displacementScale = new System.Windows.Forms.TrackBar();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel_map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_normalMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_roughnessMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_displacementMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roughness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displacementScale)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_map
            // 
            this.panel_map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_map.Controls.Add(this.select1);
            this.panel_map.Controls.Add(this.textBox1);
            this.panel_map.Controls.Add(this.pictureBox1);
            this.panel_map.Location = new System.Drawing.Point(0, 3);
            this.panel_map.Name = "panel_map";
            this.panel_map.Size = new System.Drawing.Size(200, 90);
            this.panel_map.TabIndex = 0;
            // 
            // select1
            // 
            this.select1.BackColor = System.Drawing.Color.White;
            this.select1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.select1.FlatAppearance.BorderSize = 4;
            this.select1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select1.Location = new System.Drawing.Point(91, 57);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(100, 28);
            this.select1.TabIndex = 2;
            this.select1.Text = "Select..";
            this.select1.UseVisualStyleBackColor = false;
            this.select1.Click += new System.EventHandler(this.Select_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(91, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Map";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_normalMap
            // 
            this.panel_normalMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_normalMap.Controls.Add(this.normalScale);
            this.panel_normalMap.Controls.Add(this.select2);
            this.panel_normalMap.Controls.Add(this.textBox2);
            this.panel_normalMap.Controls.Add(this.pictureBox2);
            this.panel_normalMap.Location = new System.Drawing.Point(0, 99);
            this.panel_normalMap.Name = "panel_normalMap";
            this.panel_normalMap.Size = new System.Drawing.Size(200, 90);
            this.panel_normalMap.TabIndex = 3;
            // 
            // select2
            // 
            this.select2.BackColor = System.Drawing.Color.White;
            this.select2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.select2.FlatAppearance.BorderSize = 4;
            this.select2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select2.Location = new System.Drawing.Point(91, 57);
            this.select2.Name = "select2";
            this.select2.Size = new System.Drawing.Size(100, 28);
            this.select2.TabIndex = 2;
            this.select2.Text = "Select..";
            this.select2.UseVisualStyleBackColor = false;
            this.select2.Click += new System.EventHandler(this.Select_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(91, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Normal Map";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 78);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_roughnessMap
            // 
            this.panel_roughnessMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_roughnessMap.Controls.Add(this.roughness);
            this.panel_roughnessMap.Controls.Add(this.select3);
            this.panel_roughnessMap.Controls.Add(this.textBox3);
            this.panel_roughnessMap.Controls.Add(this.pictureBox3);
            this.panel_roughnessMap.Location = new System.Drawing.Point(0, 195);
            this.panel_roughnessMap.Name = "panel_roughnessMap";
            this.panel_roughnessMap.Size = new System.Drawing.Size(200, 90);
            this.panel_roughnessMap.TabIndex = 4;
            // 
            // select3
            // 
            this.select3.BackColor = System.Drawing.Color.White;
            this.select3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.select3.FlatAppearance.BorderSize = 4;
            this.select3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select3.Location = new System.Drawing.Point(91, 57);
            this.select3.Name = "select3";
            this.select3.Size = new System.Drawing.Size(100, 28);
            this.select3.TabIndex = 2;
            this.select3.Text = "Select..";
            this.select3.UseVisualStyleBackColor = false;
            this.select3.Click += new System.EventHandler(this.Select_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(91, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Roughness Map";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Location = new System.Drawing.Point(5, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 78);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel_displacementMap);
            this.panel1.Controls.Add(this.panel_map);
            this.panel1.Controls.Add(this.panel_roughnessMap);
            this.panel1.Controls.Add(this.panel_normalMap);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 421);
            this.panel1.TabIndex = 6;
            // 
            // panel_displacementMap
            // 
            this.panel_displacementMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_displacementMap.Controls.Add(this.displacementScale);
            this.panel_displacementMap.Controls.Add(this.select5);
            this.panel_displacementMap.Controls.Add(this.textBox4);
            this.panel_displacementMap.Controls.Add(this.pictureBox4);
            this.panel_displacementMap.Location = new System.Drawing.Point(0, 291);
            this.panel_displacementMap.Name = "panel_displacementMap";
            this.panel_displacementMap.Size = new System.Drawing.Size(200, 90);
            this.panel_displacementMap.TabIndex = 5;
            // 
            // select5
            // 
            this.select5.BackColor = System.Drawing.Color.White;
            this.select5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.select5.FlatAppearance.BorderSize = 4;
            this.select5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select5.Location = new System.Drawing.Point(91, 57);
            this.select5.Name = "select5";
            this.select5.Size = new System.Drawing.Size(100, 28);
            this.select5.TabIndex = 2;
            this.select5.Text = "Select..";
            this.select5.UseVisualStyleBackColor = false;
            this.select5.Click += new System.EventHandler(this.Select_Click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(91, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Displacement Map";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Location = new System.Drawing.Point(5, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 78);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // normalScale
            // 
            this.normalScale.AutoSize = false;
            this.normalScale.Location = new System.Drawing.Point(91, 25);
            this.normalScale.Maximum = 100;
            this.normalScale.Name = "normalScale";
            this.normalScale.Size = new System.Drawing.Size(101, 26);
            this.normalScale.TabIndex = 3;
            this.normalScale.TickFrequency = 2;
            this.normalScale.Value = 50;
            this.normalScale.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // roughness
            // 
            this.roughness.AutoSize = false;
            this.roughness.Location = new System.Drawing.Point(90, 25);
            this.roughness.Maximum = 100;
            this.roughness.Name = "roughness";
            this.roughness.Size = new System.Drawing.Size(101, 26);
            this.roughness.TabIndex = 4;
            this.roughness.TickFrequency = 2;
            this.roughness.Value = 50;
            this.roughness.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // displacementScale
            // 
            this.displacementScale.AutoSize = false;
            this.displacementScale.Location = new System.Drawing.Point(90, 25);
            this.displacementScale.Maximum = 100;
            this.displacementScale.Name = "displacementScale";
            this.displacementScale.Size = new System.Drawing.Size(101, 26);
            this.displacementScale.TabIndex = 5;
            this.displacementScale.TickFrequency = 2;
            this.displacementScale.Value = 50;
            this.displacementScale.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 458);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(202, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "1,1";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(13, 439);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(202, 13);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "Tiling";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 484);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 582);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel_map.ResumeLayout(false);
            this.panel_map.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_normalMap.ResumeLayout(false);
            this.panel_normalMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_roughnessMap.ResumeLayout(false);
            this.panel_roughnessMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_displacementMap.ResumeLayout(false);
            this.panel_displacementMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roughness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displacementScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_map;
        private System.Windows.Forms.Button select1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_normalMap;
        private System.Windows.Forms.Button select2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_roughnessMap;
        private System.Windows.Forms.Button select3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_displacementMap;
        private System.Windows.Forms.Button select5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TrackBar normalScale;
        private System.Windows.Forms.TrackBar roughness;
        private System.Windows.Forms.TrackBar displacementScale;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}