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

    }
}
