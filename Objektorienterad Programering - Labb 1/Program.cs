using System;

namespace Objektorienterad_Programering___Labb_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of circles
            Circle[] circles = { 
                new Circle(5d), 
                new Circle(6d) 
            };

            // Loop through all of the circles 
            foreach (Circle circle in circles)
            {
                // Write out the area of each circle
                Console.WriteLine(circle.getArea());
            }   
        }
    }

    // Create another class called Circle
    public class Circle
    {
        // Instantiate variables
        private double radius { get; set; }

        // Create the constructor 
        public Circle(double radius)
        {
            // Assign radius to the class variable radius
            this.radius = radius;
        }

        // Create a function called "getArea" 
        public double getArea()
        {
            // Return the area of the circle
            return (Math.PI * this.radius * this.radius);
        }
    }
}
