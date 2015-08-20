using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {

        Console.WriteLine("Enter a hexadecimal number: ");
        string hexaDecimal = Console.ReadLine();
       
        long number = 0;
        long pow = 1;

        for (int i = hexaDecimal.Length - 1; i >= 0; i--)
        {
            int sign;
            switch (hexaDecimal[i])
            {
                case 'A': sign = 10;
                    break;
                case 'B': sign = 11;
                    break;
                case 'C': sign = 12;
                    break;
                case 'D': sign = 13;
                    break;
                case 'E': sign = 14;
                    break;
                case 'F': sign = 15;
                    break;
                default: sign = hexaDecimal[i] - 48;
                    break;
            }
            number += sign * pow;
           
            pow *= 16;
        }
        Console.WriteLine(number);
    }
}
