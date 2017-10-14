using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialMaster
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ApplicationManager());

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("K> " + number.GetNumber());
                Thread.Sleep(1000);
            }
            */

        }


    }
}
