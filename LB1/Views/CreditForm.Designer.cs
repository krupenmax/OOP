namespace LB1
{
    partial class CreditForm
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
            this.periodBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.percentBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.pickBox = new System.Windows.Forms.ComboBox();
            this.bankBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoBox = new System.Windows.Forms.ComboBox();
            this.InstalInfoBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.amountInfoBox = new System.Windows.Forms.TextBox();
            this.periodInfoBox = new System.Windows.Forms.TextBox();
            this.creationTimeInfoBox = new System.Windows.Forms.TextBox();
            this.percentInfoBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.moneyTypeBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.moneyTypeCredit = new System.Windows.Forms.TextBox();
            this.isApprovedBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.periodAd = new System.Windows.Forms.TextBox();
            this.periodLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // periodBox
            // 
            this.periodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodBox.FormattingEnabled = true;
            this.periodBox.Location = new System.Drawing.Point(594, 127);
            this.periodBox.Name = "periodBox";
            this.periodBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.periodBox.Size = new System.Drawing.Size(121, 21);
            this.periodBox.TabIndex = 0;
            this.periodBox.SelectedIndexChanged += new System.EventHandler(this.periodBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Период:";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(407, 127);
            this.amountBox.Name = "amountBox";
            this.amountBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сумма:";
            // 
            // percentBox
            // 
            this.percentBox.Location = new System.Drawing.Point(678, 205);
            this.percentBox.Name = "percentBox";
            this.percentBox.ReadOnly = true;
            this.percentBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.percentBox.Size = new System.Drawing.Size(37, 20);
            this.percentBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Процент:";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(407, 224);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(100, 23);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Оформить";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // pickBox
            // 
            this.pickBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickBox.FormattingEnabled = true;
            this.pickBox.Location = new System.Drawing.Point(407, 85);
            this.pickBox.Name = "pickBox";
            this.pickBox.Size = new System.Drawing.Size(100, 21);
            this.pickBox.TabIndex = 7;
            this.pickBox.SelectedIndexChanged += new System.EventHandler(this.pickBox_SelectedIndexChanged);
            // 
            // bankBox
            // 
            this.bankBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankBox.FormattingEnabled = true;
            this.bankBox.Location = new System.Drawing.Point(594, 85);
            this.bankBox.Name = "bankBox";
            this.bankBox.Size = new System.Drawing.Size(121, 21);
            this.bankBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Банк:";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(79, 34);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Кредит/рассрочка";
            // 
            // InfoBox
            // 
            this.InfoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InfoBox.FormattingEnabled = true;
            this.InfoBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.InfoBox.Location = new System.Drawing.Point(594, 305);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(121, 21);
            this.InfoBox.TabIndex = 12;
            this.InfoBox.SelectedIndexChanged += new System.EventHandler(this.InfoBox_SelectedIndexChanged);
            // 
            // InstalInfoBox
            // 
            this.InstalInfoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstalInfoBox.FormattingEnabled = true;
            this.InstalInfoBox.Location = new System.Drawing.Point(594, 345);
            this.InstalInfoBox.Name = "InstalInfoBox";
            this.InstalInfoBox.Size = new System.Drawing.Size(121, 21);
            this.InstalInfoBox.TabIndex = 13;
            this.InstalInfoBox.SelectedIndexChanged += new System.EventHandler(this.InstalInfoBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Выберите кредит:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Выберите рассрочку:";
            // 
            // amountInfoBox
            // 
            this.amountInfoBox.Location = new System.Drawing.Point(237, 305);
            this.amountInfoBox.Name = "amountInfoBox";
            this.amountInfoBox.ReadOnly = true;
            this.amountInfoBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amountInfoBox.Size = new System.Drawing.Size(164, 20);
            this.amountInfoBox.TabIndex = 16;
            // 
            // periodInfoBox
            // 
            this.periodInfoBox.Location = new System.Drawing.Point(237, 357);
            this.periodInfoBox.Name = "periodInfoBox";
            this.periodInfoBox.ReadOnly = true;
            this.periodInfoBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.periodInfoBox.Size = new System.Drawing.Size(164, 20);
            this.periodInfoBox.TabIndex = 17;
            // 
            // creationTimeInfoBox
            // 
            this.creationTimeInfoBox.Location = new System.Drawing.Point(237, 383);
            this.creationTimeInfoBox.Name = "creationTimeInfoBox";
            this.creationTimeInfoBox.ReadOnly = true;
            this.creationTimeInfoBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creationTimeInfoBox.Size = new System.Drawing.Size(164, 20);
            this.creationTimeInfoBox.TabIndex = 18;
            // 
            // percentInfoBox
            // 
            this.percentInfoBox.Location = new System.Drawing.Point(237, 331);
            this.percentInfoBox.Name = "percentInfoBox";
            this.percentInfoBox.ReadOnly = true;
            this.percentInfoBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.percentInfoBox.Size = new System.Drawing.Size(164, 20);
            this.percentInfoBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Информация:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Сумма кредита:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Процент:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Период выплаты кредита:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Дата выдачи:";
            // 
            // moneyTypeBox
            // 
            this.moneyTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moneyTypeBox.FormattingEnabled = true;
            this.moneyTypeBox.Location = new System.Drawing.Point(407, 164);
            this.moneyTypeBox.Name = "moneyTypeBox";
            this.moneyTypeBox.Size = new System.Drawing.Size(100, 21);
            this.moneyTypeBox.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Вид валюты:";
            // 
            // moneyTypeCredit
            // 
            this.moneyTypeCredit.Location = new System.Drawing.Point(237, 435);
            this.moneyTypeCredit.Name = "moneyTypeCredit";
            this.moneyTypeCredit.ReadOnly = true;
            this.moneyTypeCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.moneyTypeCredit.Size = new System.Drawing.Size(164, 20);
            this.moneyTypeCredit.TabIndex = 27;
            // 
            // isApprovedBox
            // 
            this.isApprovedBox.Location = new System.Drawing.Point(237, 409);
            this.isApprovedBox.Name = "isApprovedBox";
            this.isApprovedBox.ReadOnly = true;
            this.isApprovedBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isApprovedBox.Size = new System.Drawing.Size(164, 20);
            this.isApprovedBox.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(82, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Подтвержден:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(82, 438);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Валюта:";
            // 
            // periodAd
            // 
            this.periodAd.Location = new System.Drawing.Point(682, 164);
            this.periodAd.Name = "periodAd";
            this.periodAd.Size = new System.Drawing.Size(33, 20);
            this.periodAd.TabIndex = 31;
            this.periodAd.Text = "24";
            this.periodAd.Visible = false;
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(619, 168);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(48, 13);
            this.periodLabel.TabIndex = 32;
            this.periodLabel.Text = "Период:";
            this.periodLabel.Visible = false;
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.periodAd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.isApprovedBox);
            this.Controls.Add(this.moneyTypeCredit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.moneyTypeBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.percentInfoBox);
            this.Controls.Add(this.creationTimeInfoBox);
            this.Controls.Add(this.periodInfoBox);
            this.Controls.Add(this.amountInfoBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InstalInfoBox);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bankBox);
            this.Controls.Add(this.pickBox);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.percentBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodBox);
            this.Name = "CreditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox periodBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox percentBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.ComboBox pickBox;
        private System.Windows.Forms.ComboBox bankBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox InfoBox;
        private System.Windows.Forms.ComboBox InstalInfoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amountInfoBox;
        private System.Windows.Forms.TextBox periodInfoBox;
        private System.Windows.Forms.TextBox creationTimeInfoBox;
        private System.Windows.Forms.TextBox percentInfoBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox moneyTypeBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox moneyTypeCredit;
        private System.Windows.Forms.TextBox isApprovedBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox periodAd;
        private System.Windows.Forms.Label periodLabel;
    }
}