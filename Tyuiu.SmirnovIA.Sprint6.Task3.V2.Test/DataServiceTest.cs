using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovIA.Sprint6.Task3.V2.Lib;
namespace Tyuiu.SmirnovIA.Sprint6.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] {{-12, -4, -20, 5, -5},
                          { 2, 15, 1, -20, 7},
                          { 15, -15, 2, 11, 5},
                          { -19, -9, 16, 0, 1},
                          { 17, 16, 5, 12, -8}};
            int[,] res = ds.Calculate(mas);
            int[,] wait = new int[5, 5] {{0, 0, 0, 5, -5},
                          { 2, 15, 1, -20, 7},
                          { 15, -15, 2, 11, 5},
                          { -19, -9, 16, 0, 1},
                          { 17, 16, 5, 12, -8}};

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
