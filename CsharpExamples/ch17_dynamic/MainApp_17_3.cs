using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace CsharpExamples
{
    class MainApp_17_3
    {
        static void Main(string[] args)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("n", "박상현");
            scope.SetVariable("p", "010-123-1234");

            ScriptSource source = engine.CreateScriptSourceFromString(
                @"
class NameCard :
    name = ''
    phone = ''

    def __init__(self, name, phone):
        self.name = name
        self.phone = phone

    def printNameCard(self) :
        print self.name + ', ' + self.phone

NameCard(n,p)
");
            // 파이썬 코드를 실행하여 그결과를 반환함, NameCard 객체가 생성되어 반환됨
            dynamic result = source.Execute(scope);
            // 객체의 메소드 호출 가능
            result.printNameCard();
            // 필드 접근 가능
            Console.WriteLine("{0}, {1}", result.name, result.phone);
        }
    }
}
