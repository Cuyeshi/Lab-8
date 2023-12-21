using LibraryForFigures.Parametrs;
using System.Reflection.Metadata;

namespace LibraryForFigures
{
    internal class Polygon : Figures, IComparable<Polygon>
    {
        private readonly double[] _side;

        private readonly Clr _color;

        private readonly string _type;

        public Polygon()
        {
            _color = Clr.Черный;
            _side = new double[3] {1,1,1};
            _type = "треугольник";
        }

        public Polygon(double[] side, Clr color) 
        {
            _color = color;
            _side = side;
            if (NotExist) throw new Exception("Такого многоугольника не существует!");
            _type = "треугольник";
        }

        public override double Area() => _side[0] * _side[1] * Math.Sqrt(3) / 4;

        public bool Exist()
        {
            if (Side.Length > 2)
            {
                int count = 0;
                for (int i = 0; i < Side.Length-1; i++) 
                {
                    if (Side[i] == Side[i+1])
                    {
                        count++;
                    }
                }
                if (count == Side.Length - 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else 
            { 
                return false; 
            }
        }

        public bool NotExist => !Exist();

        public double[] Side => _side;

        public Clr Color => _color;

        public static Polygon SetPolygon(double[] side, string color)
        {
            return color switch
            {
                "Белый" => new Polygon(side, Clr.Белый),
                "White" => new Polygon(side, Clr.Белый),
                "Черный" => new Polygon(side, Clr.Черный),
                "Black" => new Polygon(side, Clr.Черный),
                "Желтый" => new Polygon(side, Clr.Желтый),
                "Yellow" => new Polygon(side, Clr.Желтый),
                "Красный" => new Polygon(side   , Clr.Красный),
                "Red" => new Polygon(side, Clr.Красный),
                "Зеленый" => new Polygon(side, Clr.Зеленый),
                "Green" => new Polygon(side, Clr.Зеленый),
                "Синий" => new Polygon(side, Clr.Синий),
                "Blue" => new Polygon(side, Clr.Синий),
                "Фиолетовый" => new Polygon(side, Clr.Фиолетовый),
                "Purple" => new Polygon(side, Clr.Фиолетовый),
                "Оранжевый" => new Polygon(side, Clr.Оранжевый),
                "Orange" => new Polygon(side, Clr.Оранжевый),
                "Розовый" => new Polygon(side, Clr.Розовый),
                "Pink" => new Polygon(side, Clr.Розовый),
                _ => new Polygon(),
            };
        }

        public override string Info()
        {
            string output = $"Информация о {_type}: \n" + "\tЗначение сторон: ";
            for (int i = 0; i < Side.Length; i++)
            {
                output += $"{_side[i]} ";
            }
            output += $"\n\tПлощадь квадрата равна {Math.Round(Area(), 3)}; \n";
            return output;
        }

        public int CompareTo(Polygon polygon)
        {
            if (polygon is null) throw new ArgumentNullException("Некорректное значение параметра");
            return Area().CompareTo(polygon.Area());
        }
    }
}
