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
    /// Логика взаимодействия для Task10Page.xaml
    /// </summary>
    public partial class Task10Page : Page
    {
        public Task10Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int n, m;

            n = Convert.ToInt32(Tbn.Text);
            m = Convert.ToInt32(Tbm.Text);

            if(m > n)
            {
                TbA.Text = "M должно быть меньше N";
            }
            else
            {
                Task10 task10 = new Task10(m, n);

                TbA.Text = $"{task10.SumSquare()}";
            }

            Tbn.Text = string.Empty;
            Tbm.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task11Page());
        }
    }
}
