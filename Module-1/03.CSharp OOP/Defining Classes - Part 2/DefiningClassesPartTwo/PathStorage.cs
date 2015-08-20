namespace DefiningClassesPartTwo
{
    using System;
    using System.IO;

    static class PathStorage
    {
        public static void SavePath(Path path, string filename)
        {
           
            StreamWriter streamWriter = new StreamWriter(String.Format(@"../../{0}.txt",filename));

            using (streamWriter)
            {
                foreach (var point in path.PointsPath)
                {
                   
                    streamWriter.WriteLine("*" + point.ToString());
                }
            }
            streamWriter.Close();

        }

        public static Path LoadPath(string fileName)
        {
            Path loadedPath = new Path();
            if (!File.Exists(String.Format(@"..\..\{0}.txt", fileName)))
            {
                throw new ArgumentException("Such file does not exist!");
            }
            StreamReader streamReader = new StreamReader(String.Format(@"..\..\{0}.txt", fileName));

            using (streamReader)
            {
                string[] lanes = streamReader.ReadToEnd().Split(new[] { '*' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lanes.Length; i++)
                {
                    string[] currentLane = lanes[i].Split(new[] { ' ', 'x', 'y', 'z' }, StringSplitOptions.RemoveEmptyEntries);
                   
                    double currentPointX = double.Parse(currentLane[0]);
                    double currentPointY = double.Parse(currentLane[1]);
                    double currentPointZ = double.Parse(currentLane[2]);
                    loadedPath.AddPoint(currentPointX, currentPointY, currentPointZ);
                }
                return loadedPath;
            }
        }
    }
}
