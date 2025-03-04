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
    /// Логика взаимодействия для Task28Page.xaml
    /// </summary>
    public partial class Task28Page : Page
    {
        public Task28Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int n, m;

            n = Convert.ToInt32(Tbn.Text);
            m = Convert.ToInt32(Tbm.Text);

            Task28 task28 = new Task28(m, n);

            List<int> numbers = task28.Numbers();

            TbA.Text = "[";
            foreach (int num in numbers)
            {
                TbA.Text += $"{num} ";
            }
            TbA.Text += "]";

            Tbn.Text = string.Empty;
            Tbm.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task29Page());
        }
    }
}
