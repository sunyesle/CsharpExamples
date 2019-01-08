using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpExamples
{
    class MainApp_20_4_1 :Form
    {
        public void MyMouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Sender : {0}" , ((Form)sender).Text);
            Console.WriteLine("X:{0}, Y:{1}", e.X, e.Y);
            Console.WriteLine("Buttom:{0}, Click:{1}", e.Button, e.Clicks);
            Console.WriteLine();
        }

        public MainApp_20_4_1(string title)
        {
            this.Text = title;
            this.MouseDown += new MouseEventHandler(MyMouseHandler);
        }

        static void Main(string[] args)
        {
            Application.Run(new MainApp_20_4_1("Mouse Event Test"));
        }
    }
}
