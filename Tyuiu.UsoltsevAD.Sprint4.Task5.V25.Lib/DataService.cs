using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.UsoltsevAD.Sprint4.Task5.V25.Lib
{
    public class DataService : ISprint4Task5V25
    {
        public int Calculate(int[,] matrix)
        {
            int summ = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        summ += matrix[i, j];
                    }
                }
            }
            return summ;
        }
    }
}
