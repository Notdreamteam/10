using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task30
    {
        private int M;
        private int N;

        public Task30(int m, int n)
        {
            M = m;
            N = n;
        }

        public double Sum()
        {
            double sum = 0;

            for (int i = M; i <= N; i++)
            {
                if (i % 2 == 0)
                    sum += Math.Pow(i, 2);
            }
            return sum;
        }
    }
}
