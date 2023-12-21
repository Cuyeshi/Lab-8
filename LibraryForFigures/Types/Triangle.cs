using LibraryForFigures.Parametrs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                "Белый" => new Triangle(side, Clr.Белый),
                "White" => new Triangle(side, Clr.Белый),
                "Черный" => new Triangle(side, Clr.Черный),
                "Black" => new Triangle(side, Clr.Черный),
                "Желтый" => new Triangle(side, Clr.Желтый),
                "Yellow" => new Triangle(side, Clr.Желтый),
                "Красный" => new Triangle(side, Clr.Красный),
                "Red" => new Triangle(side, Clr.Красный),
                "Зеленый" => new Triangle(side, Clr.Зеленый),
                "Green" => new Triangle(side, Clr.Зеленый),
                "Синий" => new Triangle(side, Clr.Синий),
                "Blue" => new Triangle(side, Clr.Синий),
                "Фиолетовый" => new Triangle(side, Clr.Фиолетовый),
                "Purple" => new Triangle(side, Clr.Фиолетовый),
                "Оранжевый" => new Triangle(side, Clr.Оранжевый),
                "Orange" => new Triangle(side, Clr.Оранжевый),
                "Розовый" => new Triangle(side, Clr.Розовый),
                "Pink" => new Triangle(side, Clr.Розовый),
                _ => new Triangle(),
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
