using Microsoft.VisualBasic.Logging;

namespace ZebCarRental
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show(
                "Do you really want to Quit?", "Exiting...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ButtonSelected == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDays.Clear();
            txtRate.Clear();
            txtName.Focus();
            lstOut.Items.Clear();
            rdoSedan.Checked = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //  declare/read variables from txtbx
            string custName;
            int totalDays;
            double rateDaily, costCar;
            bool totalDaysValid, rateDailyValid;
            double carTypeRate = 0;
            StreamWriter swLog;
            //      double rateTax, costTax, totalCost  ;
            //  input
            custName = txtName.Text;
            totalDaysValid = int.TryParse(txtDays.Text, out totalDays);
            rateDailyValid = double.TryParse(txtRate.Text, out rateDaily);
            //processing
            if (totalDaysValid && rateDailyValid)
            {
                switch (carType)
                {
                    case SEDAN:
                        carTypeRate = sedanRate;
                        break;
                    case SUV:
                        carTypeRate = suvRate;
                        break;
                    case COMP:
                        carTypeRate = compRate;
                        break;
                    default:
                        lstOut.Items.Add("This shouldn't happen.");
                        break;


                }
                costCar = totalDays * rateDaily;
                //      costTax = costCar * rateTax;
                //      totalCost = costCar + costTax;
                //  output
                lstOut.Items.Add("Customer Name: " + custName);
                lstOut.Items.Add("Days entered is: " + totalDays);
                //      lstOut.Items.Add("Vehicle type selected:");
                lstOut.Items.Add("Selected vehicle type rate: " + rateDaily.ToString("C"));
                lstOut.Items.Add("Vehicle rental cost: " + costCar.ToString("C"));
                //      lstOut.Items.Add("Tax rate: ");
                //      lstOut.Items.Add("Tax charge: ");
                //      lstOut.Items.Add("Cost with tax: ");
                //opens file so i can append to the end
                swLog = File.AppendText(logFile);
                swLog.WriteLine("******Beginning of Transaction at " + DateTime.Now.ToString("G") + "*******+");
                swLog.WriteLine("Customer Name: " + custName);
                swLog.WriteLine("Days entered is: " + totalDays);
                swLog.WriteLine("Selected vehicle type rate: " + rateDaily.ToString("C"));
                swLog.WriteLine("Vehicle rental cost: " + costCar.ToString("C"));

            }

            else
            {
                if (!totalDaysValid)
                {
                    lstOut.Items.Add("Total Days is incorrect.");
                }
                if (!rateDailyValid)
                {
                    lstOut.Items.Add("Daily Rate is incorrect.");
                }
            }




        }

        private void txtDays_Enter(object sender, EventArgs e)
        {
            txtDays.BackColor = Color.Ivory;
        }

        private void txtDays_Leave(object sender, EventArgs e)
        {
            txtDays.BackColor = SystemColors.Window;
        }

        private void txtRate_Enter(object sender, EventArgs e)
        {
            txtRate.BackColor = Color.Ivory;
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            txtRate.BackColor = SystemColors.Window;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.BackColor = Color.Ivory;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.BackColor = SystemColors.Window;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader srCFG;
            rdoSedan.Checked = true;
            try
            {
                srCFG = File.OpenText(cfgFile);
                sedanRate = double.Parse(srCFG.ReadLine());
                suvRate = double.Parse(srCFG.ReadLine());
                compRate = double.Parse(srCFG.ReadLine());
                srCFG.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(
                    "Configuration File not found. Please enter a new configuration file.",
                    "Configuration file not found");
                OFD.Title = "Enter configuration file";
                OFD.FileName = cfgFile;
                OFD.ShowDialog();
                cfgFile = OFD.FileName;
            }
        }

        private void rdoSedan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSedan.Checked)
            {
                carType = SEDAN;
            }
        }

        private void rdoSUV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSUV.Checked)
            {
                carType = SUV;
            }
        }

        private void rdoCompact_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoCompact.Checked)
            {
                carType = COMP;
            }
        }
    }
}
