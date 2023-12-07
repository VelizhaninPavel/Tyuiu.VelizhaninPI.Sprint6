using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint6.Task4.V6.Lib;

namespace Tyuiu.VelizhaninPI.Sprint6.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] wait = new double[len];
            wait[0] = 23.92;
            wait[1] = 18.88;
            wait[2] = 13.10;
            wait[3] = 7.24;
            wait[4] = 1.80;
            wait[5] = -8;
            wait[6] = -5.70;
            wait[7] = -11.26;
            wait[8] = -17.12;
            wait[9] = -22.88;
            wait[10] = -27.92;

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
