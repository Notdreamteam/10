using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task23
    {
        public double SumPositiveNumbers()
        {
            double sum = 0;

            for (int i = -20; i <= 20; ++i)
            {
                if (i < 0 && i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
