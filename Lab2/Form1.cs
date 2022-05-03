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
    public partial class Form1 : Form
    {
        Factory factory;
        public Stack<IFigure> figureStack;
        public Stack<IFigure> undoStack;
        private Point start;
        private bool drawing = false;
        private Image orig;
        Bitmap bm;
        Bitmap bm2;
        int penWidth;
        
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            figureBox.Items.Add("Линия");
            figureBox.Items.Add("Прямоугольник");
            figureBox.Items.Add("Эллипс");
            figureBox.Items.Add("Многоугольник");
            factory = new Factory(angleBox);
            figureStack = new Stack<IFigure>();
            undoStack = new Stack<IFigure>();
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bm2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            fillBox.Color = System.Drawing.Color.White;

            for (int i = 3; i < 21; i++)
            {
                angleBox.Items.Add(i);
            }
            angleBox.SelectedItem = angleBox.Items[0];
        }

        private void pictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (figureStack.Count != 0)
            {
                Point finish = new Point(e.X, e.Y);
                Graphics g = Graphics.FromImage(bm);
                Pen pen = new Pen(colorBox.Color, widthBar.Value);
                figureStack.Peek().Draw(g, pen, start, finish);
                Pen fillPen = new Pen(fillBox.Color, pen.Width);
                figureStack.Peek().Fill(g, fillPen, start, finish);
                g.Save();
                drawing = false;
                g.Dispose();
                pictureBox1.Invalidate();
            }
        }

        public void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (Convert.ToString(figureBox.SelectedItem) != "")
            {
                figureStack.Push(factory.create(Convert.ToString(figureBox.SelectedItem)));
                undoStack.Clear();
            }
            if (figureStack.Count != 0)
            {
                start = new Point(e.X, e.Y);
                orig = bm;
                drawing = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
            if (!drawing) return;
            if (figureStack.Count != 0)
            {
                Point finish = new Point(e.X, e.Y);
                bm2.Dispose();
                bm2 = new Bitmap(bm);
                pictureBox1.Image = bm2;
                Pen pen = new Pen(colorBox.Color, widthBar.Value);
                Graphics g = Graphics.FromImage(bm2);
                figureStack.Peek().Draw(g, pen, start, finish);
                Pen fillPen = new Pen(fillBox.Color, pen.Width);
                figureStack.Peek().Fill(g, fillPen, start, finish);
                g.Dispose();
                pictureBox1.Invalidate();
            }
            
        }

        private void figureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void widthBar_Scroll(object sender, EventArgs e)
        {
            penWidth = widthBar.Value;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            colorBox.ShowDialog();
        }

        private void BrokenBtn_Click(object sender, EventArgs e)
        {
            BrokenForm BrokenForm = new BrokenForm(this, figureStack);
            BrokenForm.ShowDialog();
            undoStack.Clear();
            Point finish = new Point(0, 0);
            Graphics g = Graphics.FromImage(bm);
            Pen pen = new Pen(colorBox.Color, widthBar.Value);
            figureStack.Peek().Draw(g, pen, start, finish);
            g.Save();
            pictureBox1.Image = bm;
            g.Dispose();
            pictureBox1.Invalidate();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            if (figureStack.Count != 0)
            {
                Graphics g = Graphics.FromImage(bm);
                Pen pen = new Pen(System.Drawing.Color.White, widthBar.Value);
                figureStack.Peek().Undo(g, pen);
                g.Save();
                pictureBox1.Image = bm;
                g.Dispose();
                pictureBox1.Invalidate();
                undoStack.Push(figureStack.Pop());
            }
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            if (undoStack.Count != 0)
            {
                Graphics g = Graphics.FromImage(bm);
                Pen pen = new Pen(System.Drawing.Color.White, widthBar.Value);
                undoStack.Peek().reDraw(g);
                g.Save();
                pictureBox1.Image = bm;
                g.Dispose();
                pictureBox1.Invalidate();
                figureStack.Push(undoStack.Pop());
            }
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            fillBox.ShowDialog();
        }
    }
}
