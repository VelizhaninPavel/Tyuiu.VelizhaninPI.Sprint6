using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.VelizhaninPI.Sprint6.Task5.V25.Lib
{
    public class DataService : ISprint6Task5V25
    {
        public object path;
        public int len;

        public double[] LoadFromDataFile(string path)
        {
            int len = 0;
            int lenWithout0 = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                    if (Convert.ToDouble(line) != 0)
                    {
                        lenWithout0++;
                    }
                }
            }

            int count = 0;
            double[] numsArray = new double[len];

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[count] = Math.Round(Convert.ToDouble(line), 3);
                    count++;
                }
            }

            double[] res = new double[lenWithout0];
            res = numsArray.Where(val => val != 0).ToArray();
            return res;
        }
    }
}
