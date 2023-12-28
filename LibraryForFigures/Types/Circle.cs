using LibraryForFigures.Parametrs;

namespace LibraryForFigures.Types
{
    public class Circle : Figures
    {
        private readonly Point _center;

        private readonly Clr _color;

        private readonly string _type;

        private readonly double _radius;

        public Circle()
        {
            _center = new Point();
            _radius = 1;
            _color = Clr.Black;
            _type = "окружность";
        }

        public Circle(Point center, double radius, Clr color) 
        {
            _radius = radius;
            if (NoExist) throw new Exception("Такой окружности не существует!");
            _center = center;
            _color = color;
            _type = "окружность";
        }

        public override double Area() 
            { 
                return Math.PI * Radius * Radius;
            }

        public bool Exist => _radius > 0;

        public bool NoExist => !Exist;

        public double Radius => _radius;

        public Point Center => _center;

        public double Circumference
        {  get 
            { 
                return 2 * Math.PI * Radius; 
            } 
        }

        public Clr Color => _color;

        public static Circle SetCircle(Point center, double radius, string color)
        {
            return color switch
            {
                "White" => new Circle(center, radius, Clr.White),
                "Black" => new Circle(center, radius, Clr.Black),
                //"Yellow" => new Circle(center, radius, Clr.Желтый),
                "Red" => new Circle(center, radius, Clr.Red),
                "Green" => new Circle(center, radius, Clr.Green),
                "Blue" => new Circle(center, radius, Clr.Blue),
                "Purple" => new Circle(center, radius, Clr.Purple),
                "Orange" => new Circle(center, radius, Clr.Orange),
                "Pink" => new Circle(center, radius, Clr.Pink),
                _ => new Circle(),
            };
        }

        public override string Info()
        {
            return $"{_type}: \n" +
                   $"\tКоординаты центра: ({_center.X};{_center.Y}); \n" +
                   $"\tРадиус равен {Math.Round(Radius, 3)}; \n" +
                   $"\tЦвет: {_color}; \n" +
                   $"\tПлощадь равна {Math.Round(Area(), 3)}; \n" +
                   $"\tДлина равна {Math.Round(Circumference, 3)}. \n";
        }
    }
}
