using LibraryForFigures.Parametrs;

namespace LibraryForFigures.Types
{
    internal class Circle : Figures
    {
        private readonly Point _center;

        private readonly Clr _color;

        private readonly string _type;

        private readonly double _radius;

        public Circle()
        {
            _center = new Point();
            _radius = 1;
            _color = Clr.Черный;
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

        public double Circumference
        {  get 
            { 
                return 2 * Math.PI * Radius; 
            } 
        }

        public Clr Colour { get { return _color; } }

        public static Circle SetCircle(Point center, double radius, string color)
        {
            return color switch
            {
                "Белый" => new Circle(center, radius, Clr.Белый),
                "White" => new Circle(center, radius, Clr.Белый),
                "Черный" => new Circle(center, radius, Clr.Черный),
                "Black" => new Circle(center, radius, Clr.Черный),
                "Желтый" => new Circle(center, radius, Clr.Желтый),
                "Yellow" => new Circle(center, radius, Clr.Желтый),
                "Красный" => new Circle(center, radius, Clr.Красный),
                "Red" => new Circle(center, radius, Clr.Красный),
                "Зеленый" => new Circle(center, radius, Clr.Зеленый),
                "Green" => new Circle(center, radius, Clr.Зеленый),
                "Синий" => new Circle(center, radius, Clr.Синий),
                "Blue" => new Circle(center, radius, Clr.Синий),
                "Фиолетовый" => new Circle(center, radius, Clr.Фиолетовый),
                "Purple" => new Circle(center, radius, Clr.Фиолетовый),
                "Оранжевый" => new Circle(center, radius, Clr.Оранжевый),
                "Orange" => new Circle(center, radius, Clr.Оранжевый),
                "Розовый" => new Circle(center, radius, Clr.Розовый),
                "Pink" => new Circle(center, radius, Clr.Розовый),
                _ => new Circle(),
            };
        }

        public override string Info()
        {
            return $"Информация о {_type}: \n" +
                   $"\tКоординаты центра: ({_center.X};{_center.Y}); \n" +
                   $"\tРадиус равен {Math.Round(Radius, 3)}; \n" +
                   $"\tЦвет: {_color}; \n" +
                   $"\tПлощадь равна {Math.Round(Area(), 3)}; \n" +
                   $"\tДлина равна {Math.Round(Circumference, 3)}. \n";
        }
    }
}
