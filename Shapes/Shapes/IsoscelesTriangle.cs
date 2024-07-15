using System;
using System.Security.Cryptography.X509Certificates;

namespace Shapes
{
    public class IsoscelesTriangle : Triangle
    {
         double Angle { get; set; }

         public IsoscelesTriangle(double a, double angle) : base(a, a, Math.Sin(angle) / 0.5)
         {
             
         }
        

        public override string WhoIAm()
        {
            return "IsoscelesTriangle";
        }
    }
}