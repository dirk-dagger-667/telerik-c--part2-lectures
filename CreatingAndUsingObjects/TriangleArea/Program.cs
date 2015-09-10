using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

namespace TriangleArea
{
    class Program
    {
        static double CalculatingArea(double side1, double side2, double side3)
        {
            double semiparameter = (side1 + side3 + side2) / 2;
            double area = Math.Sqrt(semiparameter * (semiparameter - side1) * (semiparameter - side2) * (semiparameter - side3));
            return area;
        }

        static double CalculatingArea(double side, double altitude)
        {
            double area = 0.5 * side * altitude;
            return area;
        }

        static double CalculatingArea(double side1 , double side2, float angleBetweenSides)
        {
            double area = 0.5 * side1 * side2 * Math.Sin(180 * angleBetweenSides / Math.PI);
            return area;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1, 2 or 3\n1 - calculate area of triangle using three sides\n2 - calculate area of triangle using a side and altitude of it\n3 - calculate area of triangle using two side and the angle between them in degrees");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter the three sides");
                    double side1 = double.Parse(Console.ReadLine());
                    double side2 = double.Parse(Console.ReadLine());
                    double side3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the triangle is : {0}", CalculatingArea(side1, side2, side3));
                    break;
                case "2":
                    Console.WriteLine("Enther the side and the altitude in that order : ");
                    double side = double.Parse(Console.ReadLine());
                    double altitude = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the triangle is : {0}", CalculatingArea(side, altitude));
                    break;
                case "3":
                    Console.WriteLine("Enter the two side and the angle(in degrees) between them in that order : ");
                    double side1UsingAngle = double.Parse(Console.ReadLine());
                    double side2UsingAngle = double.Parse(Console.ReadLine());
                    float angle = float.Parse(Console.ReadLine());
                    Console.WriteLine("The area of the triangle is : {0}",CalculatingArea(side1UsingAngle, side2UsingAngle, angle));
                    break;
            }
        }
    }
}
