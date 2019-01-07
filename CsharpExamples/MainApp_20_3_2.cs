using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpExamples
{
    class MessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x0F || m.Msg == 0xA0 || m.Msg == 0x200 || m.Msg == 0x133)
                return false;

            Console.WriteLine("{0} : {1}", m.ToString(), m.Msg);

            if (m.Msg == 0x201)
                Application.Exit();

            return true;
        }
    }

    class MainApp_20_3_2 : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new MessageFilter());
            Application.Run(new MainApp_20_3_2());
        }
    }
}
