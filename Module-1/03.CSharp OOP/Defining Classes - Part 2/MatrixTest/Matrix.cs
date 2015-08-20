namespace MatrixTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Matrix<T> where T : IComparable
    {
        private T[,] matrix;

        private int row;

        private int col;

        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.matrix = new T[row, col];
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || col < 0)
                {
                    throw new IndexOutOfRangeException("Rows and Cols cant be negative number!!!!!!!");

                }
                return this.matrix[row, col];
            }
            set
            {
                if (row < 0 || col < 0)
                {
                    throw new IndexOutOfRangeException("Rows and Cols cant be negative number!!!!!!!");

                }
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if ((m1.matrix.GetLength(0) != m2.matrix.GetLength(0)) ||
                (m1.matrix.GetLength(1) != m2.matrix.GetLength(1)))
            {
                throw new ArgumentException("The matrix's sizes are not equal!!!");
            }
            Matrix<T> result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));

            for (int row = 0; row < result.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < result.matrix.GetLength(1); col++)
                {
                    result[row, col] = (dynamic)m1[row, col] + m2[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if ((m1.matrix.GetLength(0) != m2.matrix.GetLength(0)) ||
                (m1.matrix.GetLength(1) != m2.matrix.GetLength(1)))
            {
                throw new ArgumentException("The matrix's sizes are not equal!!!");
            }
            Matrix<T> result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));

            for (int row = 0; row < result.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < result.matrix.GetLength(1); col++)
                {
                    result[row, col] = (dynamic)m1[row, col] - m2[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0) != m2.matrix.GetLength(1) ||
                m1.matrix.GetLength(1) != m2.matrix.GetLength(0))
            {
                throw new ArgumentException("Those matrix's are not able to multiply!");
            }
            Matrix<T> result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(0));

            for (int row = 0; row < result.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < result.matrix.GetLength(1); col++)
                {
                   
                    for (int i = 0; i < m2.matrix.GetLength(0); i++)
                    {
                        result[row, col] += (dynamic)m1[row, i] * m2[i, col];
                    }
                    
                }
            }
            return result;
        }

        public static bool operator true(Matrix<T> m)
        {
            for (int row = 0; row < m.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < m.matrix.GetLength(1); col++)
                {
                    if ((dynamic)m[row, col] != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> m)
        {
            for (int row = 0; row < m.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < m.matrix.GetLength(1); col++)
                {
                    if ((dynamic)m[row, col] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    result.Append(this.matrix[row, col] + " ");
                }
                result.AppendLine();
            }
            return result.ToString();
        }
    }
}
