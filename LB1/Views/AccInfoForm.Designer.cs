namespace LB1
{
    partial class AccInfoForm
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
            this.accBox = new System.Windows.Forms.ComboBox();
            this.accLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.moneyTypeLabel = new System.Windows.Forms.Label();
            this.dataCreationLabel = new System.Windows.Forms.Label();
            this.ownerBox = new System.Windows.Forms.TextBox();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.moneyTypeBox = new System.Windows.Forms.TextBox();
            this.dataCreationBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accBox
            // 
            this.accBox.Location = new System.Drawing.Point(250, 100);
            this.accBox.Name = "accBox";
            this.accBox.Size = new System.Drawing.Size(300, 21);
            this.accBox.TabIndex = 0;
            this.accBox.SelectedIndexChanged += new System.EventHandler(this.accBox_SelectedIndexChanged);
            this.accBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // accLabel
            // 
            this.accLabel.AutoSize = true;
            this.accLabel.Location = new System.Drawing.Point(365, 69);
            this.accLabel.Name = "accLabel";
            this.accLabel.Size = new System.Drawing.Size(82, 13);
            this.accLabel.TabIndex = 1;
            this.accLabel.Text = "Выберите счет";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(24, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(42, 174);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(59, 13);
            this.ownerLabel.TabIndex = 3;
            this.ownerLabel.Text = "Владелец:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(42, 206);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(47, 13);
            this.balanceLabel.TabIndex = 4;
            this.balanceLabel.Text = "Баланс:";
            // 
            // moneyTypeLabel
            // 
            this.moneyTypeLabel.AutoSize = true;
            this.moneyTypeLabel.Location = new System.Drawing.Point(42, 239);
            this.moneyTypeLabel.Name = "moneyTypeLabel";
            this.moneyTypeLabel.Size = new System.Drawing.Size(71, 13);
            this.moneyTypeLabel.TabIndex = 5;
            this.moneyTypeLabel.Text = "Вид валюты:";
            this.moneyTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataCreationLabel
            // 
            this.dataCreationLabel.AutoSize = true;
            this.dataCreationLabel.Location = new System.Drawing.Point(42, 275);
            this.dataCreationLabel.Name = "dataCreationLabel";
            this.dataCreationLabel.Size = new System.Drawing.Size(87, 13);
            this.dataCreationLabel.TabIndex = 6;
            this.dataCreationLabel.Text = "Дата создания:";
            // 
            // ownerBox
            // 
            this.ownerBox.Location = new System.Drawing.Point(164, 174);
            this.ownerBox.Name = "ownerBox";
            this.ownerBox.ReadOnly = true;
            this.ownerBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ownerBox.Size = new System.Drawing.Size(145, 20);
            this.ownerBox.TabIndex = 8;
            // 
            // balanceBox
            // 
            this.balanceBox.Location = new System.Drawing.Point(164, 206);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.ReadOnly = true;
            this.balanceBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.balanceBox.Size = new System.Drawing.Size(145, 20);
            this.balanceBox.TabIndex = 9;
            // 
            // moneyTypeBox
            // 
            this.moneyTypeBox.Location = new System.Drawing.Point(164, 236);
            this.moneyTypeBox.Name = "moneyTypeBox";
            this.moneyTypeBox.ReadOnly = true;
            this.moneyTypeBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.moneyTypeBox.Size = new System.Drawing.Size(145, 20);
            this.moneyTypeBox.TabIndex = 10;
            // 
            // dataCreationBox
            // 
            this.dataCreationBox.Location = new System.Drawing.Point(164, 268);
            this.dataCreationBox.Name = "dataCreationBox";
            this.dataCreationBox.ReadOnly = true;
            this.dataCreationBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataCreationBox.Size = new System.Drawing.Size(145, 20);
            this.dataCreationBox.TabIndex = 11;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(431, 171);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(119, 23);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Удалить счет";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // AccInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dataCreationBox);
            this.Controls.Add(this.moneyTypeBox);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.ownerBox);
            this.Controls.Add(this.dataCreationLabel);
            this.Controls.Add(this.moneyTypeLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.accLabel);
            this.Controls.Add(this.accBox);
            this.Name = "AccInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccInfoForm";
            this.Load += new System.EventHandler(this.AccInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox accBox;
        private System.Windows.Forms.Label accLabel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label moneyTypeLabel;
        private System.Windows.Forms.Label dataCreationLabel;
        private System.Windows.Forms.TextBox ownerBox;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.TextBox moneyTypeBox;
        private System.Windows.Forms.TextBox dataCreationBox;
        private System.Windows.Forms.Button deleteBtn;
    }
}