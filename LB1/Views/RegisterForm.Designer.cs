namespace LB1
{
    partial class RegisterForm
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
            this.RegistrateButton = new System.Windows.Forms.Button();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondNameBox = new System.Windows.Forms.TextBox();
            this.FatherNameBox = new System.Windows.Forms.TextBox();
            this.PassportDataLabel = new System.Windows.Forms.Label();
            this.IdNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmBox = new System.Windows.Forms.TextBox();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.PassportDataBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneNumBox = new System.Windows.Forms.MaskedTextBox();
            this.EmailBox = new System.Windows.Forms.MaskedTextBox();
            this.IdNumberBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // RegistrateButton
            // 
            this.RegistrateButton.Location = new System.Drawing.Point(227, 326);
            this.RegistrateButton.Name = "RegistrateButton";
            this.RegistrateButton.Size = new System.Drawing.Size(130, 23);
            this.RegistrateButton.TabIndex = 11;
            this.RegistrateButton.Text = "Зарегистрироваться";
            this.RegistrateButton.UseVisualStyleBackColor = true;
            this.RegistrateButton.Click += new System.EventHandler(this.RegistrateButton_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(444, 107);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameBox.TabIndex = 4;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(266, 110);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отчество";
            // 
            // SecondNameBox
            // 
            this.SecondNameBox.Location = new System.Drawing.Point(444, 134);
            this.SecondNameBox.Name = "SecondNameBox";
            this.SecondNameBox.Size = new System.Drawing.Size(100, 20);
            this.SecondNameBox.TabIndex = 5;
            // 
            // FatherNameBox
            // 
            this.FatherNameBox.Location = new System.Drawing.Point(444, 161);
            this.FatherNameBox.Name = "FatherNameBox";
            this.FatherNameBox.Size = new System.Drawing.Size(100, 20);
            this.FatherNameBox.TabIndex = 6;
            // 
            // PassportDataLabel
            // 
            this.PassportDataLabel.AutoSize = true;
            this.PassportDataLabel.Location = new System.Drawing.Point(266, 190);
            this.PassportDataLabel.Name = "PassportDataLabel";
            this.PassportDataLabel.Size = new System.Drawing.Size(132, 13);
            this.PassportDataLabel.TabIndex = 8;
            this.PassportDataLabel.Text = "Серия и номер паспорта";
            // 
            // IdNumberLabel
            // 
            this.IdNumberLabel.AutoSize = true;
            this.IdNumberLabel.Location = new System.Drawing.Point(266, 216);
            this.IdNumberLabel.Name = "IdNumberLabel";
            this.IdNumberLabel.Size = new System.Drawing.Size(149, 13);
            this.IdNumberLabel.TabIndex = 12;
            this.IdNumberLabel.Text = "Идентификационный номер";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(266, 268);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 13;
            this.EmailLabel.Text = "E-mail";
            // 
            // PhoneNumLabel
            // 
            this.PhoneNumLabel.AutoSize = true;
            this.PhoneNumLabel.Location = new System.Drawing.Point(266, 242);
            this.PhoneNumLabel.Name = "PhoneNumLabel";
            this.PhoneNumLabel.Size = new System.Drawing.Size(52, 13);
            this.PhoneNumLabel.TabIndex = 14;
            this.PhoneNumLabel.Text = "Телефон";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(444, 53);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 2;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(444, 27);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 20);
            this.LoginBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(266, 30);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 17;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(266, 56);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Пароль";
            // 
            // ConfirmBox
            // 
            this.ConfirmBox.Location = new System.Drawing.Point(444, 81);
            this.ConfirmBox.Name = "ConfirmBox";
            this.ConfirmBox.PasswordChar = '*';
            this.ConfirmBox.Size = new System.Drawing.Size(100, 20);
            this.ConfirmBox.TabIndex = 3;
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Location = new System.Drawing.Point(266, 84);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(112, 13);
            this.ConfirmLabel.TabIndex = 20;
            this.ConfirmLabel.Text = "Подтвердите пароль";
            this.ConfirmLabel.Click += new System.EventHandler(this.ConfirmLabel_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 25);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 21;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // PassportDataBox
            // 
            this.PassportDataBox.Location = new System.Drawing.Point(444, 187);
            this.PassportDataBox.Mask = ">LL0000000";
            this.PassportDataBox.Name = "PassportDataBox";
            this.PassportDataBox.Size = new System.Drawing.Size(100, 20);
            this.PassportDataBox.TabIndex = 7;
            // 
            // PhoneNumBox
            // 
            this.PhoneNumBox.Location = new System.Drawing.Point(444, 239);
            this.PhoneNumBox.Mask = "+375(00) 000-00-00";
            this.PhoneNumBox.Name = "PhoneNumBox";
            this.PhoneNumBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumBox.TabIndex = 9;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(444, 265);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 20);
            this.EmailBox.TabIndex = 22;
            // 
            // IdNumberBox
            // 
            this.IdNumberBox.Location = new System.Drawing.Point(444, 213);
            this.IdNumberBox.Mask = ">0000000L000LL0";
            this.IdNumberBox.Name = "IdNumberBox";
            this.IdNumberBox.Size = new System.Drawing.Size(100, 20);
            this.IdNumberBox.TabIndex = 23;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.IdNumberBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneNumBox);
            this.Controls.Add(this.PassportDataBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.ConfirmBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PhoneNumLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.IdNumberLabel);
            this.Controls.Add(this.PassportDataLabel);
            this.Controls.Add(this.FatherNameBox);
            this.Controls.Add(this.SecondNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.RegistrateButton);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrateButton;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SecondNameBox;
        private System.Windows.Forms.TextBox FatherNameBox;
        private System.Windows.Forms.Label PassportDataLabel;
        private System.Windows.Forms.Label IdNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox ConfirmBox;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.MaskedTextBox PassportDataBox;
        private System.Windows.Forms.MaskedTextBox PhoneNumBox;
        private System.Windows.Forms.MaskedTextBox EmailBox;
        private System.Windows.Forms.MaskedTextBox IdNumberBox;
    }
}