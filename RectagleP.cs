// See https://aka.ms/new-console-template for more information
using System;

namespace Mihail
    {
    class Rectangle
        {
        private double A;
        private double B;
        public Rectangle(double sideA, double sideB)
            {
            this.A = sideA;
            this.B = sideB;
            }
        private double CalculateArea()
            {
            return A * B;
            }
        private double CalculatePerimeter()
            {
            return 2 * (A + B);
            }
        public double Area
            {
            get {return CalculateArea();}                 
            }
        public double Perimeter
            {
            get {return CalculatePerimeter();}
            }
        }
    class Program
        {
        static void Main()
            {   
            double sideA = double.Parse (Console.ReadLine());           
            double sideB = double.Parse (Console.ReadLine()); 
            Rectangle rectangle = new Rectangle (sideA, sideB);
            Console.WriteLine (rectangle.Area);
            Console.WriteLine (rectangle.Perimeter);
            Console.ReadKey();
            }
        }
}
