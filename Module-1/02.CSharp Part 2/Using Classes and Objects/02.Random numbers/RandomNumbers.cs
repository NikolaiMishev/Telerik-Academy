﻿//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumbers
{
    static Random rand = new Random();
    static void Main()
    {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(rand.Next(100, 201));
            }
            Console.WriteLine();
    }
}
