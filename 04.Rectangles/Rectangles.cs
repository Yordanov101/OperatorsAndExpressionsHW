using System;
class Rectangles
{
    // Write an expression that calculates rectangle’s perimeter and area by given width and height.
    // width:(3; 2.5; 5), height:(4; 3; 5), perimeter:(14; 11; 20), area:(12; 7.5; 25).
    static void Main()
    {
        Console.WriteLine("Enter widht rectangle's:");
        double a = double.Parse(Console.ReadLine());
        {
            Console.WriteLine("Enter height rectangle's:");
            double b = double.Parse(Console.ReadLine());
            {
                double perimeter = (a + b) * 2;
                double area = a * b;
                Console.WriteLine("The perimeter of rectangle's is :" + perimeter);
                Console.WriteLine("The area of rectangle's is :" + area);
            }
        }
    }
}