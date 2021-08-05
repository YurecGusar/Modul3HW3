using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    public class FirstClass
    {
        public Action<bool> ShowDelegat { get; set; }

        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
