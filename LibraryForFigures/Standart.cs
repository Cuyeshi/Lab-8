using LibraryForFigures.Parametrs;
using LibraryForFigures.Types;

namespace LibraryForFigures
{
    public class Standart
    {
        public static FigureCollection Value1
        {
            get
            {
                FigureCollection figures = [];

                Square[] squares =
                [
                    new Square(new double[] { 2, 2, 2, 2 }, Clr.Черный),

                    new Square(),

                    new Square(new double[] { 3, 3, 3, 3 }, Clr.Розовый),
                ];
                figures.AddRange( squares );

                Circle[] circles =
                [
                    new Circle(),

                    new Circle(new Point(2, 3), 1, Clr.Зеленый),
                ];
                figures.AddRange( circles );

                Triangle[] triangles =
                [
                    new Triangle(),

                    new Triangle(new double[] {3,3,3}, Clr.Желтый)
                ];
                figures.AddRange( triangles );

                return figures;
            }
        }

        public static FigureCollection SortedValue1
        {
            get
            {
                return
                [
                    new Triangle(),

                    new Square(),

                    new Triangle(new double[] { 3, 3, 3 }, Clr.Желтый),

                    new Square(new double[] { 2, 2, 2, 2 }, Clr.Черный),

                    new Square(new double[] { 3, 3, 3, 3 }, Clr.Розовый)
                ];
            }
        }
    }
}
