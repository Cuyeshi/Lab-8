using LibraryForFigures.Parametrs;

namespace LibraryForFigures.Types
{
    public class Square : Polygon
    {
        private readonly double[] _side;

        private readonly Clr _color;

        private readonly string _type;

        public Square()
        {
            _color = Clr.Black;
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
            switch (color)
            {

                case "White":
                    return new Square(side, Clr.White);
                
                case "Black":
                    return new Square(side, Clr.Black);
                
                //case "Yellow":
                    //return new Square(side, Clr.Желтый);
                
                case "Red":
                    return new Square(side, Clr.Red);
                
                case "Green":
                    return new Square(side, Clr.Green);
                
                case "Blue":
                    return new Square(side, Clr.Blue);
               
                case "Purple":
                    return new Square(side, Clr.Purple);
                
                case "Orange":
                    return new Square(side, Clr.Orange);
               
                case "Pink":
                    return new Square(side, Clr.Pink);
                
                default:
                    return new Square();
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
