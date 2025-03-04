using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task28
    {
        private int M;
        private int N;

        public Task28(int m, int n)
        {
            M = m;
            N = n;
        }

        public List<int> Numbers()
        {
            List<int> result = new List<int>();
            int sum = 0;

            for(int i = 0; i <= N; ++i)
            {
                for(int j = 0; j <= Convert.ToString(i).Length; ++j)
                {
                    sum += Convert.ToInt32(j);
                }
                if(Math.Pow(sum, 2) == M)
                    result.Add(i);
                sum = 0;
            }
            return result;
        }
    }
}
