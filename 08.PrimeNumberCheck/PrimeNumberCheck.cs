using System;
class PrimeNumberCheck
{
    // Write an expression that checks if given positive integer number n (n <= 100) is prime 
    // (i.e. it is divisible without remainder only to itself and 1).
    //Examples: n=1-> Prime? = falce;       n=2-> Prime? = true;      n=3-> Prime? = true;
    static void Main()
    {
        Console.Write("Please enter an positive integer number:");
        int number = int.Parse(Console.ReadLine());
        bool check = true;
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                check = false;
            }
        }
        if (check)
        {
            Console.WriteLine(number + " is prime.");
        }
        else
        {
            Console.WriteLine(number + " is not prime.");
        }
    }
}
