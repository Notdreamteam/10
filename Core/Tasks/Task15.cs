using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task15
    {
        public List<int> Numbers(int n)
        {
            List<int> numbers = new List<int>();

            for(int i = 1; i < n; ++i)
            {
                if(GCD(i, n) == 1)
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }

        public int GCD(int a, int b)
        {
            while(b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
