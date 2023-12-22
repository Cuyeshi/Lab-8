using System.Collections;

namespace LibraryForFigures
{
    public interface IFiguresCollection : IEnumerable 
    {
        public double Area { get; }

        public string Info();

        GeometricFigure this[int index] { get; set; }
    }
}
