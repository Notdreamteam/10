using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task16
    {
        public List<int> GetDivisors(int q)
        {
            List<int> divisors = new List<int>();

            for(int i = 0; i < Math.Abs(q); ++i)
            {
                if(q % i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors;
        }
        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
