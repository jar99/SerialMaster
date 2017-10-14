using System;
using System.Threading;
using System.Windows.Forms;

namespace SerialMaster
{

    class ApplicationManager : ApplicationContext
    {

        //Object and code for background manager
        private ProgramBackground background;
        private Thread backroundThread;

        //Here are all of our forms
        private NumberViewer numberViewer;
        private SailingInterface sailing;

        //This is a thread safe data structure
        //private DataStore<int> _data;

        public ApplicationManager()
        {

            //_data = new DataStore<int>();
            background = new ProgramBackground();
            backroundThread = new Thread(() => background.startBackgroud(1));
            backroundThread.Start();

            //Code to set up all the forms
            numberViewer = new NumberViewer();

            sailing = new SailingInterface();

            linkForm(numberViewer, sailing);

            //First update to get the right data
            updateForms();

            //Calls the update tick
            setUpLinker();
        }

        //Sets up all of the backgroundToform update timers
        private void setUpLinker()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        //This is the code that gets called on a timer. 
        private void timer_Tick(object sender, EventArgs e)
        {
            updateForms();
            //No need to update _data because we are not doing any cross thread sharing
            //_data.Add(background.number.GetNumber());
        }

        //Seperate method so we can update the form else where
        private void updateForms()
        {
            numberViewer.setLable1(background.number.GetNumber().ToString());
        }

        //Closing linker
        private void linkForm(params Form[] forms)
        {
            int openForms = forms.Length;

            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    //When we have closed the last of the "starting" forms, 
                    //end the program.
                    if (Interlocked.Decrement(ref openForms) == 0)
                    {
                        closeAplication();
                        ExitThread();
                    }
                        
                };

                form.Show();
            }
        }

        //CleanUp for closing

        private void closeAplication()
        {
            if (backroundThread.IsAlive) {
                background.stopBackground();
            }
        }
    }

}
