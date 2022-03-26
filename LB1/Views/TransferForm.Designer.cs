namespace LB1
{
    partial class TransferForm
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
            this.senderBox = new System.Windows.Forms.ComboBox();
            this.receiverBox = new System.Windows.Forms.TextBox();
            this.senderText = new System.Windows.Forms.Label();
            this.receiverText = new System.Windows.Forms.Label();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.bankBox = new System.Windows.Forms.ComboBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // senderBox
            // 
            this.senderBox.FormattingEnabled = true;
            this.senderBox.Location = new System.Drawing.Point(63, 108);
            this.senderBox.Name = "senderBox";
            this.senderBox.Size = new System.Drawing.Size(121, 21);
            this.senderBox.TabIndex = 0;
            // 
            // receiverBox
            // 
            this.receiverBox.Location = new System.Drawing.Point(328, 108);
            this.receiverBox.Name = "receiverBox";
            this.receiverBox.Size = new System.Drawing.Size(121, 20);
            this.receiverBox.TabIndex = 1;
            // 
            // senderText
            // 
            this.senderText.AutoSize = true;
            this.senderText.Location = new System.Drawing.Point(60, 82);
            this.senderText.Name = "senderText";
            this.senderText.Size = new System.Drawing.Size(152, 13);
            this.senderText.TabIndex = 2;
            this.senderText.Text = "Выберите счет отправителя:";
            // 
            // receiverText
            // 
            this.receiverText.AutoSize = true;
            this.receiverText.Location = new System.Drawing.Point(325, 81);
            this.receiverText.Name = "receiverText";
            this.receiverText.Size = new System.Drawing.Size(178, 13);
            this.receiverText.TabIndex = 3;
            this.receiverText.Text = "Введите номер счета получателя:";
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(503, 108);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(75, 23);
            this.TransferBtn.TabIndex = 4;
            this.TransferBtn.Text = "Перевести";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(209, 108);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 5;
            // 
            // bankBox
            // 
            this.bankBox.FormattingEnabled = true;
            this.bankBox.Location = new System.Drawing.Point(328, 134);
            this.bankBox.Name = "bankBox";
            this.bankBox.Size = new System.Drawing.Size(121, 21);
            this.bankBox.TabIndex = 6;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(63, 26);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.bankBox);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.receiverText);
            this.Controls.Add(this.senderText);
            this.Controls.Add(this.receiverBox);
            this.Controls.Add(this.senderBox);
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox senderBox;
        private System.Windows.Forms.TextBox receiverBox;
        private System.Windows.Forms.Label senderText;
        private System.Windows.Forms.Label receiverText;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.ComboBox bankBox;
        private System.Windows.Forms.Button backBtn;
    }
}