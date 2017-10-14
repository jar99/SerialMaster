using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace SerialMaster
{
    class PointLine
    {

        int x, y, lineLength;

        Quaternion angleV;

        public PointLine(int pointX, int pointY, int length)
        {
            x = pointX;
            y = pointY;
            lineLength = length;
            angleV = new Quaternion(new Vector3D(0,0,1), 0);
        }

        public PointLine(int pointX, int pointY, int length, double angle)
        {
            x = pointX;
            y = pointY;
            lineLength = length;
            angle = (angle / 180) * Math.PI;
            Console.WriteLine("AA> " + Math.Cos(angle));
            angleV = new Quaternion(new Vector3D(0, 0, 1), angle);
        }

        public void changeAngle(double angle)
        {
            angle = angle / 180 * Math.PI;
            Quaternion angleB = new Quaternion(new Vector3D(0, 0, 1), angle);
            angleV = Quaternion.Multiply(angleV, angleB);
            Console.WriteLine("V2: " + angleV.X + " ," + angleV.Y);
        }

        public System.Drawing.Point getStartPoint
        {
            get
            {
                Console.WriteLine("Start:" + x + "," + y);
                return new System.Drawing.Point(x, y);
            }
        }

        public System.Drawing.Point getEndPoint
        {
            get
            {
                Console.WriteLine("Angle: " + (angleV.Angle*180/Math.PI) + " | "  + angleV.X + ", " + angleV.Y +  ", " + angleV.Z);
                int endX = (int)(Math.Sin(angleV.Angle) * lineLength) + x;
                int endY = (int)(Math.Cos(angleV.Angle) * lineLength) + y;
                Console.WriteLine("End:" + endX + "," + endY);
                return new System.Drawing.Point(endX, endY);
            }
        }
    }
}
