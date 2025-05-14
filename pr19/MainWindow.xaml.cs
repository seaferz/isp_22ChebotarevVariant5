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

namespace pr19;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void btnAddValue_Click(object sender, RoutedEventArgs e)
    {
        IBoxValue.Items.Add(txtBoxValue.Text);
    }
    private void btnDeletedValue_Click(object sender, RoutedEventArgs e)
    {
        IBoxValue.Items.Remove(IBoxValue.SelectedItem);
    }
    private void btnClearValue_Click(object sender, RoutedEventArgs e)
    {
        IBoxValue.Items.Clear();
    }

    //Найти произведение чисел < 3
    private void btnResult_Click(object sender, RoutedEventArgs e)
    {
        for (int i = 0; i < IBoxValue.Items.Count; i++)
        {
             double productNumber = 1;
             double  currentValue = Convert.ToDouble(IBoxValue.Items[i]);

            if (currentValue < 3)
            {
                productNumber *= currentValue;
            }
        }
    }
    private void btnGenerateValues_Click(object sender, RoutedEventArgs e)
    {

    }
        
}