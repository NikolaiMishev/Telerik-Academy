//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.

using System;
using System.Collections.Generic;
using System.Linq;

class AddingPolynomals
{
    static void Main()
    {
                              //X^2 X^1 c      
        decimal[] polynomOne = { 1, 2, 0 };
                               //X^3 X^2 X^1 c
        decimal[] polynomeTwo = { 0, -2, 14, 7 , 0 , 10 };

        PrintPolynom(AddPolynoms(polynomOne, polynomeTwo));

    }

    static decimal[] AddPolynoms(decimal[] pol1, decimal[] pol2)
    {
        if (pol2.Length > pol1.Length)
        {
            return AddPolynoms(pol2, pol1);
        }

        decimal[] result = pol1;

        for (int i = 0; i < pol2.Length; i++)
        {
            result[i] += pol2[i];
        }
     
        return result;
    }

    static void PrintPolynom(decimal[] pol)
    {
        
        for (int i = pol.Length-1; i >= 0 ; i--)
        {
            if (i != 0 && i != 1)
            {
                Console.Write("{0}X^{1} + ", pol[i], i);
            }
            else if (i == 0)
            {
                Console.WriteLine(pol[i]);
            }
            else if( i == 1)
            {
                Console.Write("{0}X + ", pol[i]);
            }
        }
    }
}