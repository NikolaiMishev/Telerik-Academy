namespace DefiningClassesPartTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Point3D
    {
        private static readonly Point3D O = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartPoint { get { return O; } }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }


        public override string ToString()
        {
            return String.Format("x{0:F2} y{1:F2} z{2:F2}", X, Y, Z);
        }
    }
}
