
namespace _01.Shapes
{
    using System;

    public abstract class Shape
    {
        private decimal width;

        private decimal height;

        public Shape(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }

        public decimal Width 
        {
            get { return this.width; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                this.width = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                this.height = value;
            }
        }

        public abstract decimal CalculateSurface();
        
    }
}
