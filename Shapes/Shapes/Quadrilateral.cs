namespace Shapes
{
  public abstract class Quadrilateral : Shape 
    {
         public  double A { get; set; }
         public  double B { get; set; }
         public double C { get; set; }
         public double D { get; set; }

         public Quadrilateral(double a, double b, double c, double d)
         {
             A = a;
             B = b;
             C = c;
             D = d;
         }

         public override double GetPerimeter()
         {
             return A + B + C + D;
         }

       
    }
}