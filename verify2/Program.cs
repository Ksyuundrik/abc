using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verify2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            int n = 4;
            float[,] A = new float[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            A = matrix.TranspositionMatrix(A, n);
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("\n[" + (i + 1) + ", " + (j + 1) + "] = " + A[i, j]);
                }
            }

            bool c = matrix.Symmetry(A, n);
            if (c) Console.WriteLine("Матрица симметрична.");
            else Console.WriteLine("Матрица несимметрична.");
        }
    }
}
