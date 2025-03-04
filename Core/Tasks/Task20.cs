using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task20
    {
        public double Factorial(int n)
        {
            double result = 0;

            for(int i = 0; i <= 2*n; i++)
            {
                result += n * (n + 1);
            }

            return result;
        }
    }
}
