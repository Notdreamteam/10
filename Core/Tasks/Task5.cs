using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task5
    {
        public int Number(int N)
        {
            for(int i = 1; i <= N; ++i)
            {
                if(i % 5 != 0 && i % 3 == 0)
                {
                    int sumNumeral = SumNumeral(i);
                    if(sumNumeral % 5 != 0 && sumNumeral % 3 == 0)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        public int SumNumeral(int number)
        {
            int sum = 0;

            while(number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
