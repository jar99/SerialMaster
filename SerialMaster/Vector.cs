using System;

namespace SerialMaster.DataMath
{
    //This is code to make vectors sadly it didnt turn out well.
    //Data class for all of my vector needs

    public class IntVector2D
    {
            private int _x, _y;

            public int X { get => _x; set => _x = value; }
            public int Y { get => _y; set => _y = value; }

        public IntVector2D()
        {

        }

        public IntVector2D(IntVector2D vector)
        {
            X = vector.X;
            Y = vector.Y;
        }

        public IntVector2D(int x, int y)
        {
            X = x;
            Y = y;
        }



        public DVector2D Normalize
        {
            get
            {
                double r = Math.Sqrt(X * X + Y * Y);
                return new DVector2D(X / r, Y / r);
            }
        }
    }

    public class DVector2D
    {
        private double _x, _y;

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }

        public double Angle { get => 2 / Math.Sin(Math.Sqrt(_x * _x + _y * _y)); set { _x = Math.Sin(value); _y = Math.Cos(value); } }

        public DVector2D()
        {

        }

        public DVector2D(DVector2D vector)
        {
            X = vector.X;
            Y = vector.Y;
            Console.WriteLine("Angle: " + Angle);
        }

        public DVector2D(double x, double y)
        {
            X = x;
            Y = y;
        }


        public void AddAngle(double angle)
        {
            //Normalize the vector into sub revolution amount
            angle = angle % (Math.PI * 2);
            X *= Math.Sin(angle);
            Y *= Math.Cos(angle);

            Console.WriteLine("D: " + (Angle * 180 / Math.PI));

        }

        public static DVector2D AngleToVector(double angle)
        {
            //Normalize the vector into sub revolution amount
            angle = angle % (Math.PI * 2);

            double x, y;
            x = Math.Sin(angle);
            y = Math.Cos(angle);

            return new DVector2D(x, y);
        }

        public static DVector2D UnitVector(DVector2D vector2D)
        {
            double r = Math.Sqrt(vector2D.X * vector2D.X + vector2D.Y * vector2D.Y);
            return new DVector2D(vector2D.X / r, vector2D.Y / r);
        }

        public DVector2D Normalize
        {
            get
            {
                double r = Math.Sqrt(X * X + Y * Y);
                return new DVector2D(X / r, Y / r);
            }
        }
    }
}