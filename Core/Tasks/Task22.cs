using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task22
    {
        private int M;
        private int N;

        public Task22(int m, int n)
        {
            M = m;
            N = n;
        }

        public double SquareDifference()
        {
            double squareDifference = 0;
            double difference = 0;

            for (int i = M; i <= N; i++)
            {
                difference -= i;
            }

            squareDifference += Math.Pow(difference, 2);

            return squareDifference;
        }
    }
}
