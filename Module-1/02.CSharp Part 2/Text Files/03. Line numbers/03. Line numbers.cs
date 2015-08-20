﻿//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;
class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\03. Line numbers.cs");

        using (reader)
        {
            string readerLine = reader.ReadLine();

            StreamWriter newFile = new StreamWriter("..\\..\\TextWithNumberedLines.txt");

            using (newFile)
            {
                int lineCounter = 1;
                while (readerLine != null)
                {
                    newFile.WriteLine("Line {0,2} :{1}", lineCounter, readerLine);
                    lineCounter++;
                    readerLine = reader.ReadLine();
                }
            }
        }
    }
}

