using System;
class ThirdDigit
{
    // Write an expression that checks for given integer if its third digit from right-to-left is 7.
    // Examples: n = (5->false; 701->true; 9703->true; 877->false; 777877->false; 9999799->true).
    static void Main()
    {
        Console.Write("Please enter an number: ");
        int number = int.Parse(Console.ReadLine());
        int numberDividedByHundred = number / 100;
        int thirdDigit = Math.Abs(numberDividedByHundred % 10);
        bool isThirdDigit7 = thirdDigit == 7;
        Console.WriteLine("The third digit right to left of" + number + " is 7-> " + isThirdDigit7);
    }
}