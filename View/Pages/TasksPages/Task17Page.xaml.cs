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
    /// Логика взаимодействия для Task17Page.xaml
    /// </summary>
    public partial class Task17Page : Page
    {
        public Task17Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int N;
            N = Convert.ToInt32(Tbn.Text);

            Task17 task17 = new Task17();

            List<int> numbers = task17.PrimeFactors(N);

            TbA.Text = "[";
            foreach (int i in numbers)
            {
                TbA.Text += $"{i} ";
            }
            TbA.Text += "]";

            Tbn.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task18Page());
        }
    }
}
