namespace BankEnumerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCreateBank = new Button();
            grpBoxEnumarator = new GroupBox();
            btnMusteri = new Button();
            cmbBoxIslem = new ComboBox();
            txtBoxTurkishID = new TextBox();
            lblIdentity = new Label();
            lstBoxVip = new ListBox();
            lstBoxBireysel = new ListBox();
            lstBoxGise = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCreateHelpDesk = new Button();
            grpBoxEnumarator.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateBank
            // 
            btnCreateBank.BackColor = Color.FromArgb(128, 255, 255);
            btnCreateBank.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCreateBank.Location = new Point(12, 12);
            btnCreateBank.Name = "btnCreateBank";
            btnCreateBank.Size = new Size(124, 61);
            btnCreateBank.TabIndex = 0;
            btnCreateBank.Text = "Create Bank";
            btnCreateBank.UseVisualStyleBackColor = false;
            btnCreateBank.Click += btnCreateBank_Click;
            // 
            // grpBoxEnumarator
            // 
            grpBoxEnumarator.Controls.Add(btnMusteri);
            grpBoxEnumarator.Controls.Add(cmbBoxIslem);
            grpBoxEnumarator.Controls.Add(txtBoxTurkishID);
            grpBoxEnumarator.Controls.Add(lblIdentity);
            grpBoxEnumarator.Location = new Point(12, 91);
            grpBoxEnumarator.Name = "grpBoxEnumarator";
            grpBoxEnumarator.Size = new Size(279, 185);
            grpBoxEnumarator.TabIndex = 1;
            grpBoxEnumarator.TabStop = false;
            grpBoxEnumarator.Text = "Enumarator";
            // 
            // btnMusteri
            // 
            btnMusteri.Location = new Point(82, 100);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Size = new Size(191, 55);
            btnMusteri.TabIndex = 3;
            btnMusteri.Text = "Take Number";
            btnMusteri.UseVisualStyleBackColor = true;
            btnMusteri.Click += btnMusteri_Click;
            // 
            // cmbBoxIslem
            // 
            cmbBoxIslem.FormattingEnabled = true;
            cmbBoxIslem.Location = new Point(82, 66);
            cmbBoxIslem.Name = "cmbBoxIslem";
            cmbBoxIslem.Size = new Size(191, 28);
            cmbBoxIslem.TabIndex = 2;
            // 
            // txtBoxTurkishID
            // 
            txtBoxTurkishID.Location = new Point(82, 33);
            txtBoxTurkishID.Name = "txtBoxTurkishID";
            txtBoxTurkishID.Size = new Size(191, 27);
            txtBoxTurkishID.TabIndex = 1;
            // 
            // lblIdentity
            // 
            lblIdentity.AutoSize = true;
            lblIdentity.Location = new Point(6, 36);
            lblIdentity.Name = "lblIdentity";
            lblIdentity.Size = new Size(70, 20);
            lblIdentity.TabIndex = 0;
            lblIdentity.Text = "TurkishID";
            // 
            // lstBoxVip
            // 
            lstBoxVip.FormattingEnabled = true;
            lstBoxVip.ItemHeight = 20;
            lstBoxVip.Location = new Point(12, 282);
            lstBoxVip.Name = "lstBoxVip";
            lstBoxVip.Size = new Size(279, 164);
            lstBoxVip.TabIndex = 2;
            // 
            // lstBoxBireysel
            // 
            lstBoxBireysel.FormattingEnabled = true;
            lstBoxBireysel.ItemHeight = 20;
            lstBoxBireysel.Location = new Point(297, 282);
            lstBoxBireysel.Name = "lstBoxBireysel";
            lstBoxBireysel.Size = new Size(279, 164);
            lstBoxBireysel.TabIndex = 3;
            // 
            // lstBoxGise
            // 
            lstBoxGise.FormattingEnabled = true;
            lstBoxGise.ItemHeight = 20;
            lstBoxGise.Location = new Point(582, 282);
            lstBoxGise.Name = "lstBoxGise";
            lstBoxGise.Size = new Size(279, 164);
            lstBoxGise.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(429, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(432, 234);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // btnCreateHelpDesk
            // 
            btnCreateHelpDesk.Location = new Point(329, 12);
            btnCreateHelpDesk.Name = "btnCreateHelpDesk";
            btnCreateHelpDesk.Size = new Size(94, 61);
            btnCreateHelpDesk.TabIndex = 6;
            btnCreateHelpDesk.Text = "Create Help Desk";
            btnCreateHelpDesk.UseVisualStyleBackColor = true;
            btnCreateHelpDesk.Click += btnCreateHelpDesk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 453);
            Controls.Add(btnCreateHelpDesk);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lstBoxGise);
            Controls.Add(lstBoxBireysel);
            Controls.Add(lstBoxVip);
            Controls.Add(grpBoxEnumarator);
            Controls.Add(btnCreateBank);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Bank Enumerator";
            Load += Form1_Load;
            grpBoxEnumarator.ResumeLayout(false);
            grpBoxEnumarator.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateBank;
        private GroupBox grpBoxEnumarator;
        private TextBox txtBoxTurkishID;
        private Label lblIdentity;
        private Button btnMusteri;
        private ComboBox cmbBoxIslem;
        private ListBox lstBoxVip;
        private ListBox lstBoxBireysel;
        private ListBox lstBoxGise;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCreateHelpDesk;
    }
}