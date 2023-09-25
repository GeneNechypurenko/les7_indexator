using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les7_indexator
{
    internal class Matrix
    {
        public int Row { get; set; }
        public int Col { get; set; }

        private int[,] _arr;

        public Matrix(int row, int col)
        {
            Random rand = new Random();

            Row = row;
            Col = col;

            _arr = new int[row, col];

            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    _arr[i, j] = rand.Next(0, 9);
                }
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if ((i >= 0 && i < _arr.Length) && (j >= 0 && j < _arr.Length))
                {
                    return _arr[i, j];
                }
                else
                {
                    throw new IndexOutOfRangeException("out of range!");
                }
            }
            set
            {
                if ((i >= 0 && i < _arr.Length) && (j >= 0 && j < _arr.Length))
                {
                    _arr[i, j] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("out of range!");
                }
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < Row; ++i)
            {
                for (int j = 0; j < Col; ++j)
                {
                    sb.Append(this[i, j]);
                    sb.Append(" ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Row == m2.Row && m1.Col == m2.Col)
            {
                Matrix result = new Matrix(m1.Row, m1.Col);

                for (int i = 0; i < m1.Row; ++i)
                {
                    for (int j = 0; j < m1.Col; ++j)
                    {
                        result[i, j] = m1[i, j] + m2[i, j];
                    }
                }

                return result;
            }
            else
            {
                throw new IndexOutOfRangeException("out of range");
            }
        }
    }
}
