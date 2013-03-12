using System;

public class Matrix<T>
    where T : IComparable<T>
{
    //field for Matrix Class
    private readonly T[,] matrix;
    private int row;
    private int col;
 
    //constructor 
    public Matrix( int rows, int cols)
    {
        this.row = rows;
        this.col = cols;
        this.matrix = new T[this.row, this.col];
    }

    //property row
    public int Row
    {
        get { return this.row; }
    }

    //property col
    public int Col
    {
        get { return this.col; }
    }

    //indexer this[row, col] to access the inner matrix cells.
    public T this[int row, int col]
    {
        get
        {
            if (row < 0 || row >= Row || col < 0 || col >= Col)
            {
                throw new IndexOutOfRangeException("Incorrect size of matrix");
            }
            else
            {
                return matrix[row, col];
            }
        }

        set
        {
            if (row < 0 || row >= Row || col < 0 || col >= Col)
            {
                throw new IndexOutOfRangeException("Incorrect size of matrix");
         
            }
            else
            {
                matrix[row, col] = value;
            }
        }
    }

    //addition  of matrices of the same size
    public static Matrix<T> operator +(Matrix<T> rowLenght, Matrix<T> ColLenght)
    {
        if (rowLenght.Row == ColLenght.Row && rowLenght.Col == ColLenght.Col)
        {
            Matrix<T> result = new Matrix<T>(rowLenght.Row, rowLenght.Col);

            for (int i = 0; i < rowLenght.Row; i++)
            {
                for (int j = 0; j < ColLenght.Col; j++)
                {
                    result[i, j] = (dynamic)rowLenght[i, j] + (dynamic)ColLenght[i, j];
                }
            }

            return result;
        }
        else
        {
            throw new OperationCanceledException("Matrixes should be same size.");
        }
    }

    // subtractionof matrices of the same size
    public static Matrix<T> operator -(Matrix<T> rowLenght, Matrix<T> ColLenght)
    {
        if (rowLenght.Row == ColLenght.Row && rowLenght.Col == ColLenght.Col)
        {
            Matrix<T> result = new Matrix<T>(rowLenght.Row, rowLenght.Col);

            for (int i = 0; i < rowLenght.Row; i++)
            {
                for (int j = 0; j < ColLenght.Col; j++)
                {
                    result[i, j] = (dynamic)rowLenght[i, j] - (dynamic)ColLenght[i, j];
                }
            }

            return result;
        }

        else
        {
            throw new OperationCanceledException("Matrixes should be same size.");
        }
    }

    // multiply matrices of the same size
    public static Matrix<T> operator *(Matrix<T> rowLenght, Matrix<T> ColLenght)
    {
        if (rowLenght.Row == ColLenght.Row && rowLenght.Col == ColLenght.Col)
        {
            Matrix<T> result = new Matrix<T>(rowLenght.Row, rowLenght.Col);

            for (int i = 0; i < rowLenght.Row; i++)
            {
                for (int j = 0; j < rowLenght.Col; j++)
                {
                    result[i, j] = (dynamic)rowLenght[i, j] * (dynamic)ColLenght[i, j];
                }
            }

            return result;
        }
        else
        {
            throw new OperationCanceledException("Matrixes should be same size.");
        }
    }

    //Implement the true operator (check for non-zero elements).
    public static bool operator true(Matrix<T> matrix)
    {
        if (matrix == null || matrix.Row <= 0 || matrix.Col <= 0)
        {
            return true;
        }

        for (int row = 0; row < matrix.Row; row++)
        {
            for (int col = 0; col < matrix.Col; col++)
            {
                if (!matrix[row, col].Equals(default(T)))
                {
                    return false;
                }
            }
        }

        return true;
    }


    //Implement the false operator (check for non-zero elements).
    public static bool operator false(Matrix<T> matrix)
    {
        if (matrix == null || matrix.Row <= 0 || matrix.Col <= 0)
        {
            return false;
        }

        for (int row = 0; row < matrix.Row; row++)
        {
            for (int col = 0; col < matrix.Col; col++)
            {
                if (!matrix[row, col].Equals(default(T)))
                {
                    return true;
                }
            }
        }

        return false;
    }


}

