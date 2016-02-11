using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc_Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------------------------------------
//Тесты изначально писались без имерения покрытия, а на основе вариантов условий
//В результате имеем избыточность , но "Лучше плохие тесты, чем никаких тестов" (с) Martin Fowler
//По типу написания тестов взят паттерн ААА (arrange,act,assert) (подготовка,действие,утверждение?)
//------------------------------------------------------

namespace Calc_Forms.Tests
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
        public void EnterDigitTest_Enter_Zero()
        {
            //arrange

            //act
            lLogic.addDigit('0');

            //assert
            Assert.AreEqual("0", lLogic.Data);
        }

        [TestCategory("Enter_Digits") TestMethod()]
        public void EnterDigitTest_Lead_Zero()
        {

            //arrange

            //act
            lLogic.addDigit('0');
            lLogic.addDigit('1');

            //assert
            Assert.AreEqual("1", lLogic.Data);
        }

        [TestCategory("Enter_Digits") TestMethod()]
        public void EnterDigitTest_Numbers_Limit()
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
            Assert.AreEqual("1234567890", lLogic.Data);
        }

        [TestCategory("Enter_Digits") TestMethod() ExpectedException(typeof(Exception))]
        public void EnterDigitTest_Numbers_Over_Limit()
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
            lLogic.addDigit('1');

            //assert
            Assert.Fail("должно было быть выброшено исключение");
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
            Assert.AreEqual("1", lLogic.Data);
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
            Assert.AreEqual("0", lLogic.Data);
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
            Assert.AreEqual("0", lLogic.Data);
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
            Assert.AreEqual("1", lLogic.Data);
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
            Assert.AreEqual("1,", lLogic.Data);
        }
        #endregion

        #region Тестирование очистки

        [TestCategory("Clear") TestMethod()]
        public void ClearTest_Without_Number()
        {
            //arrange

            //act
            lLogic.Clear();

            //assert
            Assert.AreEqual("0", lLogic.Data);
        }

        [TestCategory("Clear") TestMethod()]
        public void ClearTest_With_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Clear();

            //assert
            Assert.AreEqual("0", lLogic.Data);
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
            Assert.AreEqual("0", lLogic.Data);
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
            Assert.AreEqual("1,", lLogic.Data);
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
            Assert.AreEqual("1,2", lLogic.Data);
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
            Assert.AreEqual("1,", lLogic.Data);
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
            Assert.AreEqual("1,02", lLogic.Data);
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
            Assert.AreEqual("1,2", lLogic.Data);
        }

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Comma_Number()
        {
            //arrange

            //act
            lLogic.Comma();
            lLogic.addDigit('1');

            //assert
            Assert.AreEqual("0,1", lLogic.Data);
        }
        #endregion

        #region Тестирование знака
        [TestCategory("Sign") TestMethod()]
        public void SignTest_Without_Number()
        {
            //arrange

            //act
            lLogic.Sign();

            //assert
            Assert.AreEqual("0", lLogic.Data);
        }

        [TestCategory("Sign") TestMethod()]
        public void SignTest_With_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Sign();

            //assert
            Assert.AreEqual("-1", lLogic.Data);
        }

        [TestCategory("Sign") TestMethod()]
        public void SignTest_Double_With_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Sign();
            lLogic.Sign();

            //assert
            Assert.AreEqual("1", lLogic.Data);
        }
        #endregion
    }
}