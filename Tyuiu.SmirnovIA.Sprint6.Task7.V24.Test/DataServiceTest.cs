using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
namespace Tyuiu.SmirnovIA.Sprint6.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\tyuiu projects\Tyuiu.SmirnovIA.Sprint6\Tyuiu.SmirnovIA.Sprint6.Task7.V24\bin\Debug\OutPutFileTask7V24.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
