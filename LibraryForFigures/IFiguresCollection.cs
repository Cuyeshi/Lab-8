using System.Collections;

namespace LibraryForFigures
{
    /// <summary>
    /// Наследуется от IEnumerable, поскольку без него нельзя использовать перечисление.
    /// </summary>
    public interface IFiguresCollection : IEnumerable
    {
        public double Area { get; }

        public string Info();

        Figures this[int index] { get; set; }
    }
}
