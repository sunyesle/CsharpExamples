using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples    //호출자 정보 애트리뷰트
{
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member="") //선택적 매개변수 사용함
        {
            Console.WriteLine(
                "{0}(Line:{1}) {2}: {3}",file, line, member, message);
        }
    }
    class MainApp_16_2_2
    {
        static void Main(string[] args)
        {
            Trace.WriteLine("즐거운 프로그래밍");
        }
    }
}
