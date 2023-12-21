using LibraryForFigures.Parametrs;

namespace LibraryForFigures
{
    public abstract class Figures
    {
        private  readonly string _type;

        private  readonly Clr _colour;
        public string Type => _type;

        public Clr Colour => _colour;

        public abstract double Area();

        public abstract string Info();
    }
}