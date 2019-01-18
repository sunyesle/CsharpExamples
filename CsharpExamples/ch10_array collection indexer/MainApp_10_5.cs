﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch10_array_collection_indexer // 3DArray
{
    class MainApp_10_5
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[4, 3, 2]
            {
                {{1,2},{3,4},{5,6 } },
                {{1,5},{3,4},{5,6 } },
                {{1,2},{7,4},{5,6 } },
                {{1,2},{3,4},{1,6 } },
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{ ");
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("{0} ", array[i,j,k]);
                    }
                    Console.Write("} ");
                }
                Console.WriteLine();
            }
        }
    }
}
