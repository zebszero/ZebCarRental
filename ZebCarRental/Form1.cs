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
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDays.Clear();
            txtRate.Clear();
            txtRate.Focus();
            lstOut.Items.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declare/read variables from txtbx
            double totalDays, rateDaily, totalCost;
            //input
            totalDays = int.Parse(txtDays.Text);
            rateDaily = double.Parse(txtRate.Text);
            //processing
            totalCost = totalDays * rateDaily;
            //output
            lstOut.Items.Add("Total rental cost is " + totalCost);



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
    }
}
