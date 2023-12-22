﻿using LibraryForFigures.Types;
using System.Collections;
    
namespace LibraryForFigures
{
    public class FigureCollection : IFiguresCollection
    {
        private readonly List<Figures> figures = new List<Figures>();

        public IEnumerable<Figures> Figures => figures;

        public Figures this[int i]
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
            foreach (Figures figure in figures)
            {
                yield return figure;
            }
        }

        public FigureCollection()
        {
            figures = [];
        }

        public FigureCollection(params Figures[] figures1)
        {
            figures = figures1.ToList();
        }

        public double Area => figures.Sum(figure => figure.Area());

        public string Info()
        {
            string output = "Информация о всех геометрических фигурах: \n";
            foreach (Figures figure in figures)
            {
                output += figure.Info();
            }
            return output;
        }

        public void Add(Figures figure) => figures.Add(figure);

        public bool Remove(Figures figure)
        {
            foreach (Figures gfigure in figures)
            {
                if(figure.Info() == figure.Info())
                {
                    figures.Remove(gfigure);
                    return true;
                }
            }
            return false;
        }

        public void AddRange(Figures[] gfigures) => figures.AddRange(gfigures);

        public void SortByArea()
        {
            foreach(Figures figure in figures)
            {
                figure.Area().CompareTo(figure.Area());
            }
        }

        public List<double> AllCircumferenceMoreOneChapter() => (from circ in figures.OfType<Circle>()
                                                                 where circ.Center.Chapter == 1 && circ.Center.X > circ.Radius && circ.Center.Y > circ.Radius
                                                                 select circ.Circumference).ToList();
    }
}
