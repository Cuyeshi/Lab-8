using LibraryForFigures.Parametrs;

namespace LibraryForFigures.Types
{
    internal class Square : Polygon
    {
        private readonly double[] _side;

        private readonly Clr _color;

        private readonly string _type;

        public Square()
        {
            _color = Clr.Черный;
            _side = new double[4] { 1, 1, 1, 1 };
            _type = "квадрат";
        }

        public Square(double[] side, Clr color)
        {
            _color = color;
            _side = side;
            if (NotExist) throw new Exception("Такого квадрата не существует!");
            _type = "квадрат";
        }

        public override double Area() => _side[0] * _side[1];

        public bool Exist()
        {
            if (Side.Length == 4)
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

        public static Square SetSquare(double[] side, string color)
        {
            return color switch
            {
                "Белый" => new Square(side, Clr.Белый),
                "White" => new Square(side, Clr.Белый),
                "Черный" => new Square(side, Clr.Черный),
                "Black" => new Square(side, Clr.Черный),
                "Желтый" => new Square(side, Clr.Желтый),
                "Yellow" => new Square(side, Clr.Желтый),
                "Красный" => new Square(side, Clr.Красный),
                "Red" => new Square(side, Clr.Красный),
                "Зеленый" => new Square(side, Clr.Зеленый),
                "Green" => new Square(side, Clr.Зеленый),
                "Синий" => new Square(side, Clr.Синий),
                "Blue" => new Square(side, Clr.Синий),
                "Фиолетовый" => new Square(side, Clr.Фиолетовый),
                "Purple" => new Square(side, Clr.Фиолетовый),
                "Оранжевый" => new Square(side, Clr.Оранжевый),
                "Orange" => new Square(side, Clr.Оранжевый),
                "Розовый" => new Square(side, Clr.Розовый),
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
