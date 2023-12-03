using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint6.Task1.V23.Lib;

namespace Tyuiu.VelizhaninPI.Sprint6.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] wait = new double[len];
            wait[0] = 3.30;
            wait[1] = -12.37;
            wait[2] = -14.02;
            wait[3] = -5.57;
            wait[4] = 0.65;
            wait[5] = 0;
            wait[6] = -0.65;
            wait[7] = 5.57;
            wait[8] = 14.02;
            wait[9] = 12.37;
            wait[10] = -3.30;

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
