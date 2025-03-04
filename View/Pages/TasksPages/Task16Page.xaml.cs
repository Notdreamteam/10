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
    /// Логика взаимодействия для Task16Page.xaml
    /// </summary>
    public partial class Task16Page : Page
    {
        public Task16Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int p, q;

            p = Convert.ToInt32(Tbp.Text);
            q = Convert.ToInt32(Tbq.Text);

            Task16 task16 = new Task16();

            var divisor = task16.GetDivisors(q);

            foreach (var div in divisor)
            {
                if (task16.GCD(div, p) == 1)
                    TbA.Text += $"{div} ";
            }

            Tbp.Text = string.Empty;
            Tbq.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task17Page());
        }
    }
}
