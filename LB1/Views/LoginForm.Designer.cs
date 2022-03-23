namespace LB1
{
    partial class LoginForm
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
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AuthorizeBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(200, 88);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(200, 20);
            this.LoginBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(200, 114);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(200, 20);
            this.PasswordBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(143, 91);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(143, 117);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Пароль";
            // 
            // AuthorizeBtn
            // 
            this.AuthorizeBtn.Location = new System.Drawing.Point(225, 158);
            this.AuthorizeBtn.Name = "AuthorizeBtn";
            this.AuthorizeBtn.Size = new System.Drawing.Size(150, 23);
            this.AuthorizeBtn.TabIndex = 4;
            this.AuthorizeBtn.Text = "Авторизироваться";
            this.AuthorizeBtn.UseVisualStyleBackColor = true;
            this.AuthorizeBtn.Click += new System.EventHandler(this.AuthorizeBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(12, 12);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.ReturnBtn.TabIndex = 5;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.AuthorizeBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button AuthorizeBtn;
        private System.Windows.Forms.Button ReturnBtn;
    }
}