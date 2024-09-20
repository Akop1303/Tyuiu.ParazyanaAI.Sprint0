using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ParazyanAI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ParazyanAI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageVaild()
        {
            var name = "Акоп";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Акоп", res);
        }
    }
}
