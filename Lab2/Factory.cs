using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Factory : IFactory
    {
        public IFigure create(string figureName, System.Windows.Forms.PictureBox pictureBox1)
        {
            switch (figureName)
            {
                case "Линия":
                    return new Line(pictureBox1);
                case "Прямоугольник":
                    return new Rectangle();
                case "Эллипс":
                    return new Ellipse();
                case "Ломанная":
                    return new BrokenLine();
                case "Многоугольник":
                    return new Polygon();
                default:
                    return null;
            }
        }
    }
    interface IFactory
    {
        IFigure create(string figureName, System.Windows.Forms.PictureBox pictureBox1);
    }
}
