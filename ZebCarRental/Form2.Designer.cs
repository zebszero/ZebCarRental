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
            txtSedanRate = new Label();
            txtSuvRate = new Label();
            txtCompRate = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnSave = new Button();
            txtTitle = new Label();
            SuspendLayout();
            // 
            // txtSedanRate
            // 
            txtSedanRate.AutoSize = true;
            txtSedanRate.Location = new Point(23, 91);
            txtSedanRate.Name = "txtSedanRate";
            txtSedanRate.Size = new Size(68, 15);
            txtSedanRate.TabIndex = 0;
            txtSedanRate.Text = "Sedan Rate:";
            // 
            // txtSuvRate
            // 
            txtSuvRate.AutoSize = true;
            txtSuvRate.Location = new Point(23, 152);
            txtSuvRate.Name = "txtSuvRate";
            txtSuvRate.Size = new Size(57, 15);
            txtSuvRate.TabIndex = 1;
            txtSuvRate.Text = "SUV Rate:";
            // 
            // txtCompRate
            // 
            txtCompRate.AutoSize = true;
            txtCompRate.Location = new Point(23, 210);
            txtCompRate.Name = "txtCompRate";
            txtCompRate.Size = new Size(85, 15);
            txtCompRate.TabIndex = 2;
            txtCompRate.Text = "Compact Rate:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(51, 268);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Con&firm";
            btnSave.UseVisualStyleBackColor = true;
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 322);
            Controls.Add(txtTitle);
            Controls.Add(btnSave);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtCompRate);
            Controls.Add(txtSuvRate);
            Controls.Add(txtSedanRate);
            Name = "Form2";
            Text = "Settings Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtSedanRate;
        private Label txtSuvRate;
        private Label txtCompRate;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnSave;
        private Label txtTitle;
    }
}