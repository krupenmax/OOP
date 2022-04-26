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
        private Point start;
        private bool drawing = false;
        private Image orig;
        Bitmap bm;
        Bitmap bm2;
        IFigure figure;
        public Form1()
        {
            InitializeComponent();
            Factory factory = new Factory();
            figure = factory.create("Линия", pictureBox1);
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bm2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point finish = new Point(e.X, e.Y);
            Graphics g = Graphics.FromImage(bm);
            Pen pen = new Pen(Color.Black, 2);
            figure.Draw(g, pen, start, finish);
            g.Save();
            drawing = false;
            g.Dispose();
            pictureBox1.Invalidate();
        }

        public void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
            orig = bm;
            drawing = true;
        }

        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (!drawing) return;
            Point finish = new Point(e.X, e.Y);
            bm2.Dispose();
            bm2 = new Bitmap(bm);
            pictureBox1.Image = bm2;
            Pen pen = new Pen(Color.Black, 2);
            Graphics g = Graphics.FromImage(bm2);
            figure.Draw(g, pen, start, finish);
            g.Dispose();
            pictureBox1.Invalidate();
        }
    }
}
