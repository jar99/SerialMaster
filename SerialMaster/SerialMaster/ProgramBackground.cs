using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SerialMaster
{
    class ProgramBackground
    {
        public CalculateNumber number;
        private Thread numberThread;

        public ProgramBackground() {
            number = new CalculateNumber();
        }

        public void startBackgroud()
        {
            numberThread = new Thread(() => number.GeirateNumbers(10));
            numberThread.Start();
        }

        public void stopBackground()
        {
            if (numberThread == null) {
                Console.WriteLine("The thread in null.");
                return;
            }
            number.StopGeneratingNumbers();
            numberThread.Join();
        }
    }
}
