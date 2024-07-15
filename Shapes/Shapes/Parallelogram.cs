namespace Shapes
{
    public class Parallelogram : Quadrilateral
    {
        public double H { get; set; }


        public Parallelogram(double a, double b, double h) : base(a,b,a,b)
        {
            H = h;
        }

        public override double GetArea()
        {
            return A * H;
        }

        public override string WhoIAm()
        {
            return "Parallelogram";
        }

      
    }
}