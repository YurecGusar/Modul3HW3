using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    public class FirstClass
    {
        public event Action<bool> Act;

        public int Pow(int x, int y)
        {
            return x * y;
        }

        private void OnHandler(bool status)
        {
            Act?.Invoke(status);
        }
    }
}
