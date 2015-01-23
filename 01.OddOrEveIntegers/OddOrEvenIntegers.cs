using System;
class OddOrEvenIntegers
{
    // Write an expression that checks if given integer is odd or even.
    // examples:(3-> true); (2-> false0; (-2-> false); (-1->true); (0->false).
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        {
            bool isEven = (number % 2 == 0);
            Console.WriteLine("Is this number is Even? - " + isEven);
        }
    }
}