﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch10_array_collection_indexer // DerivedFromArray
{
    class MainApp_10_3_1
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 30, 20, 7, 1 };
            Console.WriteLine("Type Of array : {0}", array.GetType());
            Console.WriteLine("Base type Of array : {0}", array.GetType().BaseType);
        }
    }
}
