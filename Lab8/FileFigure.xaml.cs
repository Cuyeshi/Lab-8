using LibraryForFigures.Parsing;
using LibraryForFigures;
using System.Windows;
using System.IO;
using System.Windows.Documents;
using Microsoft.Win32;


namespace Lab8
{
    /// <summary>
    /// Логика взаимодействия для FileFigure.xaml
    /// </summary>
    public partial class FileFigure : Window
    { 
        private FigureCollection Figures;
        public FileFigure()
        {
            InitializeComponent();
            Figures = [];
        }

        public FileFigure(FigureCollection figures) : this()
        {
            Figures = figures;
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            string[] dataFigures;
            OpenFileDialog ofd = new()
            {
                Filter = "All files (*.*)|*.*"
            };

            if (ofd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(docBox.Document.ContentStart, docBox.Document.ContentEnd);
                using (FileStream fs = new(ofd.FileName, FileMode.Open))
                {
                    if (Path.GetExtension(ofd.FileName).ToLower() == ".txt")
                    {
                        doc.Load(fs, DataFormats.Text);
                    }
                }

                dataFigures = doc.Text.Split('\n');
                foreach (string line in dataFigures)
                {
                    string[] parts = line.Split(' ');
                    if (parts.Length == 5 && parts[0] == "окружность")
                    {
                        Figures.Add(Parser.ParseToCircle(line));
                    }
                    else if(parts.Length == 5 && parts[0] == "многоугольник")
                    {
                        Figures.Add(Parser.ParseToTriangle(line));
                    }
                    else if (parts.Length == 6 && parts[0] == "многоугольник")
                    {
                        Figures.Add(Parser.ParseToSquare(line));
                    }
                }
            }
        }
    }
}
