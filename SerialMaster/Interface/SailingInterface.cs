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
    public partial class SailingInterface : Form
    {
        public Action<string, int> comUpdate;
        PointLine rudder;

        DataStore<string> sendQue;

        public SailingInterface(DataStore<string> comSendQue)
        {
            sendQue = comSendQue;

            rudder = new PointLine(255, 400, 100);

            InitializeComponent();
            updateComPortList();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.DarkGreen, 10);
            pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            graphics.DrawLine(pen, rudder.getStartPoint, rudder.getEndPoint);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            rudder.changeAngle(-5);
            panel1.Refresh();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            rudder.changeAngle(5);
            panel1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SailingInterface_Load(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
                sendQue.Add(textBox2.Text.Trim());
                textBox2.Clear();
                updateComPortList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateComPortList()
        {
            //Code here to setup ui
            comport.Items.Clear();
            bodrate.Items.Clear();
            comport.Items.AddRange(SerialConnection.getPorts());
            bodrate.Items.AddRange(SerialConnection.getBaudRates());
        }

        //Update comport
        private void bodrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateComport();
        }

        private void comport_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateComport();
        }


        public void updateComport()
        {
            if (comport.SelectedItem != null && bodrate.SelectedItem != null)
            {
                comUpdate(comport.SelectedItem.ToString(), SerialConnection.BaudRates[bodrate.SelectedIndex]);
            }
        }

        public void updateTextBox(String[] items)
        {
            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

    }
}
