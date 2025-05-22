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
            txtDays = new TextBox();
            btnCalc = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            lstOut = new ListBox();
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            grp = new GroupBox();
            rdoCompact = new RadioButton();
            rdoSUV = new RadioButton();
            rdoSedan = new RadioButton();
            OFD = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            numberArrayTestToolStripMenuItem = new ToolStripMenuItem();
            showLogToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            grp.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            // txtDays
            // 
            txtDays.Location = new Point(494, 143);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(100, 25);
            txtDays.TabIndex = 4;
            txtDays.Enter += txtDays_Enter;
            txtDays.Leave += txtDays_Leave;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(49, 440);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 26);
            btnCalc.TabIndex = 7;
            btnCalc.Text = "&Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(264, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 26);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clea&r";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(519, 440);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 26);
            btnQuit.TabIndex = 9;
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
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(382, 109);
            lblName.Name = "lblName";
            lblName.Size = new Size(106, 17);
            lblName.TabIndex = 11;
            lblName.Text = "Customer &Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(494, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 25);
            txtName.TabIndex = 2;
            txtName.Enter += txtName_Enter;
            txtName.Leave += txtName_Leave;
            // 
            // grp
            // 
            grp.Controls.Add(rdoCompact);
            grp.Controls.Add(rdoSUV);
            grp.Controls.Add(rdoSedan);
            grp.Location = new Point(49, 101);
            grp.Name = "grp";
            grp.Size = new Size(200, 114);
            grp.TabIndex = 12;
            grp.TabStop = false;
            grp.Text = "Vehicle Size";
            // 
            // rdoCompact
            // 
            rdoCompact.AutoSize = true;
            rdoCompact.Location = new Point(11, 87);
            rdoCompact.Name = "rdoCompact";
            rdoCompact.Size = new Size(77, 21);
            rdoCompact.TabIndex = 2;
            rdoCompact.TabStop = true;
            rdoCompact.Text = "Compact";
            rdoCompact.UseVisualStyleBackColor = true;
            rdoCompact.CheckedChanged += rdoCompact_CheckedChanged;
            // 
            // rdoSUV
            // 
            rdoSUV.AutoSize = true;
            rdoSUV.Location = new Point(11, 60);
            rdoSUV.Name = "rdoSUV";
            rdoSUV.Size = new Size(50, 21);
            rdoSUV.TabIndex = 1;
            rdoSUV.TabStop = true;
            rdoSUV.Text = "SUV";
            rdoSUV.UseVisualStyleBackColor = true;
            rdoSUV.CheckedChanged += rdoSUV_CheckedChanged;
            // 
            // rdoSedan
            // 
            rdoSedan.AutoSize = true;
            rdoSedan.Location = new Point(11, 33);
            rdoSedan.Name = "rdoSedan";
            rdoSedan.Size = new Size(62, 21);
            rdoSedan.TabIndex = 0;
            rdoSedan.TabStop = true;
            rdoSedan.Text = "Sedan";
            rdoSedan.UseVisualStyleBackColor = true;
            rdoSedan.CheckedChanged += rdoSedan_CheckedChanged;
            // 
            // OFD
            // 
            OFD.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { numberArrayTestToolStripMenuItem, showLogToolStripMenuItem, settingsToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // numberArrayTestToolStripMenuItem
            // 
            numberArrayTestToolStripMenuItem.Name = "numberArrayTestToolStripMenuItem";
            numberArrayTestToolStripMenuItem.Size = new Size(144, 20);
            numberArrayTestToolStripMenuItem.Text = "Number Array Test Tool";
            numberArrayTestToolStripMenuItem.Click += numberArrayTestToolStripMenuItem_Click;
            // 
            // showLogToolStripMenuItem
            // 
            showLogToolStripMenuItem.Name = "showLogToolStripMenuItem";
            showLogToolStripMenuItem.Size = new Size(71, 20);
            showLogToolStripMenuItem.Text = "Show Log";
            showLogToolStripMenuItem.Click += showLogToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(42, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(grp);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(txtDays);
            Controls.Add(lblDays);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Zebs Whips";
            Load += Form1_Load;
            grp.ResumeLayout(false);
            grp.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDays;
        private TextBox txtDays;
        private Button btnCalc;
        private Button btnClear;
        private Button btnQuit;
        private ListBox lstOut;
        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private GroupBox grp;
        private RadioButton rdoCompact;
        private RadioButton rdoSUV;
        private RadioButton rdoSedan;
        private OpenFileDialog OFD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem numberArrayTestToolStripMenuItem;
        private ToolStripMenuItem showLogToolStripMenuItem;
    }
}
