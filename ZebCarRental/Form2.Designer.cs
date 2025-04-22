namespace ZebCarRental
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSedanRate = new Label();
            lblSuvRate = new Label();
            lblCompRate = new Label();
            txtSedanRate = new TextBox();
            txtSUVRate = new TextBox();
            txtCompRate = new TextBox();
            btnSave = new Button();
            txtTitle = new Label();
            lblTax = new Label();
            txtTaxRate = new TextBox();
            SuspendLayout();
            // 
            // lblSedanRate
            // 
            lblSedanRate.AutoSize = true;
            lblSedanRate.Location = new Point(23, 91);
            lblSedanRate.Name = "lblSedanRate";
            lblSedanRate.Size = new Size(68, 15);
            lblSedanRate.TabIndex = 0;
            lblSedanRate.Text = "Sedan Rate:";
            // 
            // lblSuvRate
            // 
            lblSuvRate.AutoSize = true;
            lblSuvRate.Location = new Point(23, 126);
            lblSuvRate.Name = "lblSuvRate";
            lblSuvRate.Size = new Size(57, 15);
            lblSuvRate.TabIndex = 1;
            lblSuvRate.Text = "SUV Rate:";
            // 
            // lblCompRate
            // 
            lblCompRate.AutoSize = true;
            lblCompRate.Location = new Point(23, 161);
            lblCompRate.Name = "lblCompRate";
            lblCompRate.Size = new Size(85, 15);
            lblCompRate.TabIndex = 2;
            lblCompRate.Text = "Compact Rate:";
            // 
            // txtSedanRate
            // 
            txtSedanRate.Location = new Point(136, 88);
            txtSedanRate.Name = "txtSedanRate";
            txtSedanRate.Size = new Size(100, 23);
            txtSedanRate.TabIndex = 3;
            // 
            // txtSUVRate
            // 
            txtSUVRate.Location = new Point(136, 123);
            txtSUVRate.Name = "txtSUVRate";
            txtSUVRate.Size = new Size(100, 23);
            txtSUVRate.TabIndex = 4;
            // 
            // txtCompRate
            // 
            txtCompRate.Location = new Point(136, 158);
            txtCompRate.Name = "txtCompRate";
            txtCompRate.Size = new Size(100, 23);
            txtCompRate.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(92, 268);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Con&firm && Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(23, 28);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(88, 21);
            txtTitle.TabIndex = 7;
            txtTitle.Text = "Daily Rate";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(23, 201);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(50, 15);
            lblTax.TabIndex = 8;
            lblTax.Text = "Tax Rate";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(136, 198);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(100, 23);
            txtTaxRate.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 322);
            Controls.Add(txtTaxRate);
            Controls.Add(lblTax);
            Controls.Add(txtTitle);
            Controls.Add(btnSave);
            Controls.Add(txtCompRate);
            Controls.Add(txtSUVRate);
            Controls.Add(txtSedanRate);
            Controls.Add(lblCompRate);
            Controls.Add(lblSuvRate);
            Controls.Add(lblSedanRate);
            Name = "Form2";
            Text = "Settings Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSedanRate;
        private Label lblSuvRate;
        private Label lblCompRate;
        private Button btnSave;
        private Label txtTitle;
        private Label lblTax;
        internal TextBox txtSedanRate;
        internal TextBox txtSUVRate;
        internal TextBox txtCompRate;
        internal TextBox txtTaxRate;
    }
}