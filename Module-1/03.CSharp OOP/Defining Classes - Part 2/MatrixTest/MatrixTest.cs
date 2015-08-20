namespace MatrixTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MatrixTest
    {
        static void Main()
        {
            Matrix<int> firstMatrix = new Matrix<int>(3, 3);
            firstMatrix[0, 0] = 1;
            firstMatrix[0, 1] = 2;
            firstMatrix[0, 2] = 3;
            firstMatrix[1, 0] = 4;
            firstMatrix[1, 1] = 5;
            firstMatrix[1, 2] = 6;
            firstMatrix[2, 0] = 7;
            firstMatrix[2, 1] = 8;
            firstMatrix[2, 2] = 9;

            Matrix<int> secondMatrix = new Matrix<int>(3, 3);
            secondMatrix[0, 0] = 10;
            secondMatrix[0, 1] = 11;
            secondMatrix[0, 2] = 12;
            secondMatrix[1, 0] = 13;
            secondMatrix[1, 1] = 14;
            secondMatrix[1, 2] = 15;
            secondMatrix[2, 0] = 16;
            secondMatrix[2, 1] = 17;
            secondMatrix[2, 2] = 18;

            Console.WriteLine("First matrix: \r\n{0}", firstMatrix);
            Console.WriteLine("Second matrix: \r\n{0}", secondMatrix);

            Matrix<int> contactedMatrix = firstMatrix + secondMatrix;
            Console.WriteLine("Concatenated matrix: \r\n{0}", contactedMatrix);

            Matrix<int> subtractMatrix = firstMatrix - secondMatrix;
            Console.WriteLine("Subtracted matrix: \r\n{0}", subtractMatrix);

            Matrix<int> multiMatrix = firstMatrix * secondMatrix;
            Console.WriteLine("Multiplied matrix: \r\n{0}", multiMatrix);

            var hasZero = firstMatrix ? false : true;
            Console.WriteLine("First Matrix has zeroes: {0}", hasZero);
        }
    }
}
