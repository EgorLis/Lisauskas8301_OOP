using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class Matrix // maxtrix NxM
    {
        private double[,] arr;

        public int N { get; }

        public int M { get; }

        public Matrix(int n, int m)
        {
            try
            {
                if (n < 1 || m < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                arr = new double[n, m];
                N = n;
                M = m;

            }
            catch
            {
                Console.WriteLine("Wrong dimension");
            }
        }

        public Matrix(int n, int m, double[] Array)
        {
            try
            {
                if (n < 1 || m < 1 || n * m != Array.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                arr = new double[n, m];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        arr[i, j] = Array[j + i * m];
                N = n;
                M = m;

            }
            catch
            {
                Console.WriteLine("Wrong dimension");
            }
        }



        public double this[int i, int j]
        {
            get => arr[i, j];
            set => arr[i, j] = value;
        }



        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.N != b.N || a.M != b.M)
            {
                throw new ArgumentException("Different divisions");
            }
            Matrix result = new Matrix(a.N, a.M);
            for (int i = 0; i < a.N; i++)
                for (int j = 0; j < a.M; j++)
                    result[i, j] = a[i, j] + b[i, j];
            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.N != b.N || a.M != b.M)
            {
                throw new ArgumentException("Different divisions");
            }
            Matrix result = new Matrix(a.N, a.M);
            for (int i = 0; i < a.N; i++)
                for (int j = 0; j < a.M; j++)
                    result[i, j] = a[i, j] - b[i, j];
            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.M != b.N)
            {
                throw new ArgumentException("Wrong divisions");
            }
            Matrix result = new Matrix(a.N, b.M);
            for (int i = 0; i < result.N; i++)
                for (int j = 0; j < result.M; j++)
                {
                    for (int k = 0; k < a.M; k++)
                        result[i, j] += a[i, k] * b[k, j];
                }
            return result;
        }

        public static Matrix operator *(int a, Matrix b)
        {
            Matrix result = new Matrix(b.N, b.M);
            for (int i = 0; i < result.N; i++)
                for (int j = 0; j < result.M; j++)
                {
                    result[i, j] = a * b[i, j];
                }
            return result;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.M != b.M && a.N != b.N)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < a.N; i++)
                    for (int j = 0; j < a.M; j++)
                        if (a[i, j] != b[i, j])
                            return false;
                return true;
            }
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            if (a.M != b.M && a.N != b.N)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < a.N; i++)
                    for (int j = 0; j < a.M; j++)
                        if (a[i, j] != b[i, j])
                            return true;
                return false;
            }
        }
        public override string ToString()
        {
            string outMatrix = "";
            for (int i = 0; i < this.N; i++)
            {
                for (int j = 0; j < this.M; j++)
                    outMatrix += " " + this[i, j].ToString();
                outMatrix += '\n';
            }
            return outMatrix;
        }




        public double Det()
        {
            if (N != M)
                throw new ArgumentOutOfRangeException();
            double det = 1;
            Matrix A;
            A = 1 * this;
            int j = 0;
            int line = 1;
            for (int i = 1; i <= N; i++)
            {
                if (i == N)
                {
                    line++;
                    if (line == N)
                        break;
                    j++;
                    i = line;
                }
                if (i != j)
                {
                    double multiplier = A[i, j] / A[line - 1, j];
                    for (int temp_j = j; temp_j < M; temp_j++)
                    {
                        A[i, temp_j] -= A[line - 1, temp_j] * multiplier;
                    }
                }
            }
            for (int i = 0; i < N; i++)
                det = det * A[i, i];
            return det;
        }

        public override bool Equals(object obj)
        {
            return obj is Matrix matrix &&
                   EqualityComparer<double[,]>.Default.Equals(arr, matrix.arr) &&
                   N == matrix.N &&
                   M == matrix.M;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(arr, N, M);
        }
    }
}
