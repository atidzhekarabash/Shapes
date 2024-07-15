using System;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace Shapes
{
   public  class Triangle : Shape
    {
         double A { get; set; } 
         double B { get; set; }
         double C { get; set; }

         public Triangle(double a, double b, double c) 
         {
             A = a;
             B = b;
             C = c;
         }

         public override double GetPerimeter() 
         {
             return A + B + C;
         }

         public override double GetArea()
         {
             double p = GetPerimeter() / 2;
             return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
         }

         public override string WhoIAm()
         {
             return "Triangle";
         }

    }
}