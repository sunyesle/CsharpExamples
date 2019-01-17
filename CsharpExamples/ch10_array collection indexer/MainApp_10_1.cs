using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch10_array_collection_indexer // ArraySample
{
    class MainApp_10_1
    {

        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            int sum = 0;
            foreach(int score in scores)
            {
                sum += score;
            }
            int average = sum / scores.Length;

            Console.WriteLine("Average Score : {0}", average);
        }
    }
}
