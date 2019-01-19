using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch10_array_collection_indexer // UsingGenericQueue
{
    class MainApp_11_5_2
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (queue.Count> 0)
                Console.WriteLine(queue.Dequeue());
        }
    }
}
