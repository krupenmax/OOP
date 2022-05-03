using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Rectangle : IFigure
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
            width = Convert.ToInt16(pen.Width);
            color = pen.Color;
            g.DrawLine(pen, start.X, start.Y, finish.X, start.Y);
            g.DrawLine(pen, start.X, start.Y, start.X, finish.Y);
            g.DrawLine(pen, start.X, finish.Y, finish.X, finish.Y);
            g.DrawLine(pen, finish.X, finish.Y, finish.X, start.Y);

        }

        public void Undo(Graphics g, Pen pen)
        {
            pen.Width = width;
            g.DrawLine(pen, start.X, start.Y, finish.X, start.Y);
            g.DrawLine(pen, start.X, start.Y, start.X, finish.Y);
            g.DrawLine(pen, start.X, finish.Y, finish.X, finish.Y);
            g.DrawLine(pen, finish.X, finish.Y, finish.X, start.Y);

            SolidBrush brush = new SolidBrush(Color.White);

            if (start.X < finish.X && start.Y < finish.Y)
            {
                g.FillRectangle(brush, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);
            }

            if (start.X > finish.X && start.Y < finish.Y)
            {
                g.FillRectangle(brush, finish.X, start.Y, start.X - finish.X, finish.Y - start.Y);
            }

            if (start.X > finish.X && start.Y > finish.Y)
            {
                g.FillRectangle(brush, finish.X, finish.Y, start.X - finish.X, start.Y - finish.Y);
            }

            if (start.X < finish.X && start.Y > finish.Y)
            {
                g.FillRectangle(brush, start.X, finish.Y, finish.X - start.X, start.Y - finish.Y);
            }
        }

        public void reDraw(Graphics g)
        {
            Pen pen = new Pen(color, width);
            g.DrawLine(pen, start.X, start.Y, finish.X, start.Y);
            g.DrawLine(pen, start.X, start.Y, start.X, finish.Y);
            g.DrawLine(pen, start.X, finish.Y, finish.X, finish.Y);
            g.DrawLine(pen, finish.X, finish.Y, finish.X, start.Y);
            SolidBrush brush = new SolidBrush(fillColor);

            if (start.X < finish.X && start.Y < finish.Y)
            {
                g.FillRectangle(brush, start.X + pen.Width / 2, start.Y + pen.Width / 2, finish.X - start.X - pen.Width, finish.Y - start.Y - pen.Width);
            }

            if (start.X > finish.X && start.Y < finish.Y)
            {
                g.FillRectangle(brush, finish.X + pen.Width / 2, start.Y + pen.Width / 2, start.X - finish.X - pen.Width, finish.Y - start.Y - pen.Width);
            }

            if (start.X > finish.X && start.Y > finish.Y)
            {
                g.FillRectangle(brush, finish.X + pen.Width / 2, finish.Y + pen.Width / 2, start.X - finish.X - pen.Width, start.Y - finish.Y - pen.Width);
            }

            if (start.X < finish.X && start.Y > finish.Y)
            {
                g.FillRectangle(brush, start.X + pen.Width / 2, finish.Y + pen.Width / 2, finish.X - start.X - pen.Width, start.Y - finish.Y - pen.Width);
            }
        }

        public void Fill(Graphics g, Pen pen, Point start, Point finish)
        {
            fillColor = pen.Color;
            SolidBrush brush = new SolidBrush(pen.Color);

            if (start.X < finish.X && start.Y < finish.Y)
            {
                g.FillRectangle(brush, start.X + pen.Width / 2, start.Y + pen.Width / 2, finish.X - start.X -  pen.Width, finish.Y - start.Y - pen.Width);
            }

            if (start.X > finish.X && start.Y < finish.Y)
            {
                g.FillRectangle(brush, finish.X + pen.Width / 2, start.Y + pen.Width / 2, start.X - finish.X - pen.Width, finish.Y - start.Y - pen.Width);
            }

            if (start.X > finish.X && start.Y > finish.Y)
            {
                g.FillRectangle(brush, finish.X + pen.Width / 2, finish.Y + pen.Width / 2, start.X - finish.X - pen.Width, start.Y - finish.Y - pen.Width);
            }

            if (start.X < finish.X && start.Y > finish.Y)
            {
                g.FillRectangle(brush, start.X + pen.Width / 2, finish.Y + pen.Width / 2, finish.X - start.X - pen.Width, start.Y - finish.Y - pen.Width);
            }

        }
    }
}
