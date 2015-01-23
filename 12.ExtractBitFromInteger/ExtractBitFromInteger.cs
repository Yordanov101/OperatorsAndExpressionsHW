using System;
class ExtractBitFromInteger
{
    // Write an expression that extracts from given integer n the value of given bit at index p.
    // Examples: n=5,	binary representation=00000000 00000101,	p=2,	bit @ p=1;
    //           n=0,	binary representation=00000000 00000000,	p=9,	bit @ p=0;
    static void Main()
    {
        Console.WriteLine("Please enter number (n):");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter position bit (p):");
        int position = int.Parse(Console.ReadLine());
        int maskNumber = 1;
        int mask = maskNumber << position;
        int result = number & mask;
        if (result == 0)
        {
            Console.WriteLine("Value bit on position "+position+ " for this number is : 0");
        }
        else
        {
            Console.WriteLine("Value bit on position " + position + " for this number is : 1");
        }

    }
}