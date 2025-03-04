using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task13
    {
        public double SumPositiveNumbers()
        {
            double sum = 0;

            for (int i = -10; i <= 10; ++i)
            {
                if (i > 0 && i % 9 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
