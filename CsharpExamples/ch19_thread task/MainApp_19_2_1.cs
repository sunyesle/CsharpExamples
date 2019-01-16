using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpExamples // Task
{
    class MainApp_19_2_1
    {
        static void Main(string[] args)
        {
            string srcFile = args[0];

            Action<object> FileCopyAction = (object state) =>
            {
                String[] paths = (String[])state;
                File.Copy(paths[0], paths[1]);

                Console.WriteLine("TaskID: {1}, Thread:{1}, {2} was copied to {3}",
                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
            };

            Task t1 = new Task( // 두번째 매개변수는 FileCopyAction의 매개변수로 사용됨
                FileCopyAction,
                new string[] { srcFile, srcFile + ".copy1" });

            Task t2 = Task.Run(() =>
            {
                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
            });

            t1.Start();

            Task t3 = new Task(
                FileCopyAction,
                new string[] { srcFile, srcFile + ".copy3" });

            // Task는 동기실행을 위한 메소드도 제공함
            // 이 메소드는 실행이 끝나야 반환되지만, 나쁜습관을 방지하기위해 항상 Wait()을 호출해주는 것이 좋음
            t3.RunSynchronously();  

            t1.Wait();
            t2.Wait();
            t3.Wait();
        }
    }
}
