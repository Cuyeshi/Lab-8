using LibraryForFigures.Parametrs;

namespace LibraryForFigures.Types
{
    public class Triangle : Polygon
    {
        private readonly double[] _side;

        private readonly Clr _color;

        private readonly string _type;

        public Triangle()
        {
            _color = Clr.Черный;
            _side = new double[3] { 1, 1, 1 };
            _type = "треугольник";
        }

        public Triangle(double[] side, Clr color)
        {
            _color = color;
            _side = side;
            if (NotExist) throw new Exception("Такого треугольника не существует!");
            _type = "треугольник";
        }

        public override double Area() => _side[0] * _side[1] * Math.Sqrt(3) / 4;

        public bool Exist()
        {
            if (Side.Length == 3)
            {
                int count = 0;
                for (int i = 0; i < Side.Length - 1; i++)
                {
                    if (Side[i] == Side[i + 1])
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

        public static Triangle SetTriangle(double[] side, string color)
        {
            return color switch
            {
                "White" => new Square(side, Clr.Белый),
                "Black" => new Square(side, Clr.Черный),
                "Yellow" => new Square(side, Clr.Желтый),
                "Red" => new Square(side, Clr.Красный),
                "Green" => new Square(side, Clr.Зеленый),
                "Blue" => new Square(side, Clr.Синий),
                "Purple" => new Square(side, Clr.Фиолетовый),
                "Orange" => new Square(side, Clr.Оранжевый),
                "Pink" => new Square(side, Clr.Розовый),
                _ => new Square(),
            };
        }

        public override string Info()
        {
            string output = $"Информация о {_type}: \n" + "\tЗначение сторон: ";
            for (int i = 0; i < Side.Length; i++)
            {
                output += $"{_side[i]} ";
            }
            output += $"\n\tПлощадь равна {Math.Round(Area(), 3)}; \n";
            return output;
        }
    }
}
