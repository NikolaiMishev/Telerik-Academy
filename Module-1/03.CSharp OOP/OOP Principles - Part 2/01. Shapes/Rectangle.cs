
namespace _01.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(decimal width, decimal height)
            : base(width, height)
        {

        }
        public override decimal CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
