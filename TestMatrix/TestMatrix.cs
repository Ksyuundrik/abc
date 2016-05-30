using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using verify2;

namespace TestMatrix
{
    [TestClass]
    public class TestMatrix
    {
        [TestMethod]
        public void TestTranspositionMatrix()
        {
            int n = 4;
            Matrix matrix = new Matrix();
            float[,] A = new float[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            float[,] expected = new float[4, 4] { { 1, 5, 9, 13 }, { 2, 6, 10, 14 }, { 3, 7, 11, 15 }, { 4, 8, 12, 16 } };
            A = matrix.TranspositionMatrix(A, n);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Assert.AreEqual(expected[i, j], A[i, j]);
        }



        [TestMethod]
        public void TestSymmetry()
        {
            int n = 4;
            Matrix matrix = new Matrix();
            float[,] A = new float[4, 4] {  { 1, 2, 3, 4 }, 
                                            { 5, 6, 7, 8 }, 
                                            { 9, 10, 11, 12 }, 
                                            { 13, 14, 15, 16 } };
            bool c = matrix.Symmetry(A, n);
            Assert.IsFalse(c);
        }


        [TestMethod]
        public void TestMultiplyMatrixOnNumber()
        {
            int n = 3;
            int k = 2;
            Matrix matrix = new Matrix();
            float[,] A = new float[3, 3] { { 1, 2, 3 }, { 5, 6, 7 }, { 9, 10, 11 } };
            float[,] expected = new float[3, 3] { { 2, 4, 6 }, { 10, 12, 14 }, { 18, 20, 22 } };
            float[,] C;
            C = matrix.MultiplyMatrixOnNumber(A, k, n);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Assert.AreEqual(expected[i, j], C[i, j]);
        }



        [TestMethod]
        public void TestDelenMatrixOnNumber()
        {
            int n = 3;
            int k = 2;
            Matrix matrix = new Matrix();
            float[,] A = new float[3, 3] { { 2, 4, 6 },{ 10, 12, 14 }, { 18, 20, 22 } };
            float[,] expected = new float[3, 3] { { 1, 2, 3 }, { 5, 6, 7 }, { 9, 10, 11 } };
            float[,] C;
            C = matrix.DelenMatrixOnNumber(A, k, n);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Assert.AreEqual(expected[i, j], C[i, j]);
        }



        [TestMethod]
        public void TestAdditionTwoMatrix()
        {
            int n = 4;
            Matrix matrix = new Matrix();
            float[,] A = new float[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            float[,] B = new float[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            float[,] expected = new float[4, 4] { { 2, 4, 6, 8 }, { 10, 12, 14, 16 }, { 18, 20, 22, 24 }, { 26, 28, 30, 32 } };
            float[,] C;
            C = matrix.AdditionTwoMatrix(A, B, n);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Assert.AreEqual(expected[i, j], C[i, j]);
        }



        [TestMethod]
        public void TestMultiplyTwoMatrix()
        {
            int n = 4;
            Matrix matrix = new Matrix();
            float[,] A = new float[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            float[,] B = new float[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            float[,] expected = new float[4, 4] { { 90, 100, 110, 120 }, { 202, 228, 254, 280 }, { 314, 356, 398, 440 }, { 426, 484, 542, 600 } };
            float[,] C;
            C = matrix.MultiplyTwoMatrix(A, B, n);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Assert.AreEqual(expected[i, j], C[i, j]);
        }



    }
}
