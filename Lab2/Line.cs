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
        Point start;
        Point finish;
        int width;
        Color color;

        public void Draw(Graphics g, Pen pen, Point start, Point finish)
        {
            this.start = start;
            this.finish = finish;
            color = pen.Color;
            width = Convert.ToInt16(pen.Width);
            g.DrawLine(pen, start, finish);
        }

        public void Undo(Graphics g, Pen pen)
        {
            pen.Width = width;
            g.DrawLine(pen, start, finish);
        }

        public void reDraw(Graphics g)
        {
            Pen pen = new Pen(color, width);
            g.DrawLine(pen, start, finish);
        }

        public void Fill(Graphics g, Pen pen, Point start, Point finish)
        {

        }
    }
}
