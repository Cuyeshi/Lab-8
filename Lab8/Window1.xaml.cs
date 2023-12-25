using LibraryForFigures.Parametrs;
using LibraryForFigures.Types;
using LibraryForFigures;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab8
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private readonly FigureCollection Figures;
        public Window1()
        {
            InitializeComponent();
            Figures = [];
        }

        public Window1(FigureCollection figures) : this()
        {
            Figures = figures;
            int[] rows = [1, 1];

            AddHeadLabels();
            foreach (Figures figure in figures)
            {
                AddLabel(figure, ref rows);
            }
        }

        private void AddHeadLabels()
        {
            Label[] labels =
            [
                AddLabel("Многоугольники"),
                AddLabel("Окружности"),
            ];

            for (int i = 0; i < 2; i++)
            {
                grid1.Children.Add(labels[i]);
                Grid.SetColumn(labels[i], i);
                Grid.SetRow(labels[i], 0);
            }
        }

        private Label AddLabel(string content)
        {
            return new Label
            {
                Content = content,
                FontSize = 16,
                FontWeight = FontWeights.Bold,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Bottom,
                Margin = new Thickness(2, 2, 2, 2),
            };
        }

        private void AddLabel(Figures figure, ref int[] rows)
        {
            var label = new Label
            {
                Background = Brushes.LightSeaGreen,
                Margin = new Thickness(2, 2, 2, 2),
                Padding = new Thickness(10, 5, 0, 0),
                Content = figure.Info(),
            };

            if (figure is Circle circle)
            {
                label.Foreground = circle.Color switch
                {
                    Clr.Белый => Brushes.White,
                    Clr.Черный => Brushes.Black,
                    Clr.Фиолетовый => Brushes.Purple,
                    Clr.Синий => Brushes.Blue,
                    Clr.Розовый => Brushes.Pink,
                    Clr.Оранжевый => Brushes.Orange,
                    Clr.Красный => Brushes.Red,
                    Clr.Зеленый => Brushes.Green,
                    Clr.Желтый => Brushes.Yellow,
                    _ => Brushes.Black,
                };
                Grid.SetColumn(label, 1);
                Grid.SetRow(label, rows[1]);
                rows[1]++;
            }
            else
            {
                if (figure is Square square)
                {
                    label.Foreground = square.Color switch
                    {
                        Clr.Белый => Brushes.White,
                        Clr.Черный => Brushes.Black,
                        Clr.Фиолетовый => Brushes.Purple,
                        Clr.Синий => Brushes.Blue,
                        Clr.Розовый => Brushes.Pink,
                        Clr.Оранжевый => Brushes.Orange,
                        Clr.Красный => Brushes.Red,
                        Clr.Зеленый => Brushes.Green,
                        Clr.Желтый => Brushes.Yellow,
                        _ => Brushes.Black,
                    };
                    Grid.SetColumn(label, 0);
                    Grid.SetRow(label, rows[0]);
                    rows[0]++;
                }
                else
                {
                    if (figure is Triangle triangle)
                    {
                        label.Foreground = triangle.Color switch
                        {
                            Clr.Белый => Brushes.White,
                            Clr.Черный => Brushes.Black,
                            Clr.Фиолетовый => Brushes.Purple,
                            Clr.Синий => Brushes.Blue,
                            Clr.Розовый => Brushes.Pink,
                            Clr.Оранжевый => Brushes.Orange,
                            Clr.Красный => Brushes.Red,
                            Clr.Зеленый => Brushes.Green,
                            Clr.Желтый => Brushes.Yellow,
                            _ => Brushes.Black,
                        };
                        Grid.SetColumn(label, 0);
                        Grid.SetRow(label, rows[0]);
                        rows[0]++;
                    }
                }
            }    
            grid1.Children.Add(label);
        }
    }
}
