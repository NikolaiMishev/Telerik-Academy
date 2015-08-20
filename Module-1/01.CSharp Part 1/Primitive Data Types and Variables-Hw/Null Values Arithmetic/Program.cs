//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;
class Program
{
    static void Main()
    {
        int? nullableInt = null;
        double? nullableDouble=null;

        bool nullCheck = nullableInt == null && nullableDouble == null;

        Console.WriteLine("Int with value null:{0}\nDouble with value null:{1}\n",nullableInt,nullableDouble);
        Console.WriteLine("Int and Double are null-->{0}\n",nullCheck);

        nullableInt = 10;
        nullableDouble = 14.23;

        Console.WriteLine("Int with value:{0}\nDouble with value:{1}\n",nullableInt,nullableDouble);

        

    }
}


