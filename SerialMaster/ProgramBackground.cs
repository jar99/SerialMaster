using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SerialMaster
{
    //This is the code we want to run in the background. IE serial connections and joystick inputs.
    class ProgramBackground
    {
        //This is my class that calculates numbers.
        public CalculateNumber number;
        //private Thread numberThread;

        public ProgramBackground() {
            number = new CalculateNumber();
        }

        bool shouldRun;
        //This is the background loop. This will call all background loop updates
        public void startBackgroud(int delay)
        {
            //Pre startup code here

            //This is the start of the main loop for the background
            shouldRun = true;
            while (shouldRun)
            {
                number.GeirateBetterNumbers();
                Thread.Sleep(delay);
            }
            //Poste closing code here.

        }

        //Here we have the bacgound stoper.
        //Put code here for preclosing
        public void stopBackground()
        {
            shouldRun = false;
        }
    }
}
