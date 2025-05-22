﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZebCarRental
{
    public partial class Form2 : Form
    {
        private Form1 tForm;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            tForm = f1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            // set form1 Properties
            tForm.SedanRate = double.Parse(txtSedanRate.Text);
            tForm.SuvRate = double.Parse(txtSUVRate.Text);
            tForm.CompRate = double.Parse(txtCompRate.Text);
            tForm.TaxRate = double.Parse(txtTaxRate.Text);
            //opening the config file to save the values
            sw = File.CreateText(tForm.cfgFile);
            // save the properties in the file - MAKE SURE THEY ARE IN THE CORRECT ORDER
            sw.WriteLine(tForm.SedanRate.ToString());
            sw.WriteLine(tForm.SuvRate.ToString());
            sw.WriteLine(tForm.CompRate.ToString());
            sw.WriteLine(tForm.TaxRate.ToString());

            sw.Close();
            this.Hide();
        }
    }
}
