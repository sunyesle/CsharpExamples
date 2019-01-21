﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch07_class // ThisConstructor
{
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine("MyClass({0})", b);
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine("MyClass({0}, {1})", b, c);
        }

        public void printFields()
        {
            Console.WriteLine("a:{0}, b:{1}, c:{2}", a, b, c);
        }
    }

    class MainApp_7_6_2
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.printFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.printFields();
            Console.WriteLine();

            MyClass c = new MyClass(10, 20);
            c.printFields();
        }
    }
}
