using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task14
    {
        public int Count(int n)
        {
            int count = 0;

            for(int i = 100; i <= 800; ++i)
            {
                if(i > n)
                {
                    ++count;
                }
            }
            return count;
        }
    }
}
