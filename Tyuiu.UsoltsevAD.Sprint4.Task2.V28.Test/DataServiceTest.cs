using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint4.Task2.V28.Lib;
namespace Tyuiu.UsoltsevAD.Sprint4.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 2, 3, 4, 5, 6, 7, 8, 2, 3, 4, 5, 6 };
            int res = ds.Calculate(array);
            int wait = 23;
            Assert.AreEqual(wait, res);
        }
    }
}
