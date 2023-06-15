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
            btnCreateBank = new Button();
            grpBoxEnumarator = new GroupBox();
            btnMusteri = new Button();
            cmbBoxIslem = new ComboBox();
            txtBoxTurkishID = new TextBox();
            lblIdentity = new Label();
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
            grpBoxEnumarator.Size = new Size(279, 161);
            grpBoxEnumarator.TabIndex = 1;
            grpBoxEnumarator.TabStop = false;
            grpBoxEnumarator.Text = "Numaratör";
            // 
            // btnMusteri
            // 
            btnMusteri.Location = new Point(179, 114);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Size = new Size(94, 29);
            btnMusteri.TabIndex = 3;
            btnMusteri.Text = "Sıra Al";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(grpBoxEnumarator);
            Controls.Add(btnCreateBank);
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
    }
}