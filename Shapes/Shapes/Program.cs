using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {


            Shape[] shapes =
            {
                new Circle(5),
                new Square(4),
                new Triangle(4,8,5)
            };
            
           
            foreach (var shape in shapes)
            {
                DisplayShapes(shape);
            }
           
            
        }

        static public void DisplayShapes(Shape shape)
        {
           
            Console.WriteLine($"Shape: {shape.WhoIAm()}");
            Console.WriteLine($"Perimeter: {shape.GetPerimeter()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
          
            
        }
    }
}
