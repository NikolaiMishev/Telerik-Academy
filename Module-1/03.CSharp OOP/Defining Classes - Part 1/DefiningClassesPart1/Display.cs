namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Display
    {
        private double? size;
        private int? numberOfColors;

        public Display()
        {
            this.Size = null;
            this.NumberOfColors = null;
        }

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double? Size
        {
            get 
            { 
                return this.size; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Display height must be at least zero.");
                }

                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get 
            { 
                return this.numberOfColors; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Display colors must be at least zero.");
                }

                this.numberOfColors = value;
            }
        }
    }
}
