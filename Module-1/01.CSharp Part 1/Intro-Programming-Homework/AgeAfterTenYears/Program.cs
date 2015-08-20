﻿// Problem 15.* Age after 10 Years
// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.


using System;

class AgeAftertenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday(dd.mm.yyyy):");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;

        int age;
        age = now.Year - birthday.Year;

        if (birthday.Month <= now.Month)
        {
            if (birthday.Day > now.Day)
            {
                Console.WriteLine("Now you are {0} and after 10 years you will be {1}", age - 1, age + 9);
            }
            else
                Console.WriteLine("Now you are {0} and after 10 years you will be {1}", age, age + 10);

        }
        else 
        {
            Console.WriteLine("Now you are {0} and after 10 years you will be {1}", age-1, age + 9);
        }
    }
}
