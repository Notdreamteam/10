using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task25
    {
        public double DifferenceOfSquares(int n)
        {
            double difference = 0;

            for(int i = 1; i <= n; i++)
            {
                difference -= Math.Pow(i, 2);
            }
            return difference;
        }
    }
}
