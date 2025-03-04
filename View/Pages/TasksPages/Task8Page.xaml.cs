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
    /// Логика взаимодействия для Task8Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int B;
            B = Convert.ToInt32(Tbb.Text);

            if (B < 0)
            {
                TbA.Text = "B должно быть меньше 0";
            }
            else
            {
                Task8 task8 = new Task8();

                List<int> numbers = task8.PrimeFactors(B);

                TbA.Text = "[";
                foreach (int i in numbers)
                {
                    TbA.Text += $"{i} ";
                }
                TbA.Text += "]";
            }
            Tbb.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task9Page());
        }
    }
}
