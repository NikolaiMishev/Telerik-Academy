namespace DefiningClassesPartTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Path
    {
        private List<Point3D> pointsPath;

        public Path()
        {
            pointsPath = new List<Point3D>();
        }

        public List<Point3D> PointsPath
        {
            get
            {
                //return new List<Point3D>(this.pathPoints);
                return this.pointsPath;
            }
        }

        public void AddPoint(double x, double y, double z)
        {
            this.pointsPath.Add(new Point3D(x, y, z));
        }

        public void AddPoint(Point3D point)
        {
            this.pointsPath.Add(point);
        }
    }
}
