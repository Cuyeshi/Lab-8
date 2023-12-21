using LibraryForFigures.Types;
using System.Text.RegularExpressions;
using LibraryForFigures.Parametrs;

namespace LibraryForFigures.Parsing
{
    internal class Parser
    {
        public static Circle ParseToCircle(string input)
        {
            Match matchColor = Regex.Match(input, @"\b[a-zA-Z]+\b");
            string color = matchColor.Value.ToString();

            MatchCollection matches = Regex.Matches(input, @"[-]?\d+(\,\d+)?");
            List<double> doubles = (from Match match in matches
                                    select double.Parse(match.Value.ToString())).ToList();

            Point center = new(doubles[0], doubles[1]);

            return Circle.SetCircle(center, doubles[2], color);
        }

        public static Triangle ParseToTriangle(string input) 
        {
            Match matchColor = Regex.Match(input, @"\b[a-zA-Z]+\b");
            string color = matchColor.Value.ToString();

            MatchCollection matches = Regex.Matches(input, @"[-]?\d+(\,\d+)?");
            List<double> doubles = (from Match match in matches
                                    select double.Parse(match.Value.ToString())).ToList();

            double[] side = new double[3] { doubles[0], doubles[1], doubles[2] };

            return Triangle.SetTriangle(side, color);
        }

        public static Square ParseToSquare(string input)
        {
            Match matchColor = Regex.Match(input, @"\b[a-zA-Z]+\b");
            string color = matchColor.Value.ToString();

            MatchCollection matches = Regex.Matches(input, @"[-]?\d+(\,\d+)?");
            List<double> doubles = (from Match match in matches
                                    select double.Parse(match.Value.ToString())).ToList();

            double[] side = new double[4] { doubles[0], doubles[1], doubles[2], doubles[3] };

            return Square.SetSquare(side, color);
        }
    }
}
