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
        private DataStore<int> _data;
        public NumberViewer(DataStore<int> data)
        {
            _data = data;

            InizializeUpdates();
            InitializeComponent();
        }

        private void InizializeUpdates()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (var s in _data.TakeWork())
            {
                label1.Text = s.ToString();
            }
            label1.Refresh();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumberViewer_Load(object sender, EventArgs e)
        {
        
        }
    }
}
