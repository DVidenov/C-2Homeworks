//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.
using System;
class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Enter how you want to calculate: ");
        Console.WriteLine("To calculate with side and an altitude to it, press: 1 ");
        Console.WriteLine("To calculate with three sides press: 2");
        Console.WriteLine("To calculate with two sides and an angle between them press: 3");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            CalculateBySideAndAnAltitude();
        }
        if (n == 2)
        {
            CalculateByThreeSides();
        }
        if (n == 3)
        {
            CalculateByTwoSidesAndAnAngle();
        }
    }
    private static double CalculateBySideAndAnAltitude()
    {
        Console.WriteLine("Enter the side: ");
        double side = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the altitude: ");
        double altitude = int.Parse(Console.ReadLine());
        double A = (altitude * side) / 2;
        Console.WriteLine(A);
        return A;
    }
    private static double CalculateByThreeSides()
    {
        Console.WriteLine("Enter first side of the triangle: ");
        double first = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second side of the triangle: ");
        double second = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third side of the triangle: ");
        double third = int.Parse(Console.ReadLine());
        double surface = first + second + third;
        Console.WriteLine(surface);
        return surface;
    }
    private static double CalculateByTwoSidesAndAnAngle()
    {
        Console.WriteLine("Enter the value of first side: ");
        double first = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of second side: ");
        double second = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the angle between the two sides: ");
        double angle = int.Parse(Console.ReadLine());
        double surface = (first * second * Math.Sin(angle * Math.PI / 180));
        Console.WriteLine(surface);
        return surface;
    }
}