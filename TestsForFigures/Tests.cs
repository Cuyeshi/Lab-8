using LibraryForFigures;
using LibraryForFigures.Types;
using LibraryForFigures.Parametrs;

namespace TestsForFigures
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void SortByArea_Test1()
        {
            FigureCollection actual = [];
            actual.SortByArea();

            FigureCollection expected = [];

            Assert.AreEqual(expected.Info(), actual.Info());
        }

        [TestMethod]
        public void SortByArea_Test2()
        {
            FigureCollection actual = [new Circle()];
            actual.SortByArea();

            FigureCollection expected = [new Circle()];

            Assert.AreEqual(expected.Info(), actual.Info());
        }

        [TestMethod]
        public void SortByArea_Test3()
        {
            FigureCollection actual = Standart.Value1;
            Polygon[] polygons = actual.SortByArea();
            FigureCollection result = new FigureCollection(polygons);

            FigureCollection expected = Standart.SortedValue1;

            Assert.AreEqual(expected.Info(), result.Info());
        }

        [TestMethod]
        public void SortByArea_Test4()
        {
            FigureCollection actual = [new Circle(), new Square(), new Triangle()];
            Polygon[] polygons = actual.SortByArea();
            FigureCollection result = new FigureCollection(polygons);

            FigureCollection expected = [new Triangle(), new Square()];

            Assert.AreEqual(expected.Info(), result.Info());
        }

        [TestMethod]
        public void AllCircumferenceMoreOneChapter_Test1()
        {
            List<double> actual = new FigureCollection(new Circle()).AllCircumferenceMoreOneChapter();

            List<double> expected = [];

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllCircumferenceMoreOneChapter_Test2()
        {
            List<double> actual = new FigureCollection().AllCircumferenceMoreOneChapter();

            List<double> expected = [];

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllCircumferenceMoreOneChapter_Test3()
        {
            List<double> actual = new FigureCollection(new Circle(new Point(2,2), 1, Clr.Orange)).AllCircumferenceMoreOneChapter();

            List<double> expected = [];

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllCircumferenceMoreOneChapter_Test4()
        {
            List<double> actual = Standart.Value1.AllCircumferenceMoreOneChapter();

            List<double> expected = [2 * Math.PI];

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}