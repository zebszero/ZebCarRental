namespace ZebCarRental
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private string carType;
        const string SEDAN = "Sedan";
        const string SUV = "SUV";
        const string COMP = "Compact";
        const double taxMin = 0.0;
        const double taxMax = 10.0;
        private string logFile = "Rental Log File.txt";
        internal string cfgFile = "Configuration.txt";
        private double sedanRate;
        private double suvRate;
        private double compRate;
        private double taxRate;
        private double MIN_Rate = -1;
        const int LISTBOX = 1;
        const int LOGFILE = 2;
        const int BOTH = 3;
        // ica 9, declare form to object
        private Form2 sf;

        internal double SedanRate
        {
            get { return sedanRate; }
            set
            {
                if (value > MIN_Rate)
                {
                    sedanRate = value;
                }
            }

        }
        internal double SuvRate
        {
            get { return suvRate; }
            set
            {
                if (value > MIN_Rate)
                {
                    suvRate = value;
                }
            }
        }
        internal double CompRate
        {
            get { return compRate; }
            set
            {
                if (value > MIN_Rate)
                {
                    compRate = value;
                }
            }
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
            lstOut.Items.Clear();
            txtName.Focus();
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
            custName = txtName.Text.Trim();

            // pretend widget name is a name of a person
            // this code is not required for your project
            // but you may want to use it if you have a customer name

            string fName, lName;
            int posSpace;

            posSpace = custName.IndexOf(" ");
            if (posSpace != -1)
            {
                fName = custName.Substring(0, posSpace);
                lName = custName.Substring(posSpace).Trim();
                lstOut.Items.Add("First Name is " + fName);
                lstOut.Items.Add("Last Name is " + lName);
            }


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
                outputTrans("*************** Beginning of Transaction " + DateTime.Now.ToString("G") + "  *****************", LOGFILE);
                outputTrans("Customer Name: " + custName,BOTH);
                outputTrans("Days entered is: " + totalDays, BOTH);
                //      lstOut.Items.Add("Vehicle type selected:");
                outputTrans("Selected vehicle type rate: " + rateDaily.ToString("C"), BOTH);
                outputTrans("Vehicle rental cost: " + costCar.ToString("C"), BOTH);
                //      lstOut.Items.Add("Tax rate: ");
                //      lstOut.Items.Add("Tax charge: ");
                //      lstOut.Items.Add("Cost with tax: ");

            }
            
            else
            {
                if (!totalDaysValid)
                {
                    lstOut.Items.Add("Total Days should be whole number.");
                }
                if (!rateDailyValid)
                {
                    lstOut.Items.Add("Daily Rate must be typed as '$1.23.");
                }
            }





        }

        private void outputTrans (string msg, int outputType)

        {
            StreamWriter swLog;
            if (outputType == LISTBOX || outputType == BOTH)
            {
                lstOut.Items.Add(msg);
            }
            if (outputType == LOGFILE || outputType == BOTH)
            {
                swLog = File.AppendText(logFile);
                swLog.WriteLine(msg);
                swLog.Close();
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
            //create sf, which is a form2 object
            sf = new Form2(this);

            rdoSedan.Checked = true;
            bool fileWasNotFound = true;
            do
            {
                try
                {
                    srCFG = File.OpenText(cfgFile);
                    fileWasNotFound = false;
                    try
                    {
                        SedanRate = double.Parse(srCFG.ReadLine());
                        SuvRate = double.Parse(srCFG.ReadLine());
                        CompRate = double.Parse(srCFG.ReadLine());
                        srCFG.Close();
                    }
                    catch (FormatException ex)
                    {
                        lstOut.ForeColor = Color.Red;
                        lstOut.Items.Add("File data  corrupted. Values were set to defaults");
                        lstOut.Items.Add(ex.Message);
                        sedanRate = 40;
                        suvRate = 60;
                        compRate = 50;
                        srCFG.Close();
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message + " Please enter a new file name", "File Not Found");
                    // OFD.InitialDirectory = 
                    OFD.Filter = "Text Files|*.txt| All Files |*.*";
                    OFD.Title = "Open Configuration File";
                    OFD.ShowDialog();
                    cfgFile = OFD.FileName;
                }
            } while (fileWasNotFound);

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
            if (rdoCompact.Checked)
            {
                carType = COMP;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sf.txtSedanRate.Text = SedanRate.ToString();
            sf.txtSUVRate.Text = SuvRate.ToString();
            sf.txtCompRate.Text = CompRate.ToString();
            sf.ShowDialog();
        }

        private void showLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const int MAX_LINES = 2000;
            string[] logLines = new string[MAX_LINES];
            StreamReader sr = File.OpenText(logFile);
            int numLines = 0;
            while (!sr.EndOfStream)
            {
                logLines[numLines] = sr.ReadLine();
                numLines++;
            }
            int begin = -2;
            int end = 4;
            for (int i = 0; i < numLines; i++)
            {
                if (logLines[i] == "The vehicle type is " + carType)
                {
                    for (int j = i + begin; j <= i + end; j++)
                    {
                        lstOut.Items.Add(logLines[j]);
                    }
                }

            }

            double[] grades = new double[MAX_LINES];




            sr.Close();
        }

        private void numberArrayTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[50];
            for (int i = 0; i < 25; i++)
            {
                numbers[i] = i;
            }
            lstOut.Items.Add(numbers.Average());
        }
    }
}
