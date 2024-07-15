namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(double a) : base(a,a)
        {
            
        }

        public override string WhoIAm()
        {
            return "Square";
        }
    }
}