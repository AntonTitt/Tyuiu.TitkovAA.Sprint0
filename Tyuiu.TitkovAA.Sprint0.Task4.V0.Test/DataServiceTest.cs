using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void ChekedSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));

        }
        [TestMethod]
        public void ChekedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));

        }
        [TestMethod]
        public void ChekedDivisionValid()
        {
            Assert.AreEqual(2, DataService.Division(10, 5));

        }



    }
}
