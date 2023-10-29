using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint3.Task6.V1.Lib;

namespace Tyuiu.GofmanDV.Sprint3.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(151, ds.GetSumTheDivisors(11, 17));
        }
    }
}
