using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncodeAndDecode
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter text to decode: ");
            string text = Console.ReadLine();
            Console.Write("Enter key: ");
            string key = Console.ReadLine();

            char[] charArr = text.ToCharArray();

            for (int i = 0, j = 0; i < charArr.Length; i++, j++)
            {
                if (j == key.Length - 1)
                {
                    j = 0;
                }
                charArr[i] ^= key[j];


            }
            text = new string(charArr);
            Console.WriteLine(text);
        }
    }
}
