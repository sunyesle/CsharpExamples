﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch10_array_collection_indexer // UsingQueue
{
    class MainApp_10_7_2
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);
            que.Enqueue(6);
            
            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }
    }
}
