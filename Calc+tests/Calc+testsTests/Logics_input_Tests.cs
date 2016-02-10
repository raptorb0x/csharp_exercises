using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc_tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_tests.Tests
{
    [TestClass]
    public class Logics_Input_Tests
    {
        Logics lLogic;

        [TestInitialize]
        public void Setup()
        {
            //arrange
            lLogic = new Logics();
        }

        [TestCleanup]
        public void Teardown()
        {
            //Вроде как GC должен сам собрать мусор
        }

        #region Тестирование ввода чисел
        [TestCategory("Enter_Digits") TestMethod()]
        public void addDigitTest_Enter_Zero()
        {
            //arrange

            //act
            lLogic.addDigit('0');

            //assert
            Assert.AreEqual("0", lLogic.Calc);
        }

        [TestCategory("Enter_Digits") TestMethod()]
        public void addDigitTest_Lead_Zero()
        {

            //arrange

            //act
            lLogic.addDigit('0');
            lLogic.addDigit('1');

            //assert
            Assert.AreEqual("1", lLogic.Calc);
        }

        [TestCategory("Enter_Digits") TestMethod()]
        public void addDigitTest_Numbers()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.addDigit('2');
            lLogic.addDigit('3');
            lLogic.addDigit('4');
            lLogic.addDigit('5');
            lLogic.addDigit('6');
            lLogic.addDigit('7');
            lLogic.addDigit('8');
            lLogic.addDigit('9');
            lLogic.addDigit('0');

            //assert
            Assert.AreEqual("1234567890", lLogic.Calc);
        }

        [TestCategory("Enter_Digits") TestMethod()]
        public void addDigitTest_Numbers()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.addDigit('2');
            lLogic.addDigit('3');
            lLogic.addDigit('4');
            lLogic.addDigit('5');
            lLogic.addDigit('6');
            lLogic.addDigit('7');
            lLogic.addDigit('8');
            lLogic.addDigit('9');
            lLogic.addDigit('0');

            //assert
            Assert.AreEqual("1234567890", lLogic.Calc);
        }

        #endregion

        #region Тестирование Backspace
        [TestCategory("Back") TestMethod()]
        public void BackTest_One_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.addDigit('2');
            lLogic.Back();

            //assert
            Assert.AreEqual("1", lLogic.Calc);
        }

        [TestCategory("Back") TestMethod()]
        public void BackTest_AllNumbers()
        {

            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.addDigit('2');
            lLogic.Back();
            lLogic.Back();

            //assert
            Assert.AreEqual("0", lLogic.Calc);
        }

        [TestCategory("Back") TestMethod()]
        public void BackTest_AllNumbers_AndMore()
        {

            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.addDigit('2');
            lLogic.Back();
            lLogic.Back();
            lLogic.Back();

            //assert
            Assert.AreEqual("0", lLogic.Calc);
        }

        [TestCategory("Back") TestMethod()]
        public void BackTest_Number_AndComma()
        {

            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.Back();

            //assert
            Assert.AreEqual("1", lLogic.Calc);
        }

        [TestCategory("Back") TestMethod()]
        public void BackTest_Number_Comma_number()
        {

            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Back();

            //assert
            Assert.AreEqual("1,", lLogic.Calc);
        }
        #endregion

        #region Тестирование Сброса
        [TestCategory("Clear") TestMethod()]
        public void ClearTest_Without_Number()
        {
            //arrange

            //act
            lLogic.Clear();

            //assert
            Assert.AreEqual("0", lLogic.Calc);
        }

        [TestCategory("Clear") TestMethod()]
        public void ClearTest_With_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Clear();

            //assert
            Assert.AreEqual("0", lLogic.Calc);
        }

        [TestCategory("Clear") TestMethod()]
        public void ClearTest_With_Numbers()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.addDigit('2');
            lLogic.addDigit('3');
            lLogic.addDigit('4');
            lLogic.addDigit('5');
            lLogic.addDigit('6');
            lLogic.addDigit('7');
            lLogic.addDigit('8');
            lLogic.addDigit('9');
            lLogic.addDigit('0');
            lLogic.Clear();

            //assert
            Assert.AreEqual("0", lLogic.Calc);
        }
        #endregion

        #region Тестирование запятой
        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();

            //assert
            Assert.AreEqual("1,", lLogic.Calc);
        }

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Number_Comma_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');

            //assert
            Assert.AreEqual("1,2", lLogic.Calc);
        }

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Number_Comma_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.Comma();

            //assert
            Assert.AreEqual("1,", lLogic.Calc);
        }

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Number_Comma_Zero_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('0');
            lLogic.addDigit('2');

            //assert
            Assert.AreEqual("1,02", lLogic.Calc);
        }

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Number_Comma_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Comma();

            //assert
            Assert.AreEqual("1,2", lLogic.Calc);
        }

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Comma_Number()
        {
            //arrange

            //act
            lLogic.Comma();
            lLogic.addDigit('1');

            //assert
            Assert.AreEqual("0,1", lLogic.Calc);
        }
        #endregion

    }
}