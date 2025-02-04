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
            lblDays.Location = new Point(49, 147);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(128, 15);
            lblDays.TabIndex = 0;
            lblDays.Text = "Enter total days rented:";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(49, 113);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(65, 15);
            lblRate.TabIndex = 1;
            lblRate.Text = "Daily Rate: ";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(205, 105);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 3;
            // 
            // txtDays
            // 
            txtDays.Location = new Point(205, 139);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(100, 23);
            txtDays.TabIndex = 5;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(49, 388);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(264, 388);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(492, 388);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(49, 214);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(518, 154);
            lstOut.TabIndex = 9;
            // 
            // lblForm
            // 
            lblForm.AutoSize = true;
            lblForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForm.Location = new Point(49, 37);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(126, 21);
            lblForm.TabIndex = 10;
            lblForm.Text = "Zeb's Car Rental";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblForm);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(txtDays);
            Controls.Add(txtRate);
            Controls.Add(lblRate);
            Controls.Add(lblDays);
            Name = "Form1";
            Text = "Form1";
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
