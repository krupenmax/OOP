using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class BrokenForm : Form
    {
        Form Form1;
        BrokenLine brokenLine = new BrokenLine();
        Stack<IFigure> stack;
        public BrokenForm(Form Form1, Stack<IFigure> stack)
        {
            InitializeComponent();
            this.Form1 = Form1;
            this.stack = stack;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (brokenLine.LineList.Count >= 2)
            {
                stack.Push(brokenLine);
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Недостаточно координат");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(xBox.Text, out num))
            {
                if (int.TryParse(yBox.Text, out num))
                {
                    Point point = new Point();
                    if (Convert.ToInt16(xBox.Text) <= Form1.Width && Convert.ToInt16(yBox.Text) <= Form1.Height)
                    {
                        point.X = Convert.ToInt16(xBox.Text);
                        point.Y = Convert.ToInt16(yBox.Text);
                        brokenLine.LineList.Add(point);
                    }
                    else
                    {
                        MessageBox.Show("Неверные координаты");
                    }
                }
                else
                {
                    MessageBox.Show("Вводите только числа");
                }
            }
            else
            {
                MessageBox.Show("Вводите только числа");
            }
        }
    }
}
