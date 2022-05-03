namespace Lab2
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.figureBox = new System.Windows.Forms.ComboBox();
            this.widthBar = new System.Windows.Forms.TrackBar();
            this.colorBox = new System.Windows.Forms.ColorDialog();
            this.Color = new System.Windows.Forms.Button();
            this.angleBox = new System.Windows.Forms.ComboBox();
            this.BrokenBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.redoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fillBox = new System.Windows.Forms.ColorDialog();
            this.fillBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1092, 622);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // figureBox
            // 
            this.figureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figureBox.FormattingEnabled = true;
            this.figureBox.Location = new System.Drawing.Point(383, 14);
            this.figureBox.Name = "figureBox";
            this.figureBox.Size = new System.Drawing.Size(121, 21);
            this.figureBox.TabIndex = 1;
            this.figureBox.SelectedIndexChanged += new System.EventHandler(this.figureBox_SelectedIndexChanged);
            // 
            // widthBar
            // 
            this.widthBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.widthBar.Location = new System.Drawing.Point(12, 12);
            this.widthBar.Minimum = 1;
            this.widthBar.Name = "widthBar";
            this.widthBar.Size = new System.Drawing.Size(106, 45);
            this.widthBar.TabIndex = 2;
            this.widthBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.widthBar.Value = 1;
            this.widthBar.Scroll += new System.EventHandler(this.widthBar_Scroll);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(12, 50);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(59, 23);
            this.Color.TabIndex = 3;
            this.Color.Text = "Цвет";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // angleBox
            // 
            this.angleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.angleBox.FormattingEnabled = true;
            this.angleBox.Location = new System.Drawing.Point(216, 14);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(52, 21);
            this.angleBox.TabIndex = 4;
            // 
            // BrokenBtn
            // 
            this.BrokenBtn.Location = new System.Drawing.Point(383, 47);
            this.BrokenBtn.Name = "BrokenBtn";
            this.BrokenBtn.Size = new System.Drawing.Size(121, 23);
            this.BrokenBtn.TabIndex = 5;
            this.BrokenBtn.Text = "Ломанная";
            this.BrokenBtn.UseVisualStyleBackColor = true;
            this.BrokenBtn.Click += new System.EventHandler(this.BrokenBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Location = new System.Drawing.Point(146, 50);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(52, 23);
            this.undoBtn.TabIndex = 6;
            this.undoBtn.Text = "undo";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // redoBtn
            // 
            this.redoBtn.Location = new System.Drawing.Point(214, 50);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(54, 23);
            this.redoBtn.TabIndex = 7;
            this.redoBtn.Text = "redo";
            this.redoBtn.UseVisualStyleBackColor = true;
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "N-углов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фигуры:";
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(77, 50);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(63, 23);
            this.fillBtn.TabIndex = 10;
            this.fillBtn.Text = "Заливка";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 583);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redoBtn);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.BrokenBtn);
            this.Controls.Add(this.angleBox);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.widthBar);
            this.Controls.Add(this.figureBox);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1103, 622);
            this.MinimumSize = new System.Drawing.Size(1103, 622);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox figureBox;
        private System.Windows.Forms.TrackBar widthBar;
        private System.Windows.Forms.ColorDialog colorBox;
        private System.Windows.Forms.Button Color;
        public System.Windows.Forms.ComboBox angleBox;
        private System.Windows.Forms.Button BrokenBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button redoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog fillBox;
        private System.Windows.Forms.Button fillBtn;
    }
}

