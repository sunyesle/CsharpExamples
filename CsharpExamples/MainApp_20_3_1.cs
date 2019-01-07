using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpExamples
{
    class MainApp_20_3_1 : Form
    {
        static void Main(string[] args)
        {
            MainApp_20_3_1 form = new MainApp_20_3_1();

            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Console.WriteLine("Closing Window...");
                    Application.Exit();
                });

            Console.WriteLine("Starting Window Application...");
            Application.Run(form);

            Console.WriteLine("Exiting Window Application...");
        }
    }
}
