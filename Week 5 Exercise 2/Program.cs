using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Exercise_2
{
    internal class Program
    {
        public abstract class Shape // sets up the base shape class
        {
            public abstract double CalculateArea(); // sets the calculate area method
        }
        public class Circle : Shape // sets up the circle class
        {
            public double Radius { get; } // sets radius for circle

            public Circle(double radius)
            {
                // sets radius as a variable
                Radius = radius;
            }

            public override double CalculateArea() // overrides the calculate area for the circle equation
            {
                return Math.PI * Radius * Radius; // area formula for circle
            }
        }
        public class Rectangle : Shape // sets up the rectangle class
        {
            public double Length { get; } // sets the length for rectangle
            public double Width { get; } // sets the width for rectangle

            public Rectangle(double length, double width)
            {
                // sets length and width as variables
                Length = length;
                Width = width;
            }

            public override double CalculateArea() // overrides the calculate area for the rectangle equation
            {
                return Length * Width; // area formula for rectangle
            }
        }
        public class Triangle : Shape // sets up the triangle class
        {
            public double Base { get; } // sets base for triangle
            public double Height { get; } // sets height for triangle

            public Triangle(double baseLength, double height)
            {
                // sets baselenght and height as variables
                Base = baseLength;
                Height = height;
            }

            public override double CalculateArea() // overrides the calculate area for the triangle equation
            {
                return 0.5 * Base * Height; // area formula for triangle
            }
        }
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
        {
                // sets the objects and inputs the numbers for the equation
            new Circle(4),
            new Rectangle(5, 8),
            new Triangle(2, 6)
        };

            // Starts loop to go through every shape and get the area for every shape
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.CalculateArea()}"); // writeline for the area of the shapes from the loop
            }

            Console.ReadKey();
        }
    }
}
