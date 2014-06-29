// 8. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

// 9. Implement an indexer this[row, col] to access the inner matrix cells.

// 10. Implement the operators + and - (addition and subtraction of matrices of the same size)
// and * for matrix multiplication. Throw an exception when the operation cannot be performed.
// Implement the true operator (check for non-zero elements).

namespace Matrix
{
    using System;
    using System.Linq;

    internal class Test
    {
        private static readonly Random rnd = new Random();

        private static void Main()
        {
            try
            {
                // create 2 new matrices
                Matrix<int> first = new Matrix<int>(4, 3);
                Matrix<int> second = new Matrix<int>(4, 3);

                // add various values to the matrices
                AddRandomValues(first);
                AddRandomValues(second);

                // print initial matrices
                Print(first);
                Print(second);

                // sum of matrices
                var sum = first + second;
                Print(sum);

                // subtraction of matrices
                var result = first - second;
                Print(result);

                // multiplication of matrices 
                var multiplication = first * second;
                Print(multiplication);
            }
            catch (IndexOutOfRangeException iex)
            {
                Console.WriteLine(iex.Message);
            }
            catch (InvalidOperationException ex)
            { 
                Console.WriteLine(ex.Message); 
            }
        }

        private static void AddRandomValues(Matrix<int> matr)
        {
            for (int i = 0; i < matr.Rows; i++)
            {
                for (int j = 0; j < matr.Cols; j++)
                {
                    matr[i, j] = rnd.Next(0, 10);
                }
            }
        }

        private static void Print(Matrix<int> matr)
        {
            for (int i = 0; i < matr.Rows; i++)
            {
                for (int j = 0; j < matr.Cols; j++)
                {
                    Console.Write("{0,5}", matr[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}