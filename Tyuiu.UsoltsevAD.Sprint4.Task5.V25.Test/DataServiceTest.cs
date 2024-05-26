using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint4.Task5.V25.Lib;
namespace Tyuiu.UsoltsevAD.Sprint4.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { -3, 2, 0, -4, 1 },
                                            { -2, 0, -1, -4, -2 },
                                            { 0, 2, 1, -4, -3 },
                                            { -3, 0, 1, 2, -1 },
                                            { 2, 2, 1, -2, 0 } };
            int wait = 14;
            int res = ds.Calculate(matrix);
            Assert.AreEqual(wait, res);
        }
    }
}
