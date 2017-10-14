using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialMaster
{
    public partial class NumberViewer : Form
    {
        public NumberViewer()
        {
            InitializeComponent();
        }

        //This is curently not needed because my Aplication manager Is handaling the update
        private DataStore<int> _data;
        public NumberViewer(DataStore<int> data)
        {
            _data = data;

            InitializeComponent();
            InizializeUpdates();
        }

        private void InizializeUpdates()
        {
            Console.WriteLine("Creating the updates");
            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            updateUI();
        }

        private void updateUI()
        {
            var data = _data.TakeWork();
            if (data.Length > 0)
            {
                label1.Text = data[0].ToString();
            }
        }
        //----------------------------------------------------------

        public void setLable1(string s)
        {

            label1.Text = s;
        }

        private void NumberViewer_Load(object sender, EventArgs e)
        {
            
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
    }
}
