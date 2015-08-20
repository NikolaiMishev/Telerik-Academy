
namespace _01.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(decimal width, decimal height)
            : base(width, height)
        {

        }
        public override decimal CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }
    }
}
