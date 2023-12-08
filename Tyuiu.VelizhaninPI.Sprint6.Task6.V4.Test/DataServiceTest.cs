using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VelizhaninPI.Sprint6.Task6.V4.Lib;

namespace Tyuiu.VelizhaninPI.Sprint6.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V4.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "SnBC nnndrM RbvnKtNW ";
            Assert.AreEqual(wait, res);
        }
    }
}
