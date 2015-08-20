﻿//Problem 7. Replace sub-string

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).
using System;
using System.IO;

class ReplaceSubString
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter("..//..//Finish.txt");
        using (writer)
        {
            StreamReader reader = new StreamReader("..//..//Start.txt");
            using (reader)
            {
                string readfile = reader.ReadLine();
                while (readfile != null)
                {
                    writer.WriteLine(readfile.Replace("start", "finish"));
                    readfile = reader.ReadLine();
                }
            }
        }
    }
}

