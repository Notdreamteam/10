using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task24
    {
        public double SumPositiveNumbers()
        {
            double sum = 0;

            for (int i = 0; i < 100; ++i)
            {
                if (i % 4 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
