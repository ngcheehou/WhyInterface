//using NUnit.Framework;
 
using System;
using Moq;
  
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhyInterface;
using WhyInterface.Models;

namespace WhyInterfaceUnitTest
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void TestMethod1()
        {

            Mock<IEvaluatedEmployee> EvEmp = new Mock<IEvaluatedEmployee>();
            EvEmp.Setup(x => x.CheckEmployee()).Returns(true);

            CSuite obje = new CSuite();
            Assert.AreEqual(obje.TerminateEmployee(EvEmp.Object), true);
        }


        //[TestMethod]
        //public bool TestMethod12()
        //{
        //    int answer = 2;
        //    Mock<IEvaluatedEmployee> EvEmp = new Mock<IEvaluatedEmployee>();
        //    EvEmp.Setup(x => x.CheckEmployee()).Returns(true);
        //    int myanswer = 1 + 1;
        //     Assert.AreEqual(myanswer, answer);
        //    return true;
        //}
    }
}