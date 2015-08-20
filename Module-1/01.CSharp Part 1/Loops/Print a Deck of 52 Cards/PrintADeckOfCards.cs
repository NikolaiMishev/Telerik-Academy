//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class PrintADeckOfCards
{
    static void Main()
    {
        string[] deck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        for (int i = 0; i < deck.Length; i++)
        {
            for (int suit = 0; suit < 4; suit++)
            {
                switch (suit)
                {
                    case 0:
                        Console.Write(deck[i] + " of spades, ");
                        break;
                    case 1:
                        Console.Write(deck[i] + " of clubs, ");
                        break;
                    case 2:
                        Console.Write(deck[i] + " of hearts, ");
                        break;
                    case 3:
                        Console.Write(deck[i] + " of diamonds, ");
                        break;

                }

            }
            Console.WriteLine();
        }

    }
}