using System;

namespace Shapes
{
   public class Circle : Shape
    {
        double R { get; set; }


        public Circle(double r)
        {
            R = r;
        }

        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        public override string WhoIAm()
        {
            return "Circle";
        }

    }
}