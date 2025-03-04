using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp14.Core;
using WpfApp14.Core.Tasks;

namespace WpfApp14.View.Pages.TasksPages
{
    /// <summary>
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int N;
            N = Convert.ToInt32(Tbb.Text);

            if (N < 0)
            {
                TbA.Text = "N должно быть меньше 0";
            }
            else
            {
                Task1 task1 = new Task1();

                long factorial = task1.Calculate(N);
                TbA.Text = $"{factorial}";

            }
            Tbb.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task2Page());
        }
    }
}
