using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForFigures.Parametrs
{
    public class Point
    {
        private readonly double _x;

        private readonly double _y;

        public Point()
        {
            _x = 0;
            _y = 0;
        }

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double X { get { return _x; } }

        public double Y { get { return _y; } }

        public bool InFirst => X > 0 && Y > 0;

        public bool InSecond => X < 0 && Y > 0;

        public bool InThird => X < 0 && Y < 0;

        public bool InFourth => X > 0 && Y < 0;

        public int Chapter => InFirst ? 1 : InSecond ? 2 : InThird ? 3 : InFourth ? 4 : 0;

        public double Distance(Point p) => Math.Sqrt((X-p.X)*(X-p.X) + (Y-p.Y)*(Y-p.Y));
    }
}
