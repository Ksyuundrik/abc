using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verify2
{
    /**
    * Класс для работы с квадратными матрицами
    */
    public class Matrix
    {
      //транспонирование
        public float[,] TranspositionMatrix(float[,] A, int n)
        {
            float temp;
            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                {
                    temp = A[i, j];
                    A[i, j] = A[j, i];
                    A[j, i] = temp;
                }
            return A;
        }


       //проверка симметричности
        public bool Symmetry(float[,] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (A[i, j] != A[j, i])
                        return false;
            }
            return true;
        }
      
    }
}
