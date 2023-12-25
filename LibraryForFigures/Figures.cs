using LibraryForFigures.Parametrs;

namespace LibraryForFigures
{
    public abstract class Figures
    {
        private readonly string _type;

        private readonly Clr _color;
        public string Type => _type;

        public Clr Color => _color;

        public abstract double Area();

        public abstract string Info();
    }
}