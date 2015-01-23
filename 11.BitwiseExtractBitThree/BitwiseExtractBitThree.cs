using System;
class BitwiseExtractBitThree
{
    // Using bitwise operators, write an expression for finding the value of the bit #3 of a given
    //unsigned integer.
    // Examples: n=5,	binary representation= 00000000 00000101,	bit #3= 0;
    //           n=0,   binary representation= 00000000 00000000,   bit #3= 0;
    static void Main()
    {
        Console.WriteLine("Please enter an number (n) :");
        int number = int.Parse(Console.ReadLine());
        int mask = 1;

        if ((mask << 3 & number) == 0)
        {
            Console.WriteLine("The value of the bit #3 is : 0");
        }
        else
        {
            Console.WriteLine("The value of the bit #3 is : 1");
        }
    }
}
