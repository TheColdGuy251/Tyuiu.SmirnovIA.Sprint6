using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.SmirnovIA.Sprint6.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"D:\tyuiu projects\Tyuiu.SmirnovIA.Sprint6\Tyuiu.SmirnovIA.Sprint6.Task6.V13\bin\Debug\InPutFileTask6V13.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
