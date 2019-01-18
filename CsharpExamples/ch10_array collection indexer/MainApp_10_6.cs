using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch10_array_collection_indexer // JaggedArray
{
    class MainApp_10_6
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };

            foreach (int[] arr in jagged)
            {
                Console.Write("Length : {0}, ", arr.Length);
                foreach (int e in arr)
                {
                    Console.Write("{0} ", e);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            int[][] jagged2 = new int[2][] {
                new int[5] { 1, 2, 3, 4, 5 },
                new int[] { 10, 20, 30 }  };

            foreach (int[] arr in jagged2)
            {
                Console.Write("Length : {0}, ", arr.Length);
                foreach (int e in arr)
                {
                    Console.Write("{0} ", e);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
