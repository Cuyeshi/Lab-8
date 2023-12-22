using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForFigures
{
    public class AreaComparable : IComparable<Figures>
    {
        public int CompareTo(Figures? figure)
        {
            if (figure is null) throw new ArgumentException("Некорректное значение параметра");
            return figure.Area().CompareTo(figure.Area());
        }
    }
}
