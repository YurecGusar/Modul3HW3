using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    public class Starter
    {
        public void Run()
        {
            var firstClass = new FirstClass();
            var secondClass = new SecondClass();

            firstClass.ShowDelegat += Show;
            firstClass.OnHandlerForShow(secondClass.Calc((x, y) => x * y, 2, 2).Invoke(2));
        }

        private void Show(bool result)
        {
            Console.WriteLine(result);
        }
    }
}
