using System;
class PointInACircle
{
    // Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
    // Examples:x->0, y->1,	inside =true;  x->-2, y->0, inside =true;  x->-1, y->2, inside = false.
    static void Main()
    {
        Console.WriteLine("Please enter point (x):");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter point (y):");
        int y = int.Parse(Console.ReadLine());
        {
            bool checkIsXYInside = Math.Sqrt((x * x) + (y * y)) <= 2;
            Console.WriteLine("Is that points(x,y) are inside a circle? -" +checkIsXYInside);
        }
    }
}
