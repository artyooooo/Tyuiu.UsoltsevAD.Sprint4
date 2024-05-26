using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint4.Task0.V11.Lib;
namespace Tyuiu.UsoltsevAD.Sprint4.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int res = ds.GetMultOddArrEl(array);
            int wait = 4725;
            Assert.AreEqual(wait, res);
        }
    }
}
