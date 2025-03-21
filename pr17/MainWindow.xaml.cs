using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr17;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Calculate(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(textBoxNumberFirst.Text, out double a) &&
                double.TryParse(textBoxNumberSecond.Text, out double b) &&
                    double.TryParse(textBoxNumberTh.Text, out double c))
        {
            double volume = a * b * c;
            double surfaceArea = 2 * (a * b + b * c + a * c);

            textBoxNumberResult.Text = $"Объем: {volume}\nПлощадь поверхности: {surfaceArea}";
        }

        else
        {
            textBoxNumberResult.Text = "Error";
        }
                
    }
    private void AboutProgram(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Чеботарев Максим ИСП-22\nДаны длины ребер a, b, c прямоугольного параллелепипеда. \nНайти его объем V = a·b·c и площадь поверхности\n S = 2·(a·b + b·c + a·c).");
    }

    private void Exit(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }


}