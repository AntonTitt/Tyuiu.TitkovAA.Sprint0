using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessegeValid()
        {
            var name = "Антор";
            var res = DataService.GetMessege(name);

            Assert.AreEqual("Привет, Антор", res);
        }
    }
}
