namespace LB1
{
    partial class OperatorForm
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
            this.logBox = new System.Windows.Forms.ListBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.salaryBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isApprovedBox = new System.Windows.Forms.TextBox();
            this.companyNameBox = new System.Windows.Forms.TextBox();
            this.periodBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.moneyTypeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.approveBtn = new System.Windows.Forms.Button();
            this.logConstBox = new System.Windows.Forms.ListBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.HorizontalScrollbar = true;
            this.logBox.Location = new System.Drawing.Point(12, 12);
            this.logBox.Name = "logBox";
            this.logBox.ScrollAlwaysVisible = true;
            this.logBox.Size = new System.Drawing.Size(760, 238);
            this.logBox.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(620, 267);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(152, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Отменить действие";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(620, 488);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(152, 23);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Выход";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // salaryBox
            // 
            this.salaryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salaryBox.FormattingEnabled = true;
            this.salaryBox.Location = new System.Drawing.Point(40, 297);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(100, 21);
            this.salaryBox.TabIndex = 3;
            this.salaryBox.SelectedIndexChanged += new System.EventHandler(this.salaryBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Заявки на зарплатный проект:";
            // 
            // isApprovedBox
            // 
            this.isApprovedBox.Location = new System.Drawing.Point(40, 436);
            this.isApprovedBox.Name = "isApprovedBox";
            this.isApprovedBox.ReadOnly = true;
            this.isApprovedBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isApprovedBox.Size = new System.Drawing.Size(221, 20);
            this.isApprovedBox.TabIndex = 5;
            // 
            // companyNameBox
            // 
            this.companyNameBox.Location = new System.Drawing.Point(40, 359);
            this.companyNameBox.Name = "companyNameBox";
            this.companyNameBox.ReadOnly = true;
            this.companyNameBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.companyNameBox.Size = new System.Drawing.Size(221, 20);
            this.companyNameBox.TabIndex = 6;
            // 
            // periodBox
            // 
            this.periodBox.Location = new System.Drawing.Point(40, 385);
            this.periodBox.Name = "periodBox";
            this.periodBox.ReadOnly = true;
            this.periodBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.periodBox.Size = new System.Drawing.Size(221, 20);
            this.periodBox.TabIndex = 7;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(40, 411);
            this.amountBox.Name = "amountBox";
            this.amountBox.ReadOnly = true;
            this.amountBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amountBox.Size = new System.Drawing.Size(221, 20);
            this.amountBox.TabIndex = 8;
            // 
            // userIDBox
            // 
            this.userIDBox.Location = new System.Drawing.Point(40, 462);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.ReadOnly = true;
            this.userIDBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userIDBox.Size = new System.Drawing.Size(221, 20);
            this.userIDBox.TabIndex = 9;
            // 
            // moneyTypeBox
            // 
            this.moneyTypeBox.Location = new System.Drawing.Point(40, 488);
            this.moneyTypeBox.Name = "moneyTypeBox";
            this.moneyTypeBox.ReadOnly = true;
            this.moneyTypeBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.moneyTypeBox.Size = new System.Drawing.Size(221, 20);
            this.moneyTypeBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Информация о заявке:";
            // 
            // approveBtn
            // 
            this.approveBtn.Location = new System.Drawing.Point(168, 297);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(93, 23);
            this.approveBtn.TabIndex = 12;
            this.approveBtn.Text = "Подтвердить";
            this.approveBtn.UseVisualStyleBackColor = true;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // logConstBox
            // 
            this.logConstBox.FormattingEnabled = true;
            this.logConstBox.HorizontalScrollbar = true;
            this.logConstBox.Location = new System.Drawing.Point(267, 297);
            this.logConstBox.Name = "logConstBox";
            this.logConstBox.ScrollAlwaysVisible = true;
            this.logConstBox.Size = new System.Drawing.Size(340, 212);
            this.logConstBox.TabIndex = 13;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.logConstBox);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moneyTypeBox);
            this.Controls.Add(this.userIDBox);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.periodBox);
            this.Controls.Add(this.companyNameBox);
            this.Controls.Add(this.isApprovedBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.logBox);
            this.Name = "OperatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox salaryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox moneyTypeBox;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox periodBox;
        private System.Windows.Forms.TextBox companyNameBox;
        private System.Windows.Forms.TextBox isApprovedBox;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.ListBox logConstBox;
        private System.Diagnostics.EventLog eventLog1;
    }
}