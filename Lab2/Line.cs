using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Line : IFigure
    {
        System.Windows.Forms.PictureBox pictureBox1;
        public Line(System.Windows.Forms.PictureBox pictureBox1)
        {
            this.pictureBox1 = pictureBox1;
        }
        public void Draw(Graphics g, Pen pen, Point start, Point finish)
        {
            g.DrawLine(pen, start, finish);
        }
        public override string ToString()
        {
            return "Линия";
        }
    }
}
