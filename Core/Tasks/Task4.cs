using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task4
    {
        public (double sumEven, double sumOdd) CalculateSquare(int n)
        {
            double sumEvenNumbers = 0, sumOddNumbers = 0;

            for (int i = 2; i <= n; ++i)
            {
                if (i % 2 == 0)
                {
                    sumEvenNumbers += Math.Pow(i, 2);
                }
                else
                {
                    sumOddNumbers += Math.Pow(i, 2);
                }
            }

            return (sumEvenNumbers, sumOddNumbers);
        }
    }
}
