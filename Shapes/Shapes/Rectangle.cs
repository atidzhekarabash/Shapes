namespace Shapes
{
    public class Rectangle : Parallelogram
    {
        public Rectangle(double a, double b) : base(a,a,b)
        {
            
        }

        public override double GetArea()
        {
            return A * A;
        }

        public override string WhoIAm()
        {
            return "Rectanle";
        }
    }
}