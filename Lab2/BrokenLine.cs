using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    public class BrokenLine : IFigure
    {
        int width;
        Color color;
        public List<Point> LineList = new List<Point>();

        public void Draw(Graphics g, Pen pen, Point start, Point finish)
        {
            color = pen.Color;
            width = Convert.ToInt16(pen.Width);

            for (int i = 0; i < LineList.Count - 1; i++)
            {
                g.DrawLine(pen, LineList[i], LineList[i + 1]);
            }
            
        }

        public void Undo(Graphics g, Pen pen)
        {
            pen.Width = width;
            for (int i = 0; i < LineList.Count - 1; i++)
            {
                g.DrawLine(pen, LineList[i], LineList[i + 1]);
            }
        }

        public void reDraw(Graphics g)
        {
            Pen pen = new Pen(color, width);
            for (int i = 0; i < LineList.Count - 1; i++)
            {
                g.DrawLine(pen, LineList[i], LineList[i + 1]);
            }
        }

        public void Fill(Graphics g, Pen pen, Point start, Point finish)
        {

        }
    }
}
