using LibraryForFigures;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Figures Figures;
        public MainWindow()
        {
            InitializeComponent();
            Figures = Standart.Value1;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string result = "Площадь квадрата равна: \n";
            result += Figures.Area();
            MessageBox.Show(result);
        }
    }
}
