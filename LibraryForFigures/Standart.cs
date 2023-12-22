using LibraryForFigures.Types;

namespace LibraryForFigures
{
    public class Standart
    {
        public static FigureCollection Value1
        {
            get
            {
                return
                [
                    new Square(new double[] { 2, 2, 2, 2 }, Parametrs.Clr.Черный),

                    new Square(),

                    new Square(new double[] { 3, 3, 3, 3 }, Parametrs.Clr.Желтый),

                    new Circle(),

                    new Circle(new Parametrs.Point(2,3), 1, Parametrs.Clr.Зеленый),

                    new Triangle(),

                    new Triangle(new double[] {3,3,3}, Parametrs.Clr.Розовый)
                ];
            }
        }
    }
}
