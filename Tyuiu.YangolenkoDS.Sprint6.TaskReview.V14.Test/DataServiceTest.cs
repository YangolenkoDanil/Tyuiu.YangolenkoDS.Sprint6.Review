using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint6.TaskReview.V14.Lib;

namespace Tyuiu.YangolenkoDS.Sprint6.TaskReview.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 1, 2, 2, 4, 5},
                                          { 20, 5, 9, 45, 4},
                                          {5, 20, 8, 1, 8},
                                          {6, 9, 54, 5, 6},
                                          {30, 5, 3, 15, 6} };
            int n1 = 1;
            int n2 = 10;
            int c = 3;
            int k = 0;
            int l = 4;
            int res = ds.Result(array,  c,  k, l);
            int wait = 60;
            Assert.AreEqual(wait, res);
        }
    }
}
