using System;
class GravitationOnTheMoon
{
    // The gravitational field of the Moon is approximately 17% of that on the Earth.
    // Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
    // Examples: weight (86; 74.6; 53.7), weight on the Moon (14.62; 12,682; 9.129).
    static void Main()
    {
        Console.WriteLine("Please enter a weight:");
        double weightOnEarth = double.Parse(Console.ReadLine());
        {
            double weightOnMoon = (weightOnEarth * 0.17);
            Console.WriteLine("Weight on the Moon is:"+ weightOnMoon);
        }
    }
}
