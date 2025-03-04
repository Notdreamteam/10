using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task9
    {
        public List<double> PerfectNumbers(int x)
        {
            List<double> result = new List<double>();

            for(int i = 2; i <= x; i++)
            {
                if(IsPerfectNumber(i))
                    result.Add(i);
            }

            return result;
        } 

        public bool IsPerfectNumber(int number)
        {
            int sumOfDivisors = 0;

            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    sumOfDivisors += i;
                }
            }

            return sumOfDivisors == number;
        }
    }
}
