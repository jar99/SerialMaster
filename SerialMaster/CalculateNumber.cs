using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SerialMaster
{
    //This is a function that generates random numbers
    class CalculateNumber
    {
        private bool shouldUpdate;
        private bool shouldStop;
        private int number;

        private Random rand;

        public CalculateNumber()
        {
            rand = new Random();
        }


        public void GeirateNumbers(int delay)
        {
            Console.WriteLine("Strted Number Maker.");
            shouldUpdate = true;
            shouldStop = false;
            while (!shouldStop)
            {
                if (shouldUpdate)
                {
                    number = rand.Next();
                    //Console.WriteLine("N> " + number);
                    Thread.Sleep(delay);
                }
            }
            Console.WriteLine("Ended Number Maker.");
        }

        internal void GeirateBetterNumbers()
        {
            number = rand.Next();
        }

        public void StopGeneratingNumbers()
        {
            shouldStop = true;
        }

        public int GetNumber()
        {
            return number;
        }

        public bool ShouldUpdate()
        {
            return shouldUpdate;
        }

        public bool ToggleUpdate()
        {
            if (shouldUpdate)
            {
                shouldUpdate = false;
                return shouldUpdate;
            }
            shouldUpdate = true;
            return shouldUpdate;
        }


    }
}
