using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.UsoltsevAD.Sprint4.Task0.V11.Lib
{
    public class DataService : ISprint4Task0V11
    {
        public int GetMultOddArrEl(int[] array)
        {
            int res = 1;
            foreach (int numbers in array)
            {
                if (numbers % 2 == 1)
                {
                    res *= numbers;
                }
            }
            return res;
        }
    }
}
