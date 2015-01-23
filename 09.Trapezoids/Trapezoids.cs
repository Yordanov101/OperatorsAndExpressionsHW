using System;
class Trapezoids
{
    // Write an expression that calculates trapezoid's area by given sides (a) and (b) and height (h).
    // Examples:(a=5,b=7,h=12, area=72); (a=2,b=1,h=33, area=49.5);  (a=8.5,b=4.3,h=2.7, area=17.28).
    static void Main()
    {
        Console.Write("Please enter side (a): ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Please enter side (b): ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Please enter height (h): ");
        double heightH = double.Parse(Console.ReadLine());
        double trapezoidArea = (sideA + sideB)*heightH /2;
        Console.WriteLine("The area of a trapezoid with  this sides is: " + trapezoidArea);
    }
}
