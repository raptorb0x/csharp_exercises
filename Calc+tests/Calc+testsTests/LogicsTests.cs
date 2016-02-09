using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc_tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_tests.Tests
{
    [TestClass()]
    public class LogicsTests
    {
        [TestMethod()]
        public void addDigitTest()
        {
            Logics lLogic = new Logics();
            lLogic.addDigit('5');
            lLogic.addDigit('5');
            lLogic.addDigit('5');
            lLogic.addDigit('5');
            Assert.AreEqual("5555", lLogic.Calc);
            lLogic.Clear();
            Assert.AreEqual("0", lLogic.Calc);
        }
    }
}