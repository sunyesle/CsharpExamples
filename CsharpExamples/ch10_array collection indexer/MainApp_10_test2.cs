using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch10_array_collection_indexer
{
    class Matrix
    {
        public static int[,] Multiply(int[,] x, int[,] y)
        {
            int[,] array = new int[2, 2];
            array[0, 0] = x[0, 0] * x[0, 1] + x[0, 1] * y[1, 0];
            array[0, 1] = x[0, 0] * y[0, 1] + x[0, 1] * y[1, 1];
            array[1, 0] = x[1, 0] * y[0, 0] + x[1, 1] * y[1, 0];
            array[1, 1] = x[1, 0] * y[0, 1] + x[1, 1] * y[1, 1];
            
            return array;
        }
    }

    class MainApp_10_test2
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            int[,] b = new int[2, 2] { { 9, 2 }, { 1, 7 } };

            int[,] result = Matrix.Multiply(a, b);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write("{0} " , result[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
