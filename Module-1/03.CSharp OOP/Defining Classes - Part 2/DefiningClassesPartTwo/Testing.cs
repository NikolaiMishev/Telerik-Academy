namespace DefiningClassesPartTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Testing
    {
        static void Main()
        {

            // first create 3 points
            Point3D p1 = new Point3D(1.3, 2.3, 3.1);
            Point3D p2 = new Point3D(4.2, 2.8, -5);
            Point3D p3 = new Point3D(1.1, 2.5, 11.7);

            // calculate distance between first two points
            Console.WriteLine("Distance between p1 and p2: {0}", CalculateDistance.TwoPoints(p1, p2));

            // create two test paths and save them to two files
            Path testPath1 = new Path();
            testPath1.AddPoint(p1);
            testPath1.AddPoint(p2);
            testPath1.AddPoint(p3);
            PathStorage.SavePath(testPath1, "SavedTestPath1");

            Path testPath2 = new Path();
            testPath2.AddPoint(p3);
            testPath2.AddPoint(p2);
            testPath2.AddPoint(p1);
            PathStorage.SavePath(testPath2, "SavedTestPath2");

            // create third path and load its points from file of first path
            Path testPath3 = new Path();
            testPath3 = PathStorage.LoadPath("SavedTestPath1");

            // save third path to SavedTestPath3.txt
            PathStorage.SavePath(testPath3, "SavedTestPath3");

            // SavedTestPath3.txt should be the same as SavedTestPath1.txt

            try
            {
                testPath3 = PathStorage.LoadPath("NonExistentFile");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An expected error occurred. Error message:\n{0}", ex.Message);
            }

            //Point3D firstPoint = new Point3D(3, 4.4, 5);
            //Point3D secondPoint = new Point3D(1, 2, 3);
            //Console.WriteLine(firstPoint.ToString());
            //Console.WriteLine(secondPoint.ToString());
            //double result = CalculateDistance.TwoPoints(firstPoint, secondPoint);
            //Console.WriteLine("{0:F2}",result);
            //Path myPath = new Path();
            //myPath.AddPoint(4.5, 4, 50.8);
            //myPath.AddPoint(5, 2, 5);
            //PathStorage.SavePath(myPath, "Path1");

            //Path mySecondPath = new Path();
            //mySecondPath.AddPoint(55, 5, 555);
            //mySecondPath.AddPoint(5, 5, 5);
            //mySecondPath.AddPoint(1, 4, 6);
            //PathStorage.SavePath(mySecondPath, "Path2");
            //PathStorage.SavePath(PathStorage.LoadPath("Path2"), "againPath2");

        }
    }
}
