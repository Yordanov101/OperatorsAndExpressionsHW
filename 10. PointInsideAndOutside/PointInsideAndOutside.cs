using System;
class PointInsideAndOutside
{
    // Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
    // and out of the rectangle R(top=1, left=-1, width=6, height=2).
    // Examples:(x=1,y=2, inside K & outside of R=yes); (x=2.5,y=2, inside K & outside of R=no); 
    static void Main()
    {
        Console.Write("Please enter coordinate (x):");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter coordinate (y):");
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = ((1-x) * (1-x)) + ((1-y) * (1-y)) <= (1.5 * 1.5);
        bool isOutOfRect = x > 1 && x <= 5 && y > -1 && y <= 1;
        if (isInCircle== true && isOutOfRect== false)
        {
            Console.WriteLine("Inside K & outside of R ? - Yes");
        }
        else
        {
            Console.WriteLine("Inside K & outside of R ? - No");
        }
    }
}
