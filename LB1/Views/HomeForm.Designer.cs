namespace LB1
{
    partial class HomeForm
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
            this.BankBox = new System.Windows.Forms.ComboBox();
            this.BankText = new System.Windows.Forms.Label();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BankBox
            // 
            this.BankBox.FormattingEnabled = true;
            this.BankBox.Location = new System.Drawing.Point(12, 50);
            this.BankBox.Name = "BankBox";
            this.BankBox.Size = new System.Drawing.Size(121, 21);
            this.BankBox.TabIndex = 0;
            // 
            // BankText
            // 
            this.BankText.AutoSize = true;
            this.BankText.Location = new System.Drawing.Point(12, 24);
            this.BankText.Name = "BankText";
            this.BankText.Size = new System.Drawing.Size(82, 13);
            this.BankText.TabIndex = 1;
            this.BankText.Text = "Текущий банк:";
            // 
            // CreateAccount
            // 
            this.CreateAccount.Location = new System.Drawing.Point(15, 117);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(118, 23);
            this.CreateAccount.TabIndex = 2;
            this.CreateAccount.Text = "Создать счет";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.BankText);
            this.Controls.Add(this.BankBox);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BankBox;
        private System.Windows.Forms.Label BankText;
        private System.Windows.Forms.Button CreateAccount;
    }
}