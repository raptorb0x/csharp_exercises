using System;
using Calc_Logics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc_testsTests
{
    [TestClass]
    public class Logics_adMath_Tests
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


        #region Извлечение корня тесты

        [TestCategory("SQRT") TestMethod]
        public void SQRT_Zero_Test()
        {
            //arrange

            //act
            lLogic.Sqrt();

            //assert
            Assert.AreEqual("0", lLogic.Data);
        }

        [TestCategory("SQRT") TestMethod]
        public void SQRT_Number_Test()
        {
            //arrange

            //act
            lLogic.addDigit('9');
            lLogic.Sqrt();

            //assert
            Assert.AreEqual("3", lLogic.Data);
        }

        [TestCategory("SQRT") TestMethod ExpectedException(typeof(Exception))]
        public void SQRT_Neg_Number_Test()
        {
            //arrange

            //act
            lLogic.addDigit('9');
            lLogic.Sign();
            lLogic.Sqrt();

            //assert
            Assert.Fail("Должно было быть выброшено исключение");
        }

        [TestCategory("SQRT") TestMethod ]
        public void SQRT_In_Oper_Number_Test()
        {
            //arrange

            //act
            lLogic.addDigit('3');
            lLogic.Oper('*');
            lLogic.addDigit('9');
            lLogic.Sqrt();
            lLogic.Equality();

            //assert
            Assert.AreEqual("9", lLogic.Data);
        }
        [TestCategory("SQRT") TestMethod]
        public void SQRT_Number_Comma_Test()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('4');
            lLogic.addDigit('4');
            lLogic.Sqrt();

            //assert
            Assert.AreEqual("1,2", lLogic.Data);
        }

        #endregion

        #region Обратная пропорциональность тестирование

        [TestCategory("Inverse") TestMethod]
        public void Inverse_Zero_Test()
        {
            //arrange

            //act
            lLogic.Inverse();

            //assert
            Assert.AreEqual("0", lLogic.Data);
        }

        [TestCategory("Inverse") TestMethod]
        public void Inverse_Number_Test()
        {
            //arrange

            //act
            lLogic.addDigit('5');
            lLogic.Inverse();

            //assert
            Assert.AreEqual("0,2", lLogic.Data);
        }

        [TestCategory("Inverse") TestMethod]
        public void Inverse_Neg_Number_Test()
        {
            //arrange

            //act
            lLogic.addDigit('5');
            lLogic.Sign();
            lLogic.Inverse();

            //assert
            Assert.AreEqual("-0,2", lLogic.Data);
        }

        [TestCategory("Inverse") TestMethod]
        public void Inverse_In_Oper_Number_Test()
        {
            //arrange

            //act
            lLogic.addDigit('4');
            lLogic.Oper('*');
            lLogic.addDigit('4');
            lLogic.Inverse();
            lLogic.Equality();

            //assert
            Assert.AreEqual("1", lLogic.Data);
        }
        [TestCategory("Inverse") TestMethod]
        public void Inverse_Number_Comma_Test()
        {
            //arrange

            //act
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.addDigit('5');
            lLogic.Inverse();
            lLogic.Equality();

            //assert
            Assert.AreEqual("4", lLogic.Data);
        }

        #endregion
    }
}
