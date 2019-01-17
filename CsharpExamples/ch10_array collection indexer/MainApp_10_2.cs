using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch10_array_collection_indexer // InitializingArray
{
    class MainApp_10_2
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };

            Console.WriteLine("array1...");
            foreach (string greeting in array1)
            {
                Console.WriteLine("{0} ", greeting);
            }

            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray2...");
            foreach (string greeting in array1)
            {
                Console.WriteLine("{0} ", greeting);
            }

            string[] array3 = { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray2...");
            foreach (string greeting in array1)
            {
                Console.WriteLine("{0} ", greeting);
            }
        }
    }
}
