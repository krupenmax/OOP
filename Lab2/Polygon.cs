using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Polygon : IFigure
    {
        int n;//количество сторон
        int R;//расстояние от центра до стороны
        Point Cntr;//центр
        Point[] p; //массив точек будущего многоугольника
        //создаём массив точек нашего многоугольника

        public Polygon(int n)
        {
            this.n = n;
        }
         
        private void lineAngle(double angle)
        {
            double z = 0; int i = 0;
            while (i < n + 1)
            {

                p[i].X = Cntr.X + (int)(Math.Round(Math.Cos(z / 180 * Math.PI) * R));
                p[i].Y = Cntr.Y - (int)(Math.Round(Math.Sin(z / 180 * Math.PI) * R));
                z = z + angle;
                i++;
            }
        }

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

            R = (finish.X - start.X) / 2;
            Cntr.X = start.X + R;
            Cntr.Y = start.Y + R;
            p = new Point[n + 1];
            lineAngle((double)(360.0 / (double)n));
            int i = n;
            SolidBrush brush = new SolidBrush(pen.Color);
            while (i > 0)
            {
                g.DrawLine(pen, p[i], p[i - 1]);
                i--;
            }
        }

        public void Undo(Graphics g, Pen pen)
        {
            pen.Width = width;
            R = (finish.X - start.X) / 2;
            Cntr.X = start.X + R;
            Cntr.Y = start.Y + R;
            p = new Point[n + 1];
            lineAngle((double)(360.0 / (double)n));
            int i = n;
            while (i > 0)
            {
                g.DrawLine(pen, p[i], p[i - 1]);
                i = i - 1;
            }
        }

        public void reDraw(Graphics g)
        {
            Pen pen = new Pen(color, width);
            R = (finish.X - start.X) / 2;
            Cntr.X = start.X + R;
            Cntr.Y = start.Y + R;
            p = new Point[n + 1];
            lineAngle((double)(360.0 / (double)n));
            int i = n;
            while (i > 0)
            {
                g.DrawLine(pen, p[i], p[i - 1]);
                i = i - 1;
            }
        }

        public void Fill(Graphics g, Pen pen, Point start, Point finish)
        {
        }
    }
}
