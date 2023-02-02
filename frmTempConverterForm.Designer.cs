namespace TempConverterApp
{
    partial class frmTempCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTempCon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsious = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsious = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdFahrenheit_Celsious = new System.Windows.Forms.RadioButton();
            this.rdCelsious_Fahrenheit = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(9, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 304);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblFahrenheit);
            this.groupBox2.Controls.Add(this.lblCelsious);
            this.groupBox2.Controls.Add(this.txtFahrenheit);
            this.groupBox2.Controls.Add(this.txtCelsious);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(30, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perform Conversion";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFahrenheit.Location = new System.Drawing.Point(156, 47);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(106, 22);
            this.lblFahrenheit.TabIndex = 3;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // lblCelsious
            // 
            this.lblCelsious.AutoSize = true;
            this.lblCelsious.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsious.ForeColor = System.Drawing.Color.Red;
            this.lblCelsious.Location = new System.Drawing.Point(13, 47);
            this.lblCelsious.Name = "lblCelsious";
            this.lblCelsious.Size = new System.Drawing.Size(76, 22);
            this.lblCelsious.TabIndex = 2;
            this.lblCelsious.Text = "Celsius";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtFahrenheit.Location = new System.Drawing.Point(160, 72);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(120, 29);
            this.txtFahrenheit.TabIndex = 1;
            this.txtFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFahrenheit.TextChanged += new System.EventHandler(this.txtFahrenheit_TextChanged);
            // 
            // txtCelsious
            // 
            this.txtCelsious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsious.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCelsious.Location = new System.Drawing.Point(14, 72);
            this.txtCelsious.Name = "txtCelsious";
            this.txtCelsious.Size = new System.Drawing.Size(120, 29);
            this.txtCelsious.TabIndex = 0;
            this.txtCelsious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCelsious.TextChanged += new System.EventHandler(this.txtCelsious_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdFahrenheit_Celsious);
            this.groupBox1.Controls.Add(this.rdCelsious_Fahrenheit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(30, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion Option";
            // 
            // rdFahrenheit_Celsious
            // 
            this.rdFahrenheit_Celsious.AutoSize = true;
            this.rdFahrenheit_Celsious.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFahrenheit_Celsious.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdFahrenheit_Celsious.Location = new System.Drawing.Point(32, 85);
            this.rdFahrenheit_Celsious.Name = "rdFahrenheit_Celsious";
            this.rdFahrenheit_Celsious.Size = new System.Drawing.Size(219, 26);
            this.rdFahrenheit_Celsious.TabIndex = 1;
            this.rdFahrenheit_Celsious.TabStop = true;
            this.rdFahrenheit_Celsious.Text = "Fahrenheit to Celsius";
            this.rdFahrenheit_Celsious.UseVisualStyleBackColor = true;
            this.rdFahrenheit_Celsious.CheckedChanged += new System.EventHandler(this.rdFahrenheit_Celsious_CheckedChanged);
            // 
            // rdCelsious_Fahrenheit
            // 
            this.rdCelsious_Fahrenheit.AutoSize = true;
            this.rdCelsious_Fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCelsious_Fahrenheit.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdCelsious_Fahrenheit.Location = new System.Drawing.Point(32, 58);
            this.rdCelsious_Fahrenheit.Name = "rdCelsious_Fahrenheit";
            this.rdCelsious_Fahrenheit.Size = new System.Drawing.Size(219, 26);
            this.rdCelsious_Fahrenheit.TabIndex = 0;
            this.rdCelsious_Fahrenheit.TabStop = true;
            this.rdCelsious_Fahrenheit.Text = "Celsius to Fahrenheit";
            this.rdCelsious_Fahrenheit.UseVisualStyleBackColor = true;
            this.rdCelsious_Fahrenheit.CheckedChanged += new System.EventHandler(this.rdCelsious_Fahrenheit_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("DS-Digital", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(69, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(440, 59);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Temp Converter";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(530, 392);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 18);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Exit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(126, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Rights Reserved (C) 2020 MNA (00400119)";
            // 
            // frmTempCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTempCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdFahrenheit_Celsious;
        private System.Windows.Forms.RadioButton rdCelsious_Fahrenheit;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsious;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelsious;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

