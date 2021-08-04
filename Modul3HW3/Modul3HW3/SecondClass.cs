using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    public class SecondClass
    {
        private int _powResult;
        public Func<int, bool> Calc(Func<int, int, int> powDelegat, int x, int y)
        {
            _powResult = powDelegat.Invoke(x, y);

            return Result;
        }

        public bool Result(int num)
        {
            return _powResult % num == 0;
        }
    }
}
