using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task6
    {
        public List<int> MultiplesOfFive(int N)
        {
            List<int> numbers = new List<int>();

            for(int i = 0; i <= N; ++i)
            {
                if(i % 5 == 0)
                    numbers.Add(i);
            }
            return numbers;
        }
    }
}
