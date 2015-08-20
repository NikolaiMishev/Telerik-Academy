//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your weigth:");
        double weight = double.Parse(Console.ReadLine());
        
        double moonGravity = 0.17;
        double weightOnMoon = weight * moonGravity;

        Console.WriteLine("Your weigth on the moon is:" + weightOnMoon);
    }
}
