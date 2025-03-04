using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task8
    {
        public List<int> PrimeFactors(int n)
        {
            List<int> result = new List<int>();

            while (n % 2 == 0)
            {
                result.Add(2);
                n /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    result.Add(i);
                    n /= i;
                }
            }

            if (n > 2)
            {
                result.Add(n);
            }
            return result;
        }
    }
}
