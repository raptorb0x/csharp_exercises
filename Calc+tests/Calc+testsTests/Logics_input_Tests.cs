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
    /// <summary>
    /// Тесты ввода и редактирования
    /// </summary>
    [TestClass]
    public class Logics_Input_Tests
    {

        //-----------------------------------------------------------------------

        /// <summary>
        /// До теста
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            //arrange
            //Сбросим логику в исходное состояние
            Logics.Reset(); 
        }

        /// <summary>
        /// После теста
        /// </summary>
        [TestCleanup]
        public void Teardown()
        {
            //пока ничего
        }

        //-----------------------------------------------------------------------

        #region Тестирование ввода чисел

        /// <summary>
        /// Ввод нуля
        /// </summary>
        [TestCategory("Enter_Digits") TestMethod()]
        public void EnterDigitTest_Enter_Zero()
        {
            //arrange

            //act
            Logics.addDigit('0');

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        /// <summary>
        /// Ввод лидирующего нуля
        /// </summary>
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

        /// <summary>
        /// Вввод всех цифр
        /// </summary>
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

        /// <summary>
        /// ввод цифр выше лимита, 
        /// </summary>
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

        //-----------------------------------------------------------------------

        #region Тестирование Backspace

        /// <summary>
        /// Затираем одно цифру из двух введенных
        /// </summary>
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

        /// <summary>
        /// Затираем все введенные цифры
        /// </summary>
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

        /// <summary>
        /// Затираем больше чем ввели
        /// </summary>
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

        /// <summary>
        /// Затираем запятую
        /// </summary>
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

        /// <summary>
        /// Затираем цифру после запятой
        /// </summary>
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

        //-----------------------------------------------------------------------

        #region Тестирование очистки

        /// <summary>
        /// Очистка без введения чеголибо
        /// </summary>
        [TestCategory("Clear") TestMethod()]
        public void ClearTest_Without_Number()
        {
            //arrange

            //act
            Logics.Clear();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        /// <summary>
        /// Очистка после ввода
        /// </summary>
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

        /// <summary>
        /// Очистка после ввода всех цифр
        /// </summary>
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

        /// <summary>
        /// Очистка во время вычисления
        /// </summary>
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

        //-----------------------------------------------------------------------

        #region Тестирование запятой

        /// <summary>
        /// Ввод запятой после числа
        /// </summary>
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

        /// <summary>
        /// Ввод  цыфры, запятой и цифры
        /// </summary>
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

        /// <summary>
        /// Двойной ввод запятой
        /// </summary>
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

        /// <summary>
        /// Ввод нуля после запятой
        /// </summary>
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

        /// <summary>
        /// Ввод запятой после введенной запятой и цифры
        /// </summary>
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
        
        /// <summary>
        /// Ввод запятой первой, потом цифры
        /// </summary>
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

        //-----------------------------------------------------------------------

        #region Тестирование знака

        /// <summary>
        /// Смена знака без числа
        /// </summary>
        [TestCategory("Sign") TestMethod()]
        public void SignTest_Without_Number()
        {
            //arrange

            //act
            Logics.Sign();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        /// <summary>
        /// Смена знака у числа
        /// </summary>
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

        /// <summary>
        /// Двойная смена знака у числа
        /// </summary>
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

        //-----------------------------------------------------------------------

        #region Тестирование сброса

        //-----------------------------------------------------------------------
        //  Да, я тестирую метод, который выполняeтся перед каждым тестом, даже перед тестами его же
        //-----------------------------------------------------------------------


        /// <summary>
        /// Сброс без числа
        /// </summary>
        [TestCategory("Reset") TestMethod()]
        public void ResetTest_Without_Number()
        {
            //arrange

            //act
            Logics.Reset();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        /// <summary>
        /// Сброс с числом
        /// </summary>
        [TestCategory("Reset") TestMethod()]
        public void ResetTest_With_Number()
        {
            //arrange

            //act
            Logics.addDigit('5');
            Logics.Reset();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        /// <summary>
        /// Сброс при расчете
        /// </summary>
        [TestCategory("Reset") TestMethod()]
        public void ResetTest_Operation()
        {
            //arrange

            //act
            Logics.addDigit('5');
            Logics.Oper('+');
            Logics.addDigit('5');
            Logics.Reset();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        /// <summary>
        /// Сброс после расчета
        /// </summary>
        [TestCategory("Reset") TestMethod()]
        public void ResetTest_Equality()
        {
            //arrange

            //act
            Logics.addDigit('5');
            Logics.Oper('+');
            Logics.addDigit('5');
            Logics.Equality();
            Logics.Reset();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }
        #endregion

        //-----------------------------------------------------------------------
    }
}