using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    public interface IFigure
    {
        void Draw(Graphics g, Pen pen, Point start, Point finish);
        void Undo(Graphics g, Pen pen);
        void reDraw(Graphics g);
        void Fill(Graphics g, Pen pen, Point start, Point finish);
    }
}
