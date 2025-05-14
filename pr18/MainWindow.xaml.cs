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

namespace pr18;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    //обработчик переключения чекбоксов для вкл/выкл панели
    private void PanelToggle(object sender, RoutedEventArgs e)
    {
        //??без проверки на null не работает, с проверкой выводит после окна msBox
        if (autoGroups == null)
        {
            MessageBox.Show("??");
            return;
        }

        autoGroups.IsEnabled = chkAutoPanel.IsChecked == true;
        ManualGroup.IsEnabled = chkManualPanel.IsChecked == true;
    }

    //обработка выбора сезона в авто режиме
    private void AutoSeason_Checked(object sender, RoutedEventArgs e)
    {
        RadioButton rb = sender as RadioButton;
        if(rb !=null)
        {
            string season = rb.Content.ToString();
            string months = GetMonthBySeason(season);
            txtAutoResult.Text = $"Вы выбрали: {season}\n Месяцы:{months}";
        }
    }

    //обработка выбора сезона в ручном режиме
    private void ManualCalculate(object sender, RoutedEventArgs e)
    {
        string selectedSeason = null;

        //перебираем все элементы внутри стэкпанели
        foreach(var child in manualSeasonPanel.Children)
        {
            if(child is RadioButton rb && rb.IsChecked == true) //сохраняем в rb выбранный сезон
            {
                selectedSeason = rb.Content.ToString(); //сохраняем название сезона
                break;
            }
        }

        if(selectedSeason != null)
        {
            string months = GetMonthBySeason(selectedSeason);
            txtManualResult.Text = $"Вы выбрали: {selectedSeason}\n Месяцы:{months}";
        }

        else
        {
            txtManualResult.Text = "Вы не выбрали сезон";
        }
    }


    //о программе
    private void ShowAbout(object sender, RoutedEventArgs e)
    {
        string message =
          "Разработал: Чеботарев Максим, ИСП-22\n" +
          "Составить программу, которая бы по введенному времени года выдавала бы название месяцев, относящихся к нему.";

        MessageBox.Show(message, "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    //выход
    private void ExitApplication(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
    // метод позвоялет сохранить месяца в выбранном сезона в переменную months
    private string GetMonthBySeason(string season)
    {
        switch (season)
        {
            case "Зима":
                return "Декабрь, Январь, Февраль";
            case "Весна":
                return "Март, Апрель, Май";
            case "Лето":
                return "Июнь, Июль, Август";
            case "Осень":
                return "Сентябрь, Октябрь, Ноябрь";
            default:
                return "Неизвестный сезон";
        }
    }
}
