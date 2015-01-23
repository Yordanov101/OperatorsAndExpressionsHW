using System;

class DivideBySevenAndFive
{
    // Write a Boolean expression that checks for given integer if it can be divided (without remainder)
    // by 7 and 5 at the same time.
    // Examples: (3->false; 0->false; 5->false; 7->false; 35->true; 140->true).
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        bool isDivisibleBy5And7 = ((number % 5 == 0)&&(number % 7 == 0));
        Console.WriteLine("Is this number can be divided ba 7 and 5 at same time?:" + isDivisibleBy5And7);
    }
}