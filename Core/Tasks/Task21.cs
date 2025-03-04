using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task21
    {
        public double DifferenceOfSquares(int n)
        {
            double difference = 0;
            int i = 0;

            while(n != 0)
            {
                if (i % 2 != 0)
                    difference -= Math.Pow(n, 3);
                ++i;
                --n;
            }

            return difference;
        }
    }
}
