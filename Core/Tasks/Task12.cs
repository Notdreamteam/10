using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task12
    {
        public double ProductEvenSquare()
        {
            double product = 1;

            for(int i = -80; i <= 80; ++i)
            {
                if(i % 7 == 0 && i % 2 != 0)
                {
                    product *= i;
                }
            }
            return product;
        }
    }
}
