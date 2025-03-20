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
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //  declare/read variables from txtbx
            string custName;
            int totalDays;
            double rateDaily, costCar;
            bool totalDaysValid, rateDailyValid;
            //      double rateTax, costTax, totalCost  ;
            //  input
            custName = txtName.Text;
            totalDaysValid = int.TryParse(txtDays.Text, out totalDays);
            rateDailyValid = double.TryParse(txtRate.Text, out rateDaily);
            //processing
            costCar = totalDays * rateDaily;
            //      costTax = costCar * rateTax
            //      totalCost = costCar + costTax;
            //  output
            if (totalDaysValid && rateDailyValid)
            {
                lstOut.Items.Add("Customer Name: " + custName);
                lstOut.Items.Add("Days entered is: " + totalDays);
                //      lstOut.Items.Add("Vehicle type selected:");
                lstOut.Items.Add("Selected vehicle type rate: " + rateDaily.ToString("C"));
                lstOut.Items.Add("Vehicle rental cost: " + costCar.ToString("C"));
                //      lstOut.Items.Add("Tax rate: ");
                //      lstOut.Items.Add("Tax charge: ");
                //      lstOut.Items.Add("Cost with tax: ");
            }
            //lstOut.Items.Add("Customer Name: " + custName);
            // lstOut.Items.Add("Days entered is: " + totalDays);
            //      lstOut.Items.Add("Vehicle type selected:");
            //  lstOut.Items.Add("Selected vehicle type rate: " + rateDaily.ToString("C"));
            //  lstOut.Items.Add("Vehicle rental cost: " + costCar.ToString("C"));
            //      lstOut.Items.Add("Tax rate: ");
            //      lstOut.Items.Add("Tax charge: ");
            //      lstOut.Items.Add("Cost with tax: ");
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



        }
    }
}
