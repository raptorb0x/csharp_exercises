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

        [TestInitialize]
        public void Setup()
        {
            //arrange
            //Сбросим логику в исходное состояние
            Logics.Reset();
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
            Logics.addDigit('0');

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Enter_Digits") TestMethod()]
        public void EnterDigitTest_Lead_Zero()
        {

            //arrange

            //act
            Logics.addDigit('0');
            Logics.addDigit('1');

            //assert
            Assert.AreEqual("1", Logics.Data);
        }

        [TestCategory("Enter_Digits") TestMethod()]
        public void EnterDigitTest_Numbers_Limit()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.addDigit('2');
            Logics.addDigit('3');
            Logics.addDigit('4');
            Logics.addDigit('5');
            Logics.addDigit('6');
            Logics.addDigit('7');
            Logics.addDigit('8');
            Logics.addDigit('9');
            Logics.addDigit('0');

            //assert
            Assert.AreEqual("1234567890", Logics.Data);
        }

        [TestCategory("Enter_Digits") TestMethod() ExpectedException(typeof(Exception))]
        public void EnterDigitTest_Numbers_Over_Limit()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.addDigit('2');
            Logics.addDigit('3');
            Logics.addDigit('4');
            Logics.addDigit('5');
            Logics.addDigit('6');
            Logics.addDigit('7');
            Logics.addDigit('8');
            Logics.addDigit('9');
            Logics.addDigit('0');
            Logics.addDigit('1');

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
            Logics.addDigit('1');
            Logics.addDigit('2');
            Logics.Back();

            //assert
            Assert.AreEqual("1", Logics.Data);
        }

        [TestCategory("Back") TestMethod()]
        public void BackTest_AllNumbers()
        {

            //arrange

            //act
            Logics.addDigit('1');
            Logics.addDigit('2');
            Logics.Back();
            Logics.Back();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Back") TestMethod()]
        public void BackTest_AllNumbers_AndMore()
        {

            //arrange

            //act
            Logics.addDigit('1');
            Logics.addDigit('2');
            Logics.Back();
            Logics.Back();
            Logics.Back();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Back") TestMethod()]
        public void BackTest_Number_AndComma()
        {

            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.Back();

            //assert
            Assert.AreEqual("1", Logics.Data);
        }

        [TestCategory("Back") TestMethod()]
        public void BackTest_Number_Comma_number()
        {

            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Back();

            //assert
            Assert.AreEqual("1,", Logics.Data);
        }
        #endregion

        #region Тестирование очистки

        [TestCategory("Clear") TestMethod()]
        public void ClearTest_Without_Number()
        {
            //arrange

            //act
            Logics.Clear();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Clear") TestMethod()]
        public void ClearTest_With_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Clear();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Clear") TestMethod()]
        public void ClearTest_With_Numbers()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.addDigit('2');
            Logics.addDigit('3');
            Logics.addDigit('4');
            Logics.addDigit('5');
            Logics.addDigit('6');
            Logics.addDigit('7');
            Logics.addDigit('8');
            Logics.addDigit('9');
            Logics.addDigit('0');
            Logics.Clear();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Clear") TestMethod()]
        public void ClearTest_With_Operator()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('+');
            Logics.addDigit('1');
            Logics.Clear();
            Logics.Equality();

            //assert
            Assert.AreEqual("1", Logics.Data);
        }

        #endregion

        #region Тестирование запятой

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Number_Comma()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();

            //assert
            Assert.AreEqual("1,", Logics.Data);
        }

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Number_Comma_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('2');

            //assert
            Assert.AreEqual("1,2", Logics.Data);
        }

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Number_Comma_Comma()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.Comma();

            //assert
            Assert.AreEqual("1,", Logics.Data);
        }

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Number_Comma_Zero_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('0');
            Logics.addDigit('2');

            //assert
            Assert.AreEqual("1,02", Logics.Data);
        }

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Number_Comma_Number_Comma()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Comma();

            //assert
            Assert.AreEqual("1,2", Logics.Data);
        }

        [TestCategory("Comma") TestMethod()]
        public void CommaTest_Comma_Number()
        {
            //arrange

            //act
            Logics.Comma();
            Logics.addDigit('1');

            //assert
            Assert.AreEqual("0,1", Logics.Data);
        }
        #endregion

        #region Тестирование знака
        [TestCategory("Sign") TestMethod()]
        public void SignTest_Without_Number()
        {
            //arrange

            //act
            Logics.Sign();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Sign") TestMethod()]
        public void SignTest_With_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Sign();

            //assert
            Assert.AreEqual("-1", Logics.Data);
        }

        [TestCategory("Sign") TestMethod()]
        public void SignTest_Double_With_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Sign();
            Logics.Sign();

            //assert
            Assert.AreEqual("1", Logics.Data);
        }
        #endregion
    }
}