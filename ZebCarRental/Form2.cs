using System;
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
        private Form1 ff;
        public Form2(Form1 f)
        {
            InitializeComponent();
            ff = f;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ff.SedanRate = double.Parse(lblSedanRate.Text);
            ff.SuvRate = double.Parse(lblSuvRate.Text);
            ff.CompRate = double.Parse(lblCompRate.Text);
            StreamWriter sw = File.CreateText(ff.swCFG);
            sw.WriteLine(ff.SedanRate.ToString());
            sw.WriteLine(ff.CompRate.ToString());
            sw.WriteLine(ff.SuvRate.ToString());
            sw.Close();
        }
    }
}
