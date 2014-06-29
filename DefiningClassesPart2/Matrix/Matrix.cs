namespace Matrix
{
    using System;

    public class Matrix<T> where T : IComparable<T>
    {
        // fields
        private readonly T[,] matrix;

        // constructor
        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        // get rows 
        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        // get cols
        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        // indexation
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException("Index is out of range!");
                }

                return this.matrix[row, col];
            }

            set
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException("Index is out of range!");
                }

                this.matrix[row, col] = value;
            }
        }

        // predefining operators
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows == second.Rows && first.Cols == second.Cols)
            {
                Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

                for (int row = 0; row < first.Rows; row++)
                {
                    for (int col = 0; col < first.Cols; col++)
                    {
                        result[row, col] = (dynamic)first[row, col] + (dynamic)second[row, col];
                    }
                }

                return result;
            }
            else
            {
                throw new InvalidOperationException("Matrix should have equal rows and cols to be summed.");
            }
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows == second.Rows && first.Cols == second.Cols)
            {
                Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

                for (int row = 0; row < first.Rows; row++)
                {
                    for (int col = 0; col < first.Cols; col++)
                    {
                        result[row, col] = (dynamic)first[row, col] - (dynamic)second[row, col];
                    }
                }

                return result;
            }
            else
            {
                throw new InvalidOperationException("Matrix should have equal rows and cols to be subtracted.");
            }
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Cols == second.Rows)
            {
                Matrix<T> result = new Matrix<T>(first.Rows, second.Cols);

                for (int row = 0; row < result.Rows; row++)
                {
                    for (int col = 0; col < result.Cols; col++)
                    {
                        result[row, col] = (dynamic)first[row, col] * (dynamic)second[row, col];
                    }
                }

                return result;
            }
            else
            {
                throw new InvalidOperationException("One matrix should have count of rows equal to the other matrix count of cols");
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool isNotZero = true;

            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col].Equals(0))
                    {
                        isNotZero = false;
                    }
                }
            }

            return isNotZero;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool isNotZero = true;

            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col].Equals(0))
                    {
                        isNotZero = false;
                    }
                }
            }

            return isNotZero;
        }
    }
}