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
            this.AccInfoBtn = new System.Windows.Forms.Button();
            this.CloseAccBtn = new System.Windows.Forms.Button();
            this.TranserBtn = new System.Windows.Forms.Button();
            this.SalaryProjectBtn = new System.Windows.Forms.Button();
            this.CreditsPibBtn = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BankBox
            // 
            this.BankBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankBox.FormattingEnabled = true;
            this.BankBox.ItemHeight = 31;
            this.BankBox.Location = new System.Drawing.Point(252, 31);
            this.BankBox.Name = "BankBox";
            this.BankBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BankBox.Size = new System.Drawing.Size(204, 39);
            this.BankBox.TabIndex = 0;
            this.BankBox.SelectedIndexChanged += new System.EventHandler(this.BankBox_SelectedIndexChanged);
            // 
            // BankText
            // 
            this.BankText.AutoSize = true;
            this.BankText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankText.Location = new System.Drawing.Point(12, 31);
            this.BankText.Name = "BankText";
            this.BankText.Size = new System.Drawing.Size(213, 31);
            this.BankText.TabIndex = 1;
            this.BankText.Text = "Текущий банк:";
            // 
            // CreateAccount
            // 
            this.CreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateAccount.Location = new System.Drawing.Point(95, 120);
            this.CreateAccount.Margin = new System.Windows.Forms.Padding(0);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(200, 100);
            this.CreateAccount.TabIndex = 2;
            this.CreateAccount.Text = "Создать счет";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // AccInfoBtn
            // 
            this.AccInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccInfoBtn.Location = new System.Drawing.Point(295, 120);
            this.AccInfoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AccInfoBtn.Name = "AccInfoBtn";
            this.AccInfoBtn.Size = new System.Drawing.Size(200, 100);
            this.AccInfoBtn.TabIndex = 3;
            this.AccInfoBtn.Text = "Информация о счетах";
            this.AccInfoBtn.UseVisualStyleBackColor = true;
            this.AccInfoBtn.Click += new System.EventHandler(this.AccInfoBtn_Click);
            // 
            // CloseAccBtn
            // 
            this.CloseAccBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseAccBtn.Location = new System.Drawing.Point(495, 120);
            this.CloseAccBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseAccBtn.Name = "CloseAccBtn";
            this.CloseAccBtn.Size = new System.Drawing.Size(200, 100);
            this.CloseAccBtn.TabIndex = 4;
            this.CloseAccBtn.Text = "Закрыть счет";
            this.CloseAccBtn.UseVisualStyleBackColor = true;
            // 
            // TranserBtn
            // 
            this.TranserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TranserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranserBtn.Location = new System.Drawing.Point(95, 223);
            this.TranserBtn.Name = "TranserBtn";
            this.TranserBtn.Size = new System.Drawing.Size(200, 100);
            this.TranserBtn.TabIndex = 5;
            this.TranserBtn.Text = "Переводы";
            this.TranserBtn.UseVisualStyleBackColor = true;
            // 
            // SalaryProjectBtn
            // 
            this.SalaryProjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryProjectBtn.Location = new System.Drawing.Point(295, 223);
            this.SalaryProjectBtn.Name = "SalaryProjectBtn";
            this.SalaryProjectBtn.Size = new System.Drawing.Size(200, 100);
            this.SalaryProjectBtn.TabIndex = 6;
            this.SalaryProjectBtn.Text = "Заявка на зарплатный проект";
            this.SalaryProjectBtn.UseVisualStyleBackColor = true;
            // 
            // CreditsPibBtn
            // 
            this.CreditsPibBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditsPibBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreditsPibBtn.Location = new System.Drawing.Point(495, 223);
            this.CreditsPibBtn.Name = "CreditsPibBtn";
            this.CreditsPibBtn.Size = new System.Drawing.Size(200, 100);
            this.CreditsPibBtn.TabIndex = 7;
            this.CreditsPibBtn.Text = "Кредиты / рассрочки";
            this.CreditsPibBtn.UseVisualStyleBackColor = true;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(257, 37);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(177, 25);
            this.WarningLabel.TabIndex = 8;
            this.WarningLabel.Text = "Выберите банк";
            this.WarningLabel.Visible = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.CreditsPibBtn);
            this.Controls.Add(this.SalaryProjectBtn);
            this.Controls.Add(this.TranserBtn);
            this.Controls.Add(this.CloseAccBtn);
            this.Controls.Add(this.AccInfoBtn);
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
        private System.Windows.Forms.Button AccInfoBtn;
        private System.Windows.Forms.Button CloseAccBtn;
        private System.Windows.Forms.Button TranserBtn;
        private System.Windows.Forms.Button SalaryProjectBtn;
        private System.Windows.Forms.Button CreditsPibBtn;
        private System.Windows.Forms.Label WarningLabel;
    }
}