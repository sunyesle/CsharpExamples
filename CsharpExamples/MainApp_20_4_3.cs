using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpExamples // FormAndControl
{
    class MainApp_20_4_3 : Form
    {
        static void Main(string[] args)
        {
            Button button = new Button();

            button.Text = "Click Me!";
            button.Left = 100;
            button.Top = 50;

            button.Click +=
                (object sender, EventArgs e) =>
                {
                    MessageBox.Show("click!");
                };

            MainApp_20_4_3 form = new MainApp_20_4_3();
            form.Text = "Form & Control";
            form.Height = 150;

            form.Controls.Add(button);

            Application.Run(form);
        }
    }
}
