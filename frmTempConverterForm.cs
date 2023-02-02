using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TempConverterApp
{
    public partial class frmTempCon : Form
    {
        int Cel = 0;
        int Fah = 0;

        public frmTempCon()
        {
            InitializeComponent();
        }

              
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void rdCelsious_Fahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCelsious_Fahrenheit.Checked == true)
            {
                txtCelsious.Enabled = true;
                txtFahrenheit.Enabled = false;
            }
        }

        private void rdFahrenheit_Celsious_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFahrenheit_Celsious.Checked == true)
            {
                txtFahrenheit.Enabled = true;
                txtCelsious.Enabled = false;
            }
        }

        private void txtCelsious_TextChanged(object sender, EventArgs e)
        {
            if (txtCelsious.Text != "" && rdCelsious_Fahrenheit.Checked == true)
            {
                Cel = int.Parse(txtCelsious.Text);
                Fah = (Cel * 9) / 5 + 32;

                txtFahrenheit.Text = Fah.ToString();
            }
        }

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {
            if (txtFahrenheit.Text != "" && rdFahrenheit_Celsious.Checked == true)
            {
                Fah = int.Parse(txtFahrenheit.Text);
                Cel = (Fah - 32) * 5 / 9;

                txtCelsious.Text = Cel.ToString();
            }
        }    
             
    }
}
