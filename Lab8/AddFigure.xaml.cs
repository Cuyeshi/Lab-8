using LibraryForFigures.Parsing;
using LibraryForFigures;
using System.Windows;
using System.Windows.Controls;

namespace Lab8
{
    /// <summary>
    /// Логика взаимодействия для AddFigure.xaml
    /// </summary>
    public partial class AddFigure : Window
    {
        private FigureCollection Figures;
        public AddFigure()
        {
            InitializeComponent();
            Figures = [];
        }

        public AddFigure(FigureCollection figures) : this()
        {
            Figures = figures;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox1.Text != string.Empty && textBox1.Text != string.Empty)
            {
                try
                {
                    if (comboBox1.Text == "Квадрат")
                    {
                        Figures.Add(Parser.ParseToSquare(textBox1.Text));
                    }
                    else
                    {
                        if(comboBox1.Text == "Треугольник")
                        {
                            Figures.Add(Parser.ParseToTriangle(textBox1.Text));
                        }
                        else
                        {
                            Figures.Add(Parser.ParseToCircle(textBox1.Text));
                        }
                    }
                    MessageBox.Show("Фигура успешно добавлена");

                }
                catch (Exception)
                {
                    MessageBox.Show("Данные введены неверно \nПример для Окружности: 1 2 3 White\nПример для Квадрата: 1 1 1 1 Blue" +
                        "\nПример для треугольника: 1 2 2 Black.");
                }

            }
            Close();
            new Window1(Figures).Show();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e) 
        {
            Close();
            new Window1(Figures).Show();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
