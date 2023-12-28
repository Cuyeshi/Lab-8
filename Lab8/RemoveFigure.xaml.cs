using LibraryForFigures.Parsing;
using LibraryForFigures;
using System.Windows;
using System.Windows.Controls;

namespace Lab8
{
    /// <summary>
    /// Логика взаимодействия для RemoveFigure.xaml
    /// </summary>
    public partial class RemoveFigure : Window
    {
        private readonly FigureCollection Figures;
        public RemoveFigure()
        {
            InitializeComponent();
            Figures = [];
        }

        public RemoveFigure(FigureCollection figures) : this()
        {
            Figures = figures;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool containsFigure;
            if (comboBox1.Text != string.Empty && textBox1.Text != string.Empty)
            {
                try
                {
                    if (comboBox1.Text == "Квадрат")
                    {
                        containsFigure = Figures.Remove(Parser.ParseToSquare(textBox1.Text));
                    }
                    else
                    {
                        if(comboBox1.Text == "Окружность")
                        {
                            containsFigure = Figures.Remove(Parser.ParseToCircle(textBox1.Text));
                        }
                        else
                        {
                            containsFigure = Figures.Remove(Parser.ParseToTriangle(textBox1.Text));
                        }
                    }
                    if (containsFigure)
                    {
                        MessageBox.Show("Фигура успешно удалена");
                    }
                    else
                    {
                        MessageBox.Show("Такой фигуры не существует");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Данные введены неверно \nПример для Окружности: 1 2 3 White\nПример для Квадрата: 1 1 1 1 blue");
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

