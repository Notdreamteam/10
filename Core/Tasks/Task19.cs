using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task19
    {
        private int M;
        private int N;

        public Task19(int m, int n)
        {
            M = m;
            N = n;
        }

        public double Product()
        {
            double product = 1;

            for(int i = M; i <= N; i++)
            {
                if(i % 2 == 0)
                    product *= Math.Pow(i, 2);
            }
            return product;
        }
    }
}
