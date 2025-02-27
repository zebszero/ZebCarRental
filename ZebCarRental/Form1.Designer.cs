namespace ZebCarRental
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDays = new Label();
            lblRate = new Label();
            txtRate = new TextBox();
            txtDays = new TextBox();
            btnCalc = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            lstOut = new ListBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(340, 151);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(148, 17);
            lblDays.TabIndex = 3;
            lblDays.Text = "Enter total da&ys rented:";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(410, 198);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(78, 17);
            lblRate.TabIndex = 1;
            lblRate.Text = "Daily Ra&te: ";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(494, 190);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 25);
            txtRate.TabIndex = 4;
            txtRate.Enter += txtRate_Enter;
            txtRate.Leave += txtRate_Leave;
            // 
            // txtDays
            // 
            txtDays.Location = new Point(494, 143);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(100, 25);
            txtDays.TabIndex = 2;
            txtDays.Enter += txtDays_Enter;
            txtDays.Leave += txtDays_Leave;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(49, 440);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 26);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "&Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(264, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 26);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clea&r";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(519, 440);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 26);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 17;
            lstOut.Location = new Point(49, 243);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(545, 174);
            lstOut.TabIndex = 9;
            lstOut.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(49, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(126, 21);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Zeb's Car Rental";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(lblTitle);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(txtDays);
            Controls.Add(txtRate);
            Controls.Add(lblRate);
            Controls.Add(lblDays);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Zebs Whips";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDays;
        private Label lblRate;
        private TextBox txtRate;
        private TextBox txtDays;
        private Button btnCalc;
        private Button btnClear;
        private Button btnQuit;
        private ListBox lstOut;
        private Label lblTitle;
        //private RadioButton rdoSedan;
        //private RadioButton rdoSUV;
        //private RadioButton rdoPickUp;
        //private GroupBox grpEconomy;
    }
}
