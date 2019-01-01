using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples    // 다음중 올바로 동작하지 않는것은?
{
    class MainApp_16_test1
    {
        static void Main(string[] args)
        {
            int myObject = 0;

            Type a = myObject.GetType();
            //Type b = typeof("int");               (X)
            //Type c = Type.GetType(int);           (X)
            Type d = Type.GetType("System.Int32");
        }
    }
}

// test2 : 주석과 애트리뷰트의 차이는?
//  주석은 사람이 읽고 쓰고, 애트리뷰트는 사람이 쓰고 컴퓨터가 읽는다.
