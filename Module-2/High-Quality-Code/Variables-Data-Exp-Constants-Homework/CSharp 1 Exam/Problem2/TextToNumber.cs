using System;

public class TextToNumber
{
    public static void Main()
    {
      /*
       * You are given a text and a number (M). This text can contain digits, 
       * Latin letters (both capital and letter case) and any other symbols, except for '@'. 
       * The number is used to the parsing of the text.
          Your task is to go through all characters of the text and, starting from RESULT = 0, to perform the following operations:
          •	If the current character is '@', stop the program and print the RESULT
          •	If the current character is a digit (0-9), then multiply the RESULT by this digit
          •	If the current character is a letter, add its number from the Latin alphabet to RESULT. 'A' is with number 0
          •	If the current character is a symbol, that is different from the ones above, create module of the RESULT by the provided number (M)
       *  M will always be between 2000 and 10 000.
       */

        int number = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        int result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                break;
            }

            if (char.IsDigit(text[i]))
            {
                result *= int.Parse(text[i].ToString());
            }
            else if (char.IsLetter(text[i]))
            {
                char currentLetter = text[i];

                if (currentLetter > 90)
                {
                    currentLetter -= ' ';
                }

                result += currentLetter - 65;
            }
            else
            {
                result %= number;
            }
        }

        Console.WriteLine(result);
    }
}
