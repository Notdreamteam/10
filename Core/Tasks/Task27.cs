using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task27
    {
        private int M;
        private int N;

        public Task27(int m, int n)
        {
            M = m;
            N = n;
        }

        public double ProductCube()
        {
            double product = 1;

            for (int i = M; i <= N; i++)
            {
                product += Math.Pow(i, 3);
            }

            return product;
        }
    }
}
