﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VelizhaninPI.Sprint6.Task4.V6.Lib
{
    public class DataService : ISprint6Task4V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;

            double[] valueArray;
            valueArray = new double[len];

            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round( (3.0*Math.Cos(x))/(4.0*x - 0.5) + Math.Sin(x) - 5.0*x - 2.0, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
