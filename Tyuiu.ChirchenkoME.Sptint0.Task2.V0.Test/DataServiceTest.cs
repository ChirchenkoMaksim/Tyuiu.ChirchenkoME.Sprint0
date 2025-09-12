using Microsoft.VisualStudio.TestTools.UnitTesting;


using System;

using Tyuiu.ChirchenkoME.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ChirchenkoME.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTestBase
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Максим";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Максим", res);

        }
    }
}
