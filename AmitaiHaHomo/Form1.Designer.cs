namespace AmitaiHaHomo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox encryptedText;
        private System.Windows.Forms.Button encryptedBtn;

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
            this.encryptedText = new System.Windows.Forms.TextBox();
            this.encryptedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encryptedText
            // 
            this.encryptedText.Location = new System.Drawing.Point(60, 169);
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.Size = new System.Drawing.Size(246, 20);
            this.encryptedText.TabIndex = 0;
            this.encryptedText.Text = "PLS enter the encrypted text";
            this.encryptedText.TextChanged += new System.EventHandler(this.EncryptedText_TextChanged);
            // 
            // encryptedBtn
            // 
            this.encryptedBtn.Location = new System.Drawing.Point(114, 252);
            this.encryptedBtn.Name = "encryptedBtn";
            this.encryptedBtn.Size = new System.Drawing.Size(144, 52);
            this.encryptedBtn.TabIndex = 1;
            this.encryptedBtn.Text = "Decrypt";
            this.encryptedBtn.UseVisualStyleBackColor = true;
            this.encryptedBtn.Click += new System.EventHandler(this.EncryptedBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(383, 385);
            this.Controls.Add(this.encryptedBtn);
            this.Controls.Add(this.encryptedText);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

