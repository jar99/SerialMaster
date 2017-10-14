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
        PointLine rudder;

        public SailingInterface()
        {
            rudder = new PointLine(255, 400, 100);

            InitializeComponent();
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
    }
}
