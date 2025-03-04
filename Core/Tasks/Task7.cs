using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task7
    {
        public string Logariph(double a)
        {
            double logValue = Math.Log(a, 2);

            if(logValue % 1 == 0)
            {
                return "Да";
            }
            return "Нет";
        }
    }
}
