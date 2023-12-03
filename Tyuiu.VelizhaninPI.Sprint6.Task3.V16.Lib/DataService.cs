using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VelizhaninPI.Sprint6.Task3.V16.Lib
{
    public class DataService : ISprint6Task3V16
    {
        public int[,] Calculate(int[,] matrix)
        {

            int n = matrix.GetUpperBound(0) + 1;    //stroki
            int m = matrix.Length / n;    //stolbiki
            int sum = 0;
            int[,] res = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 2 && matrix[i, j] % 2 == 0)
                    {
                        res[i, j] = 0;
                    }
                    else
                    {
                        res[i, j] = matrix[i, j];
                    }
                }
            }
            return res;
        }
    }
}
