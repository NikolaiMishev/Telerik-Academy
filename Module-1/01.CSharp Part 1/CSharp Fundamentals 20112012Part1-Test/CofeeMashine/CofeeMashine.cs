using System;

class CofeeMashine
{
    static void Main()
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        double coinFive = double.Parse(Console.ReadLine()) * 0.05;
        double coinTen = double.Parse(Console.ReadLine()) * 0.10;
        double coinTwenty = double.Parse(Console.ReadLine()) * 0.20;
        double coinFifty = double.Parse(Console.ReadLine()) * 0.50;
        double coinOne = double.Parse(Console.ReadLine()) * 1.00;
        double inputMoney = double.Parse(Console.ReadLine());
        double priceOfDrink = double.Parse(Console.ReadLine());

        double sumOfCoins = coinFive + coinTen + coinTwenty + coinFifty + coinOne;

        if (inputMoney < priceOfDrink)
        {
            Console.WriteLine("More {0:F2}", priceOfDrink-inputMoney);
        }
        else if (inputMoney >= priceOfDrink && sumOfCoins>=(inputMoney - priceOfDrink))
        {
            Console.WriteLine("Yes {0:F2}", sumOfCoins -(inputMoney - priceOfDrink));
        }
        else if (!(sumOfCoins >= (inputMoney - priceOfDrink)))
        {
            Console.WriteLine("No {0:F2}", inputMoney -(sumOfCoins + priceOfDrink));
        }
        
    }
}
