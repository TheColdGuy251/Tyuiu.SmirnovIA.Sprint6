using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint6.Task0.V13.Lib;

namespace Tyuiu.SmirnovIA.Sprint6.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            Assert.AreEqual(3.375, res);
        }
    }
}
