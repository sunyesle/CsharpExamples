using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch10_array_collection_indexer // UsingDictionary
{
    class MainApp_11_5_4
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["하나"] = "one";
            dic["둘"] = "two";
            dic["셋"] = "three";
            dic["넷"] = "four";
            dic["다섯"] = "five";

            Console.WriteLine(dic["하나"]);
            Console.WriteLine(dic["둘"]);
            Console.WriteLine(dic["셋"]);
            Console.WriteLine(dic["넷"]);
            Console.WriteLine(dic["다섯"]);
        }
    }
}
