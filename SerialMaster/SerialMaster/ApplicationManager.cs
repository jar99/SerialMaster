using System;
using System.Threading;
using System.Windows.Forms;

namespace SerialMaster
{

    class ApplicationManager : ApplicationContext
    {

        private int openForms;
        private ProgramBackground background;
        private NumberViewer numberViewer;

        private DataStore<int> _data;

        public ApplicationManager()
        {

            _data = new DataStore<int>();
            background = new ProgramBackground();
            background.startBackgroud();
            numberViewer = new NumberViewer(_data);

            linkForm(numberViewer);
            linkBackgroundToForm();
        }

        public void linkBackgroundToForm()
        {
            double lastTime = Environment.TickCount;
            while (true)
            {
                if (Environment.TickCount - lastTime >= 216)
                {
                    Console.WriteLine("Update");
                    _data.Add(background.number.GetNumber());
                    lastTime = Environment.TickCount;
                }
            }
        }


        //Closing linker
        private void linkForm(params Form[] forms)
        {
            openForms = forms.Length;

            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    //When we have closed the last of the "starting" forms, 
                    //end the program.
                    if (Interlocked.Decrement(ref openForms) == 0)
                        closeAplication();
                        ExitThread();
                };

                form.Show();
            }
        }

        private void closeAplication()
        {
            background.stopBackground();
        }
    }

}
