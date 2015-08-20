//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {

        char[] alphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                           'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        string word = Console.ReadLine();
        string wordToUpper = word.ToUpper();
        char[] wordToArray = wordToUpper.ToCharArray();
        
        for (int i = 0; i < wordToArray.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (wordToArray[i] == alphabet[j])
                {
                    Console.Write("{0} ", j);
                    break;
                }
            }
        }
        Console.WriteLine();

    }
}