﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VelizhaninPI.Sprint6.Task0.V3.Lib
{
    public class DataService : ISprint6Task0V3
    {
        public double Calculate(int x)
        {
            double res = Math.Round((4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1), 3);
            return res;
        }
    }
}
