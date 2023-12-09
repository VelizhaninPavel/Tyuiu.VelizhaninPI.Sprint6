using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint6.Task7.V10.Lib;
using System.IO;

namespace Tyuiu.VelizhaninPI.Sprint6.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutFileTask7V10.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
