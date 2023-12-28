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
            _color = Clr.Black;
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
                "White" => new Triangle(side, Clr.White),
                "Black" => new Triangle(side, Clr.Black),
                //"Yellow" => new Triangle(side, Clr.Желтый),
                "Red" => new Triangle(side, Clr.Red),
                "Green" => new Triangle(side, Clr.Green),
                "Blue" => new Triangle(side, Clr.Blue),
                "Purple" => new Triangle(side, Clr.Purple),
                "Orange" => new Triangle(side, Clr.Orange),
                "Pink" => new Triangle(side, Clr.Pink),
                _ => new Triangle(),
            };
        }

        public override string Info()
        {
            string output = $"{_type}: \n" + "\tЗначение сторон: ";
            for (int i = 0; i < Side.Length; i++)
            {
                output += $"{_side[i]} ";
            }
            output += $"\n\tЦвет: {_color};\n";
            output += $"\tПлощадь равна {Math.Round(Area(), 3)}; \n";
            return output;
        }
    }
}
