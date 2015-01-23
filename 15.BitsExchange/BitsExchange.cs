using System;
class BitsExchange
{
    // Program that exchanges bits 3,4 and 5 with bits 24,25 and 26 of given 32-bit unsigned integer.
    //      n	    binary representation of n	         binary result	               result
    // 1140867093	01000100 00000000 01000000 	   01000010 00000000 01000000 	     1107312677
    //                     00010101                         00100101
    static void Main()
    {
        Console.WriteLine("Please enter a number (n): ");
        uint number = uint.Parse(Console.ReadLine());
        for (int i = 3; i <= 5; i++)
        {
            uint bitOne = (uint)(number >> i) & 1;
            uint bitTwo = (uint)(number >> (21 + i)) & 1;
            number = (uint)(number & (~(1 << (21 + i))) | (bitOne << (21 + i)));
            number = (uint)(number & (~(1 << i)) | (bitTwo << i));
        }
        Console.WriteLine("After change bits 3,4 and 5 with bits 24,25 and 26 the number is " +number+ " binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
