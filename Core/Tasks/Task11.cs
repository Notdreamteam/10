using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task11
    {
        private int M;
        private int N;

        public Task11(int m, int n)
        {
            M = m;
            N = n;
        }

        public double SumEvenSquare()
        {
            double sum = 1;

            for(int i = M; i <= N; i++)
            {
                if(i % 2 != 0)
                {
                    sum += Math.Pow(i, 2);
                }
            }

            return sum;
        }
    }
}
