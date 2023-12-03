using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovIA.Sprint6.Task2.V28.Lib;

namespace Tyuiu.SmirnovIA.Sprint6.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = { 17.27, 14.08, 10.27, 6.65, 3.87, 2, -0.74, -3.71, -7.59, -11.55, -14.74 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
