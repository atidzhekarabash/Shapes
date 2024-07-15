namespace Shapes
{
    public class Rhombus : Parallelogram
    {
        public Rhombus(double a, double ha) : base(a,a,ha)
        {
            
        }

        public override string WhoIAm()
        {
            return "Rhombus";
        }

    }
}