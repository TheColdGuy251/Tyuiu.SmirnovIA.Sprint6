using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovIA.Sprint6.Task1.V24.Lib;

namespace Tyuiu.SmirnovIA.Sprint6.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = { -0.62, -16.79, -17.77, -6.3, -5.04, -6, -7.85, -2.43, 5.91, 4.33, -11.82 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
