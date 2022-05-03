using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Ellipse : IFigure
    {
        Point start;
        Point finish;
        int width;
        Color color;
        Color fillColor;

        public void Draw(Graphics g, Pen pen, Point start, Point finish)
        {
            this.start = start;
            this.finish = finish;
            color = pen.Color;
            width = Convert.ToInt16(pen.Width);
            g.DrawEllipse(pen, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
            SolidBrush brush = new SolidBrush(pen.Color);
            g.FillEllipse(brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
        }

        public void Undo(Graphics g, Pen pen)
        {
            pen.Width = width;
            g.DrawEllipse(pen, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
            SolidBrush brush = new SolidBrush(Color.White);
            g.FillEllipse(brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
        }

        public void reDraw(Graphics g)
        {
            Pen pen = new Pen(color, width);
            g.DrawEllipse(pen, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
            SolidBrush brush = new SolidBrush(fillColor);
            if (start.X < finish.X && start.Y < finish.Y)
            {
                g.FillEllipse(brush, start.X + pen.Width / 2, start.Y + pen.Width / 2, finish.X - start.X - pen.Width, finish.Y - start.Y - pen.Width);
            }

            if (start.X > finish.X && start.Y < finish.Y)
            {
                g.FillEllipse(brush, finish.X + pen.Width / 2, start.Y + pen.Width / 2, start.X - finish.X - pen.Width, finish.Y - start.Y - pen.Width);
            }

            if (start.X > finish.X && start.Y > finish.Y)
            {
                g.FillEllipse(brush, finish.X + pen.Width / 2, finish.Y + pen.Width / 2, start.X - finish.X - pen.Width, start.Y - finish.Y - pen.Width);
            }

            if (start.X < finish.X && start.Y > finish.Y)
            {
                g.FillEllipse(brush, start.X + pen.Width / 2, finish.Y + pen.Width / 2, finish.X - start.X - pen.Width, start.Y - finish.Y - pen.Width);
            }
        }

        public void Fill(Graphics g, Pen pen, Point start, Point finish)
        {
            fillColor = pen.Color;
            SolidBrush brush = new SolidBrush(pen.Color);
            if (start.X < finish.X && start.Y < finish.Y)
            {
                g.FillEllipse(brush, start.X + pen.Width / 2, start.Y + pen.Width / 2, finish.X - start.X - pen.Width, finish.Y - start.Y - pen.Width);
            }

            if (start.X > finish.X && start.Y < finish.Y)
            {
                g.FillEllipse(brush, finish.X + pen.Width / 2, start.Y + pen.Width / 2, start.X - finish.X - pen.Width, finish.Y - start.Y - pen.Width);
            }

            if (start.X > finish.X && start.Y > finish.Y)
            {
                g.FillEllipse(brush, finish.X + pen.Width / 2, finish.Y + pen.Width / 2, start.X - finish.X - pen.Width, start.Y - finish.Y - pen.Width);
            }

            if (start.X < finish.X && start.Y > finish.Y)
            {
                g.FillEllipse(brush, start.X + pen.Width / 2, finish.Y + pen.Width / 2, finish.X - start.X - pen.Width, start.Y - finish.Y - pen.Width);
            }
        }

    }
}
