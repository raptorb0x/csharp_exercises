using System;
using Calc_tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc_testsTests
{
    [TestClass]
    public class Logics_Arifmetic_Tests
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

        #region Тестирования сложения чисел
        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Add_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('+');
            lLogic.addDigit('2');
            lLogic.Equality();
            
            //assert
            Assert.AreEqual("3", lLogic.Calc);
        }
        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Zero_Add_Number()
        {
            //arrange

            //act
            lLogic.addDigit('0');
            lLogic.Oper('+');
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("2", lLogic.Calc);
        }
        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Add_Zero()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('+');
            lLogic.addDigit('0');
            lLogic.Equality();

            //assert
            Assert.AreEqual("1", lLogic.Calc);
        }

        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Add_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('+');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("1,2", lLogic.Calc);
        }

        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Comma_Add_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Oper('+');
            lLogic.addDigit('3');
            lLogic.Equality();

            //assert
            Assert.AreEqual("4,2", lLogic.Calc);
        }

        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Comma_Add_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Oper('+');
            lLogic.addDigit('3');
            lLogic.Comma();
            lLogic.addDigit('0');
            lLogic.addDigit('4');
            lLogic.Equality();

            //assert
            Assert.AreEqual("4,24", lLogic.Calc);
        }
        #endregion


        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Add_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('+');
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("3", lLogic.Calc);
        }
        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Zero_Add_Number()
        {
            //arrange

            //act
            lLogic.addDigit('0');
            lLogic.Oper('+');
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("2", lLogic.Calc);
        }
        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Add_Zero()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('+');
            lLogic.addDigit('0');
            lLogic.Equality();

            //assert
            Assert.AreEqual("1", lLogic.Calc);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Add_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('+');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("1,2", lLogic.Calc);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Comma_Add_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Oper('+');
            lLogic.addDigit('3');
            lLogic.Equality();

            //assert
            Assert.AreEqual("4,2", lLogic.Calc);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Comma_Add_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Oper('+');
            lLogic.addDigit('3');
            lLogic.Comma();
            lLogic.addDigit('0');
            lLogic.addDigit('4');
            lLogic.Equality();

            //assert
            Assert.AreEqual("4,24", lLogic.Calc);
        }

    }
}
