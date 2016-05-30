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


    }
}
