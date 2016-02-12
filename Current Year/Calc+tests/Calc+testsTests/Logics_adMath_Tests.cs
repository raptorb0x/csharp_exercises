using System;
using Calc_Logics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//-----------------------------------------------------
//Тесты изначально писались без имерения покрытия, а на основе вариантов условий
//В результате имеем избыточность , но "Лучше плохие тесты, чем никаких тестов" (с) Martin Fowler
//По типу написания тестов взят паттерн ААА (arrange,act,assert) (подготовка,действие,утверждение?)
//------------------------------------------------------

namespace Calc_testsTests
{
    /// <summary>
    /// Тесты расширенной математики
    /// </summary>
    [TestClass]
    public class Logics_adMath_Tests
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

        #region Тестирование извлечения корня
        
        /// <summary>
        /// Извлечение корня из нуля
        /// </summary>
        [TestCategory("SQRT") TestMethod]
        public void SQRT_Zero_Test()
        {
            //arrange

            //act
            Logics.Sqrt();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        /// <summary>
        /// Извлечение корня из числа
        /// </summary>
        [TestCategory("SQRT") TestMethod]
        public void SQRT_Number_Test()
        {
            //arrange

            //act
            Logics.addDigit('9');
            Logics.Sqrt();

            //assert
            Assert.AreEqual("3", Logics.Data);
        }

        /// <summary>
        /// Извлечение корня изх отрицательного числа, ловим исключение
        /// </summary>
        [TestCategory("SQRT") TestMethod ExpectedException(typeof(Exception))]
        public void SQRT_Neg_Number_Test()
        {
            //arrange

            //act
            Logics.addDigit('9');
            Logics.Sign();
            Logics.Sqrt();

            //assert
            Assert.Fail("Должно было быть выброшено исключение");
        }

        /// <summary>
        /// Извлечение корня при операции
        /// </summary>
        [TestCategory("SQRT") TestMethod ]
        public void SQRT_In_Oper_Number_Test()
        {
            //arrange

            //act
            Logics.addDigit('3');
            Logics.Oper('*');
            Logics.addDigit('9');
            Logics.Sqrt();
            Logics.Equality();

            //assert
            Assert.AreEqual("9", Logics.Data);
        }

        /// <summary>
        /// Извлечение корня из числа с запятой
        /// </summary>
        [TestCategory("SQRT") TestMethod]
        public void SQRT_Number_Comma_Test()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('4');
            Logics.addDigit('4');
            Logics.Sqrt();

            //assert
            Assert.AreEqual("1,2", Logics.Data);
        }

        #endregion

        //-----------------------------------------------------------------------

        #region Тестирование обратной пропорциональности

        /// <summary>
        /// Обратная пропорциональность нуля
        /// </summary>
        [TestCategory("Inverse") TestMethod]
        public void Inverse_Zero_Test()
        {
            //arrange

            //act
            Logics.Inverse();

            //assert
            Assert.AreEqual(Double.PositiveInfinity.ToString(), Logics.Data);
        }

        /// <summary>
        /// Обратная пропорциональность числа
        /// </summary>
        [TestCategory("Inverse") TestMethod]
        public void Inverse_Number_Test()
        {
            //arrange

            //act
            Logics.addDigit('5');
            Logics.Inverse();

            //assert
            Assert.AreEqual("0,2", Logics.Data);
        }

        /// <summary>
        /// Обратная пропорциональность отрицательного числа
        /// </summary>
        [TestCategory("Inverse") TestMethod]
        public void Inverse_Neg_Number_Test()
        {
            //arrange

            //act
            Logics.addDigit('5');
            Logics.Sign();
            Logics.Inverse();

            //assert
            Assert.AreEqual("-0,2", Logics.Data);
        }

        /// <summary>
        /// Обратная пропорциональность при операции
        /// </summary>
        [TestCategory("Inverse") TestMethod]
        public void Inverse_In_Oper_Number_Test()
        {
            //arrange

            //act
            Logics.addDigit('4');
            Logics.Oper('*');
            Logics.addDigit('4');
            Logics.Inverse();
            Logics.Equality();

            //assert
            Assert.AreEqual("1", Logics.Data);
        }

        /// <summary>
        /// Обратная пропорциональность числа с запятой
        /// </summary>
        [TestCategory("Inverse") TestMethod]
        public void Inverse_Number_Comma_Test()
        {
            //arrange

            //act
            Logics.Comma();
            Logics.addDigit('2');
            Logics.addDigit('5');
            Logics.Inverse();
            Logics.Equality();

            //assert
            Assert.AreEqual("4", Logics.Data);
        }

        #endregion

        //-----------------------------------------------------------------------

        #region Тестирование процентпроцентов
        
        /// <summary>
        /// нулевой процент от ничего - ловим исключение
        /// </summary>
        [TestCategory("Percent") TestMethod ExpectedException(typeof(Exception))]
        public void Percent_Zero_Test()
        {
            //arrange

            //act
            Logics.Percent();

            //assert
            Assert.Fail("Должно было быть выброшено исключение");
        }

        /// <summary>
        /// Ненулевой процент от ничего - ловим исключение
        /// </summary>
        [TestCategory("Percent") TestMethod ExpectedException(typeof(Exception))]
        public void Percent_Number_Test()
        {
            //arrange

            //act
            Logics.addDigit('5');
            Logics.Percent();

            //assert
            Assert.Fail("Должно было быть выброшено исключение");
        }

        /// <summary>
        /// Число плюс нулей процент
        /// </summary>
        [TestCategory("Percent") TestMethod]
        public void Percent_Operation_Zero_Test()
        {
            //arrange

            //act
            Logics.addDigit('5');
            Logics.Oper('+');
            Logics.Percent();

            //assert
            Assert.AreEqual("5",Logics.Data);
        }

        /// <summary>
        /// Число плюс ненулевой процент
        /// </summary>
        [TestCategory("Percent") TestMethod]
        public void Percent_Operation_Number_Test()
        {
            //arrange

            //act
            Logics.addDigit('5');
            Logics.Oper('+');
            Logics.addDigit('5');
            Logics.addDigit('0');
            Logics.Percent();

            //assert
            Assert.AreEqual("7,5", Logics.Data);
        }

        /// <summary>
        /// число плюс отрицательный дробный процент
        /// </summary>
        [TestCategory("Percent") TestMethod]
        public void Percent_Operation_Number_Comma_Negative_Test()
        {
            //arrange

            //act
            Logics.addDigit('5');
            Logics.Sign();
            Logics.Oper('+');
            Logics.addDigit('5');
            Logics.addDigit('0');
            Logics.Comma();
            Logics.addDigit('5');
            Logics.addDigit('0');
            Logics.Percent();

            //assert
            Assert.AreEqual("-7,525", Logics.Data);
        }
        #endregion

        //-----------------------------------------------------------------------
    }
}
