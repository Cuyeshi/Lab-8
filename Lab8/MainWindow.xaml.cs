using LibraryForFigures;
using System.Windows;

namespace Lab8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly FigureCollection Figures;
        public MainWindow()
        {
            InitializeComponent();
            Figures = Standart.Value1;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
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
            Figures.SortByArea();
            MessageBox.Show("Все многоугольнткт успешно отсортировались по площади (по возрастанию).");
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
