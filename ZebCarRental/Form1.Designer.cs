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
            lblForm = new Label();
            SuspendLayout();
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(49, 167);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(148, 17);
            lblDays.TabIndex = 3;
            lblDays.Text = "Enter total da&ys rented:";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(49, 128);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(78, 17);
            lblRate.TabIndex = 1;
            lblRate.Text = "Daily Ra&te: ";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(203, 120);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 25);
            txtRate.TabIndex = 2;
            // 
            // txtDays
            // 
            txtDays.Location = new Point(203, 164);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(100, 25);
            txtDays.TabIndex = 4;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(49, 440);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 26);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "&Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(264, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 26);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clea&r";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(492, 440);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 26);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 17;
            lstOut.Location = new Point(49, 243);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(518, 174);
            lstOut.TabIndex = 9;
            lstOut.TabStop = false;
            // 
            // lblForm
            // 
            lblForm.AutoSize = true;
            lblForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForm.Location = new Point(49, 42);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(126, 21);
            lblForm.TabIndex = 10;
            lblForm.Text = "Zeb's Car Rental";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(lblForm);
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
        private Label lblForm;
    }
}
