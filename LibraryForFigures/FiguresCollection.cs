using LibraryForFigures.Types;
using System.Collections;
    
namespace LibraryForFigures
{
    public class FigureCollection : IFiguresCollection
    {
        private readonly List<GeometricFigure> figures = new List<GeometricFigure>();

        public IEnumerable<GeometricFigure> Figures => figures;

        public GeometricFigure this[int i]
        {
            get
            {
                if (i < 0 || i >= figures.Count) throw new IndexOutOfRangeException();
                return figures[i];
            }
            set => figures[i] = value;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (GeometricFigure figure in figures)
            {
                yield return figure;
            }
        }

        public FigureCollection()
        {
            figures = [];
        }

        public FigureCollection(params GeometricFigure[] figures1)
        {
            figures = figures1.ToList();
        }

        public double Area => figures.Sum(figure => figure.Area());

        public string Info()
        {
            string output = "Информация о всех геометрических фигурах: \n";
            foreach (GeometricFigure figure in figures)
            {
                output += figure.Info();
            }
            return output;
        }

        public void Add(GeometricFigure figure) => figures.Add(figure);

        public bool Remove(GeometricFigure figure)
        {
            foreach (GeometricFigure gfigure in figures)
            {
                if(figure.Info() == figure.Info())
                {
                    figures.Remove(gfigure);
                    return true;
                }
            }
            return false;
        }

        public void AddRange(GeometricFigure[] gfigures) => figures.AddRange(gfigures);

        public Polygon[] Polygons => figures.OfType<Polygon>().ToArray();
        public Polygon[] SortByArea()
        {
            Array.Sort(Polygons);
            return Polygons;
        }

        public List<double> AllCircumferenceMoreOneChapter() => (from circ in figures.OfType<Circle>()
                                                                 where circ.Center.Chapter == 1 && circ.Center.X > circ.Radius && circ.Center.Y > circ.Radius && circ.Colour == Parametrs.Clr.Зеленый
                                                                 select circ.Circumference).ToList();
    }
}
