using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.SmirnovIA.Sprint6.Task5.V17.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"D:\tyuiu projects\Tyuiu.SmirnovIA.Sprint6\Tyuiu.SmirnovIA.Sprint6.Task5.V17\bin\Debug\InPutFileTask5V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
