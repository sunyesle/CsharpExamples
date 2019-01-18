using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch10_array_collection_indexer // Indexer
{
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }

                array[index] = value;
            }
        }

        public int length
        {
            get { return array.Length; }
        }

    }

    class MainApp_10_8
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();

            for (int i = 0; i < 5; i++)
                list[i] = i;

            for (int i = 0; i < list.length; i++)
                Console.WriteLine(list[i]);
        }
    }
}
