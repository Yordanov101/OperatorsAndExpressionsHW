using System;
class ModifyABitAtGivenPosition
{
    // We are given an integer number (n), a bit value v (v=0 or 1) and a position (p).
    // Write a sequence of operators (a few lines of C# code) that modifies (n) to hold the value (v) at 
    // the position (p) from the binary representation of (n) while preserving all other bits in (n).
    // Examples: n	binary representation of n	      p	       v	     binary result	        result
    //           5	     00000000 00000101	          2	       0        00000000 00000001          1
    //           0	     00000000 00000000	          9	       1        00000010 00000000         512
    static void Main()
    {
        Console.WriteLine("Please enter a number (n):");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a position bit (p):");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter expected  value bit(v) :");
        int value = int.Parse(Console.ReadLine());
        int mask = value << position;
        number = number & (~(1 << position));
        int result = number | mask;
        Console.WriteLine("After changes the value bit (v) on position (p) result is :" +result);

    }
}
