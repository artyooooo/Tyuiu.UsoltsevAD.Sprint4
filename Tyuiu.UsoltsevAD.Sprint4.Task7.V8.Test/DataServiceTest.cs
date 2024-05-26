﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint4.Task7.V8.Lib;
namespace Tyuiu.UsoltsevAD.Sprint4.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string value = "264795863157";
            int n = 3;
            int m = 4;
            int res = ds.Calculate(n, m, value);
            int wait = 37;
            Assert.AreEqual(wait, res);
        }
    }
}
