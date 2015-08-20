namespace Task_1
{
    using System;

    public class Printer
    {
        private const int MaxCount = 6;

        public Printer()
        {
        }
        
        public void Print(bool variable)
        {
            string resultAsString = variable.ToString();

            Console.WriteLine(resultAsString);
        }
    }
}
