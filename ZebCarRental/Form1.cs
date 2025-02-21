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
            string txtDays;
            double txtRate;
            double totalCost;
            //read text boxes in variables
            //parse convert strings to int/variable
            txtDays = string.Parse(int);
            txtRate = double.Parse(txtRate.Text);
            totalCost = txtDays * txtRate;

            lstOut.Items.Add(totalCost);

            
            
        }
    }
}
