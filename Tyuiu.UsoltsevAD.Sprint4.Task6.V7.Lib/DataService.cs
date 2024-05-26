using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.UsoltsevAD.Sprint4.Task6.V7.Lib
{
    public class DataService : ISprint4Task6V7
    {
        public int Calculate(string[] array)
        {
            int res = 0;
            foreach (string word in array)
            {
                if (word.Length > 8)
                {
                    res += 1;
                }
            }
            return res;
        }
    }
}
