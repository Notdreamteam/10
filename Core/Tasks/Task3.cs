using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task3
    {
        public double CalculateSquare(int n)
        {
            double result = 1;

            for(int i = 2; i <= n; ++i)
            {
                result += Math.Pow(i, 2);
            }

            return result;
        }
    }
}
