using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint3.Task3.V21.Lib;

namespace Tyuiu.GofmanDv.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();

            string value = "f3g5ht g4j 34kg4";
            char item = '3';

            string res = ds.ReplaceNumOnChar(value, item);
            string wait = "feg5ht g4j e4kg4";

            Assert.AreEqual(wait, res);


        }
    }
}
