using LibraryForFigures;
using System.Windows;

namespace Lab8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool firstIn = true;
        private readonly FigureCollection Figures;
        public MainWindow()
        {
            InitializeComponent();
            Figures = Standart.Value1;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (firstIn)
            {
                MessageBox.Show("В качестве начальных значений были выставлены заранее подготовленные данные. При следующих запусках этого сообщения не будет.");
                firstIn = false;
                new Window1(Figures).Show();
            }
            else
                new Window1(Figures).Show();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            new AddFigure(Figures).Show();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            new RemoveFigure(Figures).Show();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            new FileFigure(Figures).Show();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Polygon[] figures = Figures.SortByArea();
            foreach(Polygon p in figures)
            {
                Figures.Remove(p);
            }
            Figures.AddRange(figures);
            MessageBox.Show("Многоугольники успешно отсортированны!");

            void okButton_Click(object sender, RoutedEventArgs e) =>
                DialogResult = true;
            new Window1(Figures).Show();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        { 
            string result = "Длины окружностей:\n";
            foreach(double circumference in Figures.AllCircumferenceMoreOneChapter())
            {
                result += Math.Round(circumference, 3) + ", ";
            }
            MessageBox.Show(result);
        }
    }
}
