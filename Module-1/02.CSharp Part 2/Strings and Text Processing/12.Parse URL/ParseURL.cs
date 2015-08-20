//Write a program that parses an URL address given in the format: 
//[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ParseURL
{
    static void Main()
    {
        string URL = "http://telerikacademy.com/Courses/Courses/Details/212";

        var fragments = Regex.Match(URL, "(.*)://(.*?)/(.*)").Groups;
        Console.WriteLine("URL Address: {0}", URL);
        Console.WriteLine("\n[protocol] = {0}", fragments[1]);
        Console.WriteLine("[server] = {0}", fragments[2]);
        Console.WriteLine("[resource] = {0}\n", fragments[3]);
    }
}