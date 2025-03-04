using System.Windows;
using System.Windows.Controls;
using WpfApp14.Core;
using WpfApp14.View.Pages.TasksPages;

namespace WpfApp14.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTasks_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task1Page());
        }
    }
}
