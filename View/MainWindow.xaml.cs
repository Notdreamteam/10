using System.Windows;
using WpfApp14.Core;
using WpfApp14.View.Pages;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyNavigation.MyConnect = MyFrame;

            MyFrame.Navigate(new MainPage());
        }
    }
}
