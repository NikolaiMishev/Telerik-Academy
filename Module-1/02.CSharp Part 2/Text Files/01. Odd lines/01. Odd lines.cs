//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
class OddLines
{
    static void Main()
    {
        StreamReader read = new StreamReader("..//..//01. Odd lines.cs");
        using (read)
        {
            int lineCount = 1;
            string line = read.ReadLine();
            while (line!=null)
            {
                if (lineCount%2==0)
                {
                    Console.WriteLine("Line {0}: {1}", lineCount, line);

                }
                lineCount++;
                line = read.ReadLine();
            }
        }
    }
}

