using System;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

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

            SimpleTriangle[] triangles =
            {
                new SimpleTriangle(4, 2),
                new SimpleTriangle(3, 5)
            };

            foreach (SimpleTriangle triangle in triangles)
            {
                triangle.printValues();
            }
        }
        //public static void CreateTriangle()
        //{
        //    Console.WriteLine("Create a triangle\n");
        //    Console.WriteLine("If value is unknown write 0\n");

        //    double sideA = 0;
        //    double sideB = 0;
        //    double sideC = 0;
        //    double angleA = 0;
        //    double angleB = 0;
        //    double angleC = 0;

        //    bool doLoop = true;

        //    bool hasOneSide = false;
        //    bool hasTwoSide = false;
        //    bool hasThreeSide = false;
        //    bool hasOneAngle = false;
        //    bool hasTwoAngle = false;

        //    bool correctAmountOfInput = false;
        //    bool correctAngle = false;
        //    bool correctSide = false;

        //    do {
        //        // Get all the values
        //        do { Console.WriteLine("Side A: "); }
        //        while (!double.TryParse(Console.ReadLine(), out sideA));

        //        do { Console.WriteLine("Side B: "); }
        //        while (!double.TryParse(Console.ReadLine(), out sideB));

        //        do { Console.WriteLine("Side C: "); }
        //        while (!double.TryParse(Console.ReadLine(), out sideC));

        //        do { Console.WriteLine("Angle A: "); }
        //        while (!double.TryParse(Console.ReadLine(), out angleA));

        //        do { Console.WriteLine("Angle B: "); }
        //        while (!double.TryParse(Console.ReadLine(), out angleB));

        //        do { Console.WriteLine("Angle C: "); }
        //        while (!double.TryParse(Console.ReadLine(), out angleC));

        //        // Check how many sides the triangle has
        //        if (sideA != 0 || sideB != 0 || sideC != 0) { hasOneSide = true; }
        //        if (sideA != 0 && sideB != 0 || sideA != 0 && sideC != 0 || sideB != 0 && sideC != 0) { hasTwoSide = true; }
        //        if (sideA != 0 && sideB != 0 && sideC != 0) { hasThreeSide = true; }

        //        // Check how many angles the triangle has
        //        if (angleA != 0 || angleB != 0 || angleC != 0) { hasOneAngle = true; }
        //        if (angleA != 0 && angleB != 0 || angleA != 0 && angleC != 0 || angleB != 0 && angleC != 0) { hasTwoAngle = true; }

        //        // Check if the triangle has the correct amount of minimum inputs
        //        if (hasThreeSide) { correctAmountOfInput = true; }
        //        else if (hasTwoSide && hasOneAngle) { correctAmountOfInput = true; }
        //        else if (hasOneSide && hasTwoAngle) { correctAmountOfInput = true; }
                
        //        // Check if the sum of two sides is not equal or less than the third side
        //        if (sideA + sideB !<= sideC + sideC ||
        //            sideA + sideC !<= sideB + sideB ||
        //            sideB + sideC !<= sideA + sideA) { correctSide = true; }

        //        // Check if all of the sides are the same length, this is an exeption to the if statement above
        //        if (sideA == sideB && sideC == sideA) { correctSide = true; }

        //        // Check so all the angles combined is not more then 180 degrees
        //        if (angleA + angleB + angleC !> 180) { correctAngle = true; }

        //        // Check if the angles are correct and the sides are correct and the amount of inputs are correct
        //        if (correctAngle && correctSide || correctAmountOfInput) { doLoop = false; }

        //    } while (doLoop);

        //}
    }

    // Create another class called AdvancedTriangle - WIP
    public class AdvancedTriangle
    {
        private float sideA { get; set; }
        private float sideB { get; set; }
        private float sideC { get; set; }
        private double angleA { get; set; }
        private double angleB { get; set; }
        private double angleC { get; set; }

        public AdvancedTriangle(float sideA, float sideB, float sideC, double angleA, double angleB, double angleC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.angleA = angleA;
            this.angleB = angleB;
            this.angleC = angleC;
        }

        public void getAngleA() {
            double formula = 0;

            // get valie from, sideA, sideB and sideC
            if (this.sideA != 0 && this.sideB != 0 && this.sideC != 0)
            {
                formula = Math.Acos(
                ((Math.Pow(this.sideC, 2)) + (Math.Pow(this.sideB, 2)) - (Math.Pow(this.sideA, 2)))
                / (2 * this.sideC * this.sideB));
            }

            // get value from, sideA, sideB and angleB
            if (this.sideA != 0 && this.sideB != 0 && this.angleB != 0)
            { formula = Math.Asin((this.sideA * Math.Sin(this.angleB)) / this.sideB); }

            // get value from, sideC, sideA and angleC
            if (this.sideC != 0 && this.sideA != 0 && this.angleC != 0)
            { formula = Math.Asin((this.sideA * Math.Sin(this.angleC)) / this.sideC); }

            // get value from, angleC and angleB
            if (this.angleC != 0 && this.angleB != 0)
            { formula = 180 - this.angleC - this.angleB; }

            if (formula != 0) { this.angleC = formula; }
        }

        public void getAngleB() {
            double formula = 0;

            // get valie from, sideA, sideB and sideC
            if (this.sideA != 0 && this.sideB != 0 && this.sideC != 0)
            {
                formula = Math.Acos(
                ((Math.Pow(this.sideC, 2)) + (Math.Pow(this.sideA, 2)) - (Math.Pow(this.sideB, 2)))
                / (2 * this.sideC * this.sideA));
            }

            // get value from, sideA, sideB and angleA
            if (this.sideA != 0 && this.sideB != 0 && this.angleA != 0)
            { formula = Math.Asin((this.sideB * Math.Sin(this.angleA)) / this.sideA); }

            // get value from, sideC, sideB and angleA
            if (this.sideC != 0 && this.sideB != 0 && this.angleC != 0)
            { formula = Math.Asin((this.sideB * Math.Sin(this.angleC)) / this.sideC); }

            // get value from, angleA and angleC
            if (this.angleA != 0 && this.angleC != 0)
            { formula = 180 - this.angleA - this.angleC; }

            if (formula != 0) { this.angleC = formula; }
        }

        public void getAngleC() {
            double formula = 0;

            // get valie from, sideA, sideB and sideC
            if (this.sideA != 0 && this.sideB != 0 && this.sideC != 0) { 
                formula = Math.Acos(
                ((Math.Pow(this.sideA, 2)) + (Math.Pow(this.sideB, 2)) - (Math.Pow(this.sideC, 2)))
                / (2 * this.sideA * this.sideB));
            } 

            // get value from, sideC, sideB and angleB
            if (this.sideC != 0 && this.sideB != 0 && this.angleB != 0) 
            { formula = Math.Asin((this.sideC * Math.Sin(this.angleB)) / this.sideB); }

            // get value from, sideC, sideA and angleA
            if (this.sideC != 0 && this.sideA != 0 && this.angleA != 0)
            { formula = Math.Asin((this.sideC * Math.Sin(this.angleA)) / this.sideA); }

            // get value from, angleA and angleB
            if (this.angleA != 0 && this.angleB != 0)
            { formula = 180 - this.angleA - this.angleB; }

            if (formula != 0) { this.angleC = formula; }
        }
        public void getSideA()
        {
            double formula = 0;

            // get sideA if we know sideB, sideC and angleA
            if (this.sideB != 0 && this.sideC != 0 && this.angleA != 0) {
                formula = Math.Sqrt(
                Math.Pow(this.sideB, 2) + Math.Pow(this.sideC, 2) - (2 * this.sideB * this.sideC) * Math.Cos(this.angleA));
            }

            // get value if we know sideC, angleA and angleC
            if (this.sideC != 0 && this.angleA != 0 && this.angleC != 0) {
                formula = ((this.sideC * Math.Sin(this.angleA)) / Math.Sin(this.angleC));
            }

            // get value if we know sideB, angleA and angleB
            if (this.sideB != 0 && this.angleA != 0 && this.angleB != 0)
            {
                formula = this.sideB * Math.Sin(this.angleA) / Math.Sin(this.angleB);
            }   
        }

        public void getSideB()
        {
            double formula = 0;

            // get value if we know sideB, sideC and angleA
            if (this.sideB != 0 && this.sideC != 0 && this.angleA != 0)
            {
                formula = Math.Sqrt(
                Math.Pow(this.sideB, 2) + Math.Pow(this.sideC, 2) - (2 * this.sideB * this.sideC) * Math.Cos(this.angleA));
            }

            
        }


    }

    // Create another class called SimpleTriangle
    public class SimpleTriangle
    {
        private double height { get; set; }
        private double width { get; set; }

        public SimpleTriangle(double height, double width)
        {
            this.height = height;
            this.width = width; 
        }

        public double getArea() {
            return (this.height * this.width) / 2;
        }

        // Write out the values from each function in console
        public void printValues()
        {
            Console.WriteLine("Triangle");
            Console.WriteLine("Width: {0}", this.width);
            Console.WriteLine("Height: {0}", this.height);
            Console.WriteLine("Area: {0}", getArea());
            Console.WriteLine();
        }
    }

    // Create another class called Sphere
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
