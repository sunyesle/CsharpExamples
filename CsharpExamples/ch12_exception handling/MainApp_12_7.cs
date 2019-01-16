using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class MainApp_12_7
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                Console.WriteLine(3/--a);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
