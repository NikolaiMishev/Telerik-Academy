
namespace _05._64_Bit_array
{
    using System;

    public class ProgramMain
    {
        static void Main()
        {

            BitArray arr = new BitArray(7);
            BitArray arr2 = new BitArray(8u);

            Console.WriteLine(arr);
            Console.WriteLine(arr.GetType());
            Console.WriteLine(arr.Number);

           
            Console.WriteLine(arr == arr2);
            Console.WriteLine(arr.Equals(arr));
            Console.WriteLine(arr != arr2);

            Console.WriteLine();
        }
    }
}
