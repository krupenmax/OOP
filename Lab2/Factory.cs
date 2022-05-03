using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Factory : IFactory
    {
        System.Windows.Forms.ComboBox comboBox;

        public Factory(System.Windows.Forms.ComboBox comboBox)
        {
            this.comboBox = comboBox;
        }
        public IFigure create(string figureName)
        {
            switch (figureName)
            {
                case "Линия":
                    return new Line( );
                case "Прямоугольник":
                    return new Rectangle();
                case "Эллипс":
                    return new Ellipse();
                case "Ломанная":
                    return new BrokenLine();
                case "Многоугольник":
                    return new Polygon(Convert.ToInt16(comboBox.SelectedItem));
                default:
                    return null;
            }
        }
    }

    interface IFactory
    {
        IFigure create(string figureName);
    }
}
