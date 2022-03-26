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
            this.SuspendLayout();
            // 
            // periodBox
            // 
            this.periodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodBox.FormattingEnabled = true;
            this.periodBox.Location = new System.Drawing.Point(491, 133);
            this.periodBox.Name = "periodBox";
            this.periodBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.periodBox.Size = new System.Drawing.Size(121, 21);
            this.periodBox.TabIndex = 0;
            this.periodBox.SelectedIndexChanged += new System.EventHandler(this.periodBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Период:";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(304, 133);
            this.amountBox.Name = "amountBox";
            this.amountBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сумма:";
            // 
            // percentBox
            // 
            this.percentBox.Location = new System.Drawing.Point(682, 133);
            this.percentBox.Name = "percentBox";
            this.percentBox.ReadOnly = true;
            this.percentBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.percentBox.Size = new System.Drawing.Size(37, 20);
            this.percentBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Процент:";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(304, 179);
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
            this.pickBox.Location = new System.Drawing.Point(304, 91);
            this.pickBox.Name = "pickBox";
            this.pickBox.Size = new System.Drawing.Size(100, 21);
            this.pickBox.TabIndex = 7;
            // 
            // bankBox
            // 
            this.bankBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankBox.FormattingEnabled = true;
            this.bankBox.Location = new System.Drawing.Point(491, 91);
            this.bankBox.Name = "bankBox";
            this.bankBox.Size = new System.Drawing.Size(121, 21);
            this.bankBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Банк:";
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
    }
}