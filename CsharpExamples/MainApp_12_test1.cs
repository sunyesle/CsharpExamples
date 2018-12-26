using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class MainApp_12_test1
    {    static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    arr[i] = i;
                }

                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
        }
    }
}
