using System;
class CheckABitAtPosition
{
    // Write a Boolean expression that returns if the bit at position (p) in given integer number (n), has value of 1.
    // Examples: n=5,	binary representation of n=00000000 00000101	p=2,	bit @ p == 1 is true;
    //           n=0,	binary representation of n=00000000 00000000	p=9,	bit @ p == 1 is false;
    static void Main()
    {
        Console.Write("Please enter number (n): ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position bit (p): ");
        int position = int.Parse(Console.ReadLine());
        bool checkIsOne = (number & (1 << position)) > 0;
        Console.WriteLine("Is this bit position (p) has value 1 ? - " + checkIsOne+" "  + Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
