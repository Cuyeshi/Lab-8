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

        private static Label AddLabel(string content)
        {
            return new Label
            {
                Content = content,
                FontSize = 16,
                BorderThickness = new Thickness(1),
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
                Background = Brushes.GhostWhite,
                Margin = new Thickness(2, 2, 2, 2),
                Padding = new Thickness(10, 5, 0, 0),
                Content = figure.Info(),
            };

            if (figure is Circle circle)
            {
                label.Foreground = circle.Color switch
                {
                    Clr.White => Brushes.White,
                    Clr.Black => Brushes.Black,
                    Clr.Purple => Brushes.Purple,
                    Clr.Blue => Brushes.Blue,
                    Clr.Pink => Brushes.Pink,
                    Clr.Orange => Brushes.Orange,
                    Clr.Red => Brushes.Red,
                    Clr.Green => Brushes.Green,
                    //Clr.Желтый => Brushes.Yellow,
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
                        Clr.White => Brushes.White,
                        Clr.Black => Brushes.Black,
                        Clr.Purple => Brushes.Purple,
                        Clr.Blue => Brushes.Blue,
                        Clr.Pink => Brushes.Pink,
                        Clr.Orange => Brushes.Orange,
                        Clr.Red => Brushes.Red,
                        Clr.Green => Brushes.Green,
                        //Clr.Желтый => Brushes.Yellow,
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
                            Clr.White => Brushes.White,
                            Clr.Black => Brushes.Black,
                            Clr.Purple => Brushes.Purple,
                            Clr.Blue => Brushes.Blue,
                            Clr.Pink => Brushes.Pink,
                            Clr.Orange => Brushes.Orange,
                            Clr.Red => Brushes.Red,
                            Clr.Green => Brushes.Green,
                            //Clr.Желтый => Brushes.Yellow,
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            new AddFigure(Figures).Show();
            Close();
        }
        
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            new RemoveFigure(Figures).Show();
            Close();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new Window1(Figures).Show();
        }
    }
}
