using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task18
    {
        public List<int> GeneratePrimeNumbers(int count)
        {
            List<int> primes = new List<int>();
            int number = 2; 

            while (primes.Count < count)
            {
                if (IsPrime(number))
                {
                    primes.Add(number);
                }
                number++;
            }

            return primes;
        }

        public bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true; 

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; 
                }
            }

            return true; 
        }
    }
}
