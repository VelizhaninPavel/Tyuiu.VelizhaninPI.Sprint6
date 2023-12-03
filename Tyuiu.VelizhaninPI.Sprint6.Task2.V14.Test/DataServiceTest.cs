using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint6.Task2.V14.Lib;

namespace Tyuiu.VelizhaninPI.Sprint6.Task2.V14.Test
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
            wait[0] = 19.81;
            wait[1] = 16.79;
            wait[2] = 13.87;
            wait[3] = 10.98;
            wait[4] = 7.94;
            wait[5] = 3;
            wait[6] = 3.23;
            wait[7] = -0.45;
            wait[8] = -3.79;
            wait[9] = -6.97;
            wait[10] = -10;

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
