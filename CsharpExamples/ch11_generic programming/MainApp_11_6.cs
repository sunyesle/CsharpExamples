using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch11_generic_programming
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;

        public MyList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }

        //IEnumerable 멤버
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }
        public T Current
        {
            get { return array[position]; }
        }

        //IEnumerator 멤버
        object IEnumerator.Current
        {
            get { return array[position]; }
        }

        //IEnumerator 멤버
        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }

        //IEnumerator 멤버
        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {

        }
    }

    class MainApp_11_6
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach (string str in str_list)
                Console.WriteLine(str);

            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;
            int_list[4] = 4;

            foreach (int no in int_list)
                Console.WriteLine(no);
        }
    }
}
