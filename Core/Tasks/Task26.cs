using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task26
    {
        public List<int> Odd()
        {
            List<int> odds = new List<int>();

            for(int i = 100; i <= 200; ++i)
            {
                if(i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds;
        }
    }
}
