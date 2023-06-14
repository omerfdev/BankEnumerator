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
            groupBox1 = new GroupBox();
            lblIdentity = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblIdentity);
            groupBox1.Location = new Point(12, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 233);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
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
            // textBox1
            // 
            textBox1.Location = new Point(82, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(groupBox1);
            Controls.Add(btnCreateBank);
            Name = "Form1";
            Text = "Bank Enumerator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateBank;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label lblIdentity;
    }
}