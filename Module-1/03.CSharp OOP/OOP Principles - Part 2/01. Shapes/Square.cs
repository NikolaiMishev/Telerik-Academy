
namespace _01.Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(decimal side)
             : base(side,side)
        {

        }

        public override decimal CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
