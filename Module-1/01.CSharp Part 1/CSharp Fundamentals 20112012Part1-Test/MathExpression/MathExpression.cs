using System;

class MathExpression
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double result = n * n + (1.0 / (m * p)) + 1337;
        result /= n - (128.523123123 * p);
        result += Math.Sin((int)(m % 180));

        Console.WriteLine("{0:0.000000}", result);

    }
}
