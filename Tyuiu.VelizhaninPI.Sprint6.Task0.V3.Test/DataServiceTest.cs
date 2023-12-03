using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint6.Task0.V3.Lib;

namespace Tyuiu.VelizhaninPI.Sprint6.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            double wait = 4.154;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
