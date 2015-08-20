using System;

public class Printing
{
    public static void Main()
    {
        /*
          The first C# exam is coming! Help the trainers to calculate the amount of money they save for
         * not printing on paper the exam descriptions. There are N students in the academy. 
         * The number of paper sheets that should be printed for each student is S. 
         * One realm (box with paper sheets) contains exactly 500 sheets of paper. The price of one realm is P.
            You can buy part of a realm. For example if the price of a realm is 2.20
            you can buy 0.45 parts of one realm which means that you will pay 0.45 * 2.20 = 0.99.
            N, S, P should be read from the console. Output the exact total amount of money
            the trainers save for not printing the exams on paper.
            The output should be rounded with 2 digits after the decimal point.
         */

        const int RealmQuantity = 500;

        int numberoOfStudents = int.Parse(Console.ReadLine());
        int numberOfSheetsForEachStudent = int.Parse(Console.ReadLine());
        double realmPrice = double.Parse(Console.ReadLine());

        double sheetsAmmount = numberoOfStudents * numberOfSheetsForEachStudent;
        double realms = (sheetsAmmount / RealmQuantity);
        
        double moneySaved = realms*realmPrice;
        
        Console.WriteLine("{0:F2}", moneySaved);
    }
}
