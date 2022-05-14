using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using WhyInterface;
using WhyInterface.Models;

namespace WhyInterface_UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {

            Mock<IEvaluatedEmployee> EvEmp = new Mock<IEvaluatedEmployee>();
            EvEmp.Setup(x => x.CheckEmployee()).Returns(true);

            CSuite obje = new CSuite();
            Assert.AreEqual(obje.TerminateEmployee(EvEmp.Object), true);
        }

    }
}
