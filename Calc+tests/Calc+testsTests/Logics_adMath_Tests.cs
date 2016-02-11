using System;
using Calc_Logics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc_testsTests
{
    [TestClass]
    public class Logics_adMath_Tests
    {

        [TestInitialize]
        public void Setup()
        {
            //arrange
        }

        [TestCleanup]
        public void Teardown()
        {
            //Вроде как GC должен сам собрать мусор
        }


        #region Извлечение корня тесты

        [TestCategory("SQRT") TestMethod]
        public void SQRT_Zero_Test()
        {
            //arrange

            //act
            Logics.Sqrt();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

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

        #region Обратная пропорциональность тестирование

        [TestCategory("Inverse") TestMethod]
        public void Inverse_Zero_Test()
        {
            //arrange

            //act
            Logics.Inverse();

            //assert
            Assert.AreEqual(Double.PositiveInfinity.ToString(), Logics.Data);
        }

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

        #region Проценты тестирование

        [TestCategory("Percent") TestMethod ExpectedException(typeof(Exception))]
        public void Percent_Zero_Test()
        {
            //arrange

            //act
            Logics.Percent();

            //assert
            Assert.Fail("Должно было быть выброшено исключение");
        }

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
    }
}
