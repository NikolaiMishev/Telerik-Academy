namespace _01.Class_Size
{
    using System;

    public class Figure
    {
        private double width;

        private double height;

        public Figure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height should not" + " be negative");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height should not" + " be negative");
                }

                this.width = value;
            }
        }

        public static Figure GetRotatedSize(Figure figure, double angleOfrotation)
        {
            double sinusTWidth = Math.Abs(Math.Sin(angleOfrotation)) * figure.Width;
            double cosinusTWidth = Math.Abs(Math.Cos(angleOfrotation)) * figure.Width;
            double sinusTHeight = Math.Abs(Math.Sin(angleOfrotation)) * figure.Height;
            double cosinusTHeight = Math.Abs(Math.Cos(angleOfrotation)) * figure.Height;

            double rotatedFigureWidth = cosinusTWidth + sinusTHeight;
            double rotatedFigurHeight = sinusTWidth + cosinusTHeight;

            Figure rotatedFigure = new Figure(rotatedFigureWidth, rotatedFigurHeight);

            return rotatedFigure;
        }
    }
}
