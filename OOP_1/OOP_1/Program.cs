using System;
using System.Collections.Generic;

namespace OOP_1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 2, 0, 3 };
            // a + b
            Matrix a = new Matrix(2, 2, arr);
            Console.WriteLine(a.ToString());
            Console.WriteLine(" + \n");
            arr = new double[] { -5, -2, 4, -1 };
            Matrix b = new Matrix(2, 2, arr);
            Console.WriteLine(b.ToString());
            Console.WriteLine(" = \n");
            Matrix c = a + b;
            Console.WriteLine(c.ToString());
            Console.WriteLine(".................................");

            // a - b
            arr = new double[] { 1, 2, 0, 3 };
            a = new Matrix(2, 2, arr);
            Console.WriteLine(a.ToString());
            Console.WriteLine(" - \n");
            arr = new double[] { -5, -2, 4, -1 };
            b = new Matrix(2, 2, arr);
            Console.WriteLine(b.ToString());
            Console.WriteLine(" = \n");
            c = a - b;
            Console.WriteLine(c.ToString());
            Console.WriteLine(".................................");

            // a * b
            arr = new double[] { 1, 2, 0, 3 };
            a = new Matrix(2, 2, arr);
            Console.WriteLine(a.ToString());
            Console.WriteLine(" * \n");
            arr = new double[] { -5, -2, -3, 4, -1, 0 };
            b = new Matrix(2, 3, arr);
            
            Console.WriteLine(b.ToString());
            Console.WriteLine(" = \n");
            c = a * b;
            Console.WriteLine(c.ToString());
            Console.WriteLine(".................................");

            // k * b
            int k = 10;
            Console.WriteLine(k);
            Console.WriteLine("\n * \n");
            arr = new double[] { -5, -2, -3, 4, -1, 0 };
            b = new Matrix(2, 3, arr);
            Console.WriteLine(b.ToString());
            Console.WriteLine(" = \n");
            c = k * b;
            Console.WriteLine(c.ToString());
            Console.WriteLine(".................................");
            // det(A)
            arr = new double[]
            {
                1,2,3,
                4,1,6,
                7,8,1
            };
            Matrix A = new Matrix(3, 3, arr);
            Console.WriteLine(A.ToString());
            Console.WriteLine("Det(A) = {0}\n", A.Det());
            Console.WriteLine(".................................");


            // comparison
            arr = new double[]
            {
                1,2,3,
                4,1,6,
                7,8,1
            };
            a = new Matrix(3, 3, arr);
            b = new Matrix(3, 3, arr);
            Console.WriteLine("Matrix 'a'\n");
            Console.WriteLine(a.ToString());
            Console.WriteLine("Matrix 'b'\n");
            Console.WriteLine(b.ToString());
            Console.WriteLine("a == b ?\n");
            Console.WriteLine(a == b);
            arr = new double[]
            {
                1,2,3,
                1,1,6,
                1,8,1
            };
            b = new Matrix(3, 3, arr);
            Console.WriteLine("\nMatrix 'a'\n");
            Console.WriteLine(a.ToString());
            Console.WriteLine("Matrix 'b'\n");
            Console.WriteLine(b.ToString());
            Console.WriteLine("a == b ?\n");
            Console.WriteLine(a == b);
            Console.WriteLine(".................................");
        }
    }
}
