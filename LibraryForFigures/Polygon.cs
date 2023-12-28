using LibraryForFigures.Parametrs;


namespace LibraryForFigures
{
    public class Polygon : Figures, IComparable<Polygon>
    {
        private double[] _side;

        private Clr _color;

        private string _type;

        public Polygon()
        {
            _color = Clr.Black;
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
                "White" => new Polygon(side, Clr.White),
                "Black" => new Polygon(side, Clr.Black),
                //"Yellow" => new Polygon(side, Clr.Желтый),
                "Red" => new Polygon(side, Clr.Red),
                "Green" => new Polygon(side, Clr.Green),
                "Blue" => new Polygon(side, Clr.Blue),
                "Purple" => new Polygon(side, Clr.Purple),
                "Orange" => new Polygon(side, Clr.Orange),
                "Pink" => new Polygon(side, Clr.Pink),
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
            output += $"\n\tЦвет: {_color};\n";
            output += $"\tПлощадь равна {Math.Round(Area(), 3)}; \n";
            return output;
        }

        public int CompareTo(Polygon? polygon)
        {
            if (polygon is null) throw new ArgumentException("Некорректное значение параметра");
            return Area().CompareTo(polygon.Area());
        }
    }
}
