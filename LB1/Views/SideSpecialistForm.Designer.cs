namespace LB1
{
    partial class SideSpecialistForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.idSlrBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.periodBox = new System.Windows.Forms.TextBox();
            this.companyBox = new System.Windows.Forms.TextBox();
            this.moneyTypeBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.isApprovedBox = new System.Windows.Forms.TextBox();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bankBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.createAccBtn = new System.Windows.Forms.Button();
            this.moneyTypeAccBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bankBox2 = new System.Windows.Forms.ComboBox();
            this.amountTransfer = new System.Windows.Forms.TextBox();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.receiverText = new System.Windows.Forms.Label();
            this.senderText = new System.Windows.Forms.Label();
            this.receiverBox = new System.Windows.Forms.TextBox();
            this.senderBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(274, 390);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(198, 23);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Выход";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // idSlrBox
            // 
            this.idSlrBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idSlrBox.FormattingEnabled = true;
            this.idSlrBox.Location = new System.Drawing.Point(213, 51);
            this.idSlrBox.Name = "idSlrBox";
            this.idSlrBox.Size = new System.Drawing.Size(100, 21);
            this.idSlrBox.TabIndex = 1;
            this.idSlrBox.SelectedIndexChanged += new System.EventHandler(this.idSlrBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID проекта:";
            // 
            // periodBox
            // 
            this.periodBox.Location = new System.Drawing.Point(213, 105);
            this.periodBox.Name = "periodBox";
            this.periodBox.ReadOnly = true;
            this.periodBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.periodBox.Size = new System.Drawing.Size(100, 20);
            this.periodBox.TabIndex = 3;
            // 
            // companyBox
            // 
            this.companyBox.Location = new System.Drawing.Point(213, 79);
            this.companyBox.Name = "companyBox";
            this.companyBox.ReadOnly = true;
            this.companyBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.companyBox.Size = new System.Drawing.Size(100, 20);
            this.companyBox.TabIndex = 4;
            // 
            // moneyTypeBox
            // 
            this.moneyTypeBox.Location = new System.Drawing.Point(213, 209);
            this.moneyTypeBox.Name = "moneyTypeBox";
            this.moneyTypeBox.ReadOnly = true;
            this.moneyTypeBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.moneyTypeBox.Size = new System.Drawing.Size(100, 20);
            this.moneyTypeBox.TabIndex = 5;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(213, 131);
            this.amountBox.Name = "amountBox";
            this.amountBox.ReadOnly = true;
            this.amountBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 6;
            // 
            // isApprovedBox
            // 
            this.isApprovedBox.Location = new System.Drawing.Point(213, 157);
            this.isApprovedBox.Name = "isApprovedBox";
            this.isApprovedBox.ReadOnly = true;
            this.isApprovedBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isApprovedBox.Size = new System.Drawing.Size(100, 20);
            this.isApprovedBox.TabIndex = 7;
            // 
            // userIDBox
            // 
            this.userIDBox.Location = new System.Drawing.Point(213, 183);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.ReadOnly = true;
            this.userIDBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userIDBox.Size = new System.Drawing.Size(100, 20);
            this.userIDBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Предприятие:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Период:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сумма:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Подтвержден";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID пользователя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Валюта:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Отправить заявку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bankBox
            // 
            this.bankBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankBox.FormattingEnabled = true;
            this.bankBox.Location = new System.Drawing.Point(467, 253);
            this.bankBox.Name = "bankBox";
            this.bankBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bankBox.Size = new System.Drawing.Size(182, 21);
            this.bankBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Банк:";
            // 
            // createAccBtn
            // 
            this.createAccBtn.Location = new System.Drawing.Point(467, 322);
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Size = new System.Drawing.Size(182, 23);
            this.createAccBtn.TabIndex = 18;
            this.createAccBtn.Text = "Создать счет";
            this.createAccBtn.UseVisualStyleBackColor = true;
            this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
            // 
            // moneyTypeAccBox
            // 
            this.moneyTypeAccBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moneyTypeAccBox.FormattingEnabled = true;
            this.moneyTypeAccBox.Location = new System.Drawing.Point(467, 286);
            this.moneyTypeAccBox.Name = "moneyTypeAccBox";
            this.moneyTypeAccBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.moneyTypeAccBox.Size = new System.Drawing.Size(182, 21);
            this.moneyTypeAccBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(583, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Сумма перевода:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(586, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Банк:";
            // 
            // bankBox2
            // 
            this.bankBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankBox2.FormattingEnabled = true;
            this.bankBox2.Location = new System.Drawing.Point(586, 122);
            this.bankBox2.Name = "bankBox2";
            this.bankBox2.Size = new System.Drawing.Size(121, 21);
            this.bankBox2.TabIndex = 26;
            // 
            // amountTransfer
            // 
            this.amountTransfer.Location = new System.Drawing.Point(586, 52);
            this.amountTransfer.Name = "amountTransfer";
            this.amountTransfer.Size = new System.Drawing.Size(121, 20);
            this.amountTransfer.TabIndex = 25;
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(405, 178);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(302, 23);
            this.TransferBtn.TabIndex = 24;
            this.TransferBtn.Text = "Перевести";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // receiverText
            // 
            this.receiverText.AutoSize = true;
            this.receiverText.Location = new System.Drawing.Point(402, 95);
            this.receiverText.Name = "receiverText";
            this.receiverText.Size = new System.Drawing.Size(178, 13);
            this.receiverText.TabIndex = 23;
            this.receiverText.Text = "Введите номер счета получателя:";
            // 
            // senderText
            // 
            this.senderText.AutoSize = true;
            this.senderText.Location = new System.Drawing.Point(715, 474);
            this.senderText.Name = "senderText";
            this.senderText.Size = new System.Drawing.Size(152, 13);
            this.senderText.TabIndex = 22;
            this.senderText.Text = "Выберите счет отправителя:";
            // 
            // receiverBox
            // 
            this.receiverBox.Location = new System.Drawing.Point(405, 121);
            this.receiverBox.Name = "receiverBox";
            this.receiverBox.Size = new System.Drawing.Size(121, 20);
            this.receiverBox.TabIndex = 21;
            // 
            // senderBox
            // 
            this.senderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.senderBox.FormattingEnabled = true;
            this.senderBox.Location = new System.Drawing.Point(405, 54);
            this.senderBox.Name = "senderBox";
            this.senderBox.Size = new System.Drawing.Size(121, 21);
            this.senderBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(402, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Валюта:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(402, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Выберите счет отправителя:";
            // 
            // SideSpecialistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 442);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bankBox2);
            this.Controls.Add(this.amountTransfer);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.receiverText);
            this.Controls.Add(this.senderText);
            this.Controls.Add(this.receiverBox);
            this.Controls.Add(this.senderBox);
            this.Controls.Add(this.moneyTypeAccBox);
            this.Controls.Add(this.createAccBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bankBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userIDBox);
            this.Controls.Add(this.isApprovedBox);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.moneyTypeBox);
            this.Controls.Add(this.companyBox);
            this.Controls.Add(this.periodBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idSlrBox);
            this.Controls.Add(this.backBtn);
            this.Name = "SideSpecialistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SideSpecialistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox idSlrBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox periodBox;
        private System.Windows.Forms.TextBox companyBox;
        private System.Windows.Forms.TextBox moneyTypeBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox isApprovedBox;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox bankBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createAccBtn;
        private System.Windows.Forms.ComboBox moneyTypeAccBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox bankBox2;
        private System.Windows.Forms.TextBox amountTransfer;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Label receiverText;
        private System.Windows.Forms.Label senderText;
        private System.Windows.Forms.TextBox receiverBox;
        private System.Windows.Forms.ComboBox senderBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}