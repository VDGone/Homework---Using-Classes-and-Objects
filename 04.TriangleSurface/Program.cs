using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        static void Main(string[] args)
        {
            //Write methods that calculate the surface of a triangle by given:
            //Side and an altitude to it;
            //Three sides;
            //Two sides and an angle between them;
            //Use System.Math.

            Console.WriteLine("------------------------Menu-----------------------");
            Console.WriteLine("-------------------Make your choice!---------------");
            Console.WriteLine("-----Calculate surface of a triangle by given:-----");
            Console.WriteLine("-------Press 1 Side and an altitude to it;---------");
            Console.WriteLine("-------Press 2 Three sudes;------------------------");
            Console.WriteLine("-------Press 3 Two sides and an angle betwen them.-");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Choice: ");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter side: ");
                    double side = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter altitude: ");
                    double altitude = double.Parse(Console.ReadLine());
                    double surface = (side * altitude) / 2;
                    Console.WriteLine("The surface of triangle is {0:F3} sm.", surface);
                    break;
                case 2:
                    Console.WriteLine("Enter first side: ");
                    double sideA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second side: ");
                    double sideB = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter first side: ");
                    double sideC = double.Parse(Console.ReadLine());

                    double p = (sideA + sideB + sideC) / 2;

                    surface = (double)(Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)));
                    Console.WriteLine("The surface of triangle is {0:F3} sm.", surface);
                    break;
                case 3:
                    Console.WriteLine("Enter first side: ");
                    sideA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second side: ");
                    sideB = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter angle: ");
                    double angle = double.Parse(Console.ReadLine());
                    angle = (double)((Math.PI * angle) / 180);

                    surface = (double)((sideA * sideB * Math.Sin(angle)) / 2);
                    Console.WriteLine("The surface of triangle is {0:F3} sm.", surface);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
