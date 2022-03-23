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
            this.SuspendLayout();
            // 
            // accBox
            // 
            this.accBox.FormattingEnabled = true;
            this.accBox.Location = new System.Drawing.Point(250, 100);
            this.accBox.Name = "accBox";
            this.accBox.Size = new System.Drawing.Size(300, 21);
            this.accBox.TabIndex = 0;
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
            // AccInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
    }
}