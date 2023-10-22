using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint3.Task0.V19.Lib;

namespace Tyuiu.GofmanDV.Sprint3.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int k1 = 1, k2 = 10;

            var sum = ds.GetSumSeries(k1, k2);
            double z = 0.742;


            Assert.AreEqual(z, sum);
        }
    }
}
