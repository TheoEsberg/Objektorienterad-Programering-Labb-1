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
                // Call "printValues" in circle to print out all the values
                circle.printValues();
            }

            // Create an array of circles
            Sphere[] spheres = {
                new Sphere(7d),
                new Sphere(6d)
            };

            // Loop through all of the circles 
            foreach (Sphere sphere in spheres)
            {
                // Call "printValues" in circle to print out all the values
                sphere.printValues();
            }


        }
    }

   
    public class Sphere
    {
        // Instantiate variables
        private double radius { get; set; }

        // Create the constructor 
        public Sphere(double radius)
        {
            this.radius = radius;
        }

        // Write out the values from each function in console
        public void printValues()
        {
            Console.WriteLine("Sphere");
            Console.WriteLine("Radius: {0}", radius);
            Console.WriteLine("Area: {0}", getArea());
            Console.WriteLine("Circumference: {0}", getCircumference());
            Console.WriteLine("Volume: {0}", getVolume());
            Console.WriteLine();
            
        }

        // Create a function called "getVolume"
        public double getVolume()
        {
            // Calculate the volume of the sphere
            double volume = (4 * Math.PI * Math.Pow(this.radius, 3) / 3);

            // Return the volume of the sphere
            return volume;
        }

        // Create a function called "getArea" 
        public double getArea()
        {
            // Calculate the area of the sphere
            double volume = (4 * Math.PI * Math.Pow(this.radius, 2));

            // Return the area of the sphere
            return volume;
        }

        // Createa a function called "getCircumference"
        public double getCircumference()
        {
            // Return the circumference of the circle
            return ((2 * radius) * Math.PI);
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

        // Write out the values from each function in console
        public void printValues()
        {
            Console.WriteLine("Circle");
            Console.WriteLine("Radius: {0}", radius);
            Console.WriteLine("Area: {0}", getArea());
            Console.WriteLine("Circumference: {0}", getCircumference());
            Console.WriteLine();
        }

        // Create a function called "getArea" 
        public double getArea()
        {
            // Return the area of the circle
            return (Math.PI * Math.Pow(radius, 2));
        }

        // Createa a function called "getCircumference"
        public double getCircumference()
        {
            // Return the circumference of the circle
            return ((2 * radius) * Math.PI);
        }
    }
}
