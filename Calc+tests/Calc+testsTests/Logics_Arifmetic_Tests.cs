using System;
using Calc_tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//-----------------------------------------------------
//Тесты изначально писались без имерения покрытия, а на основе вариантов условий
//В результате имеем избыточность , но "Лучше плохие тесты, чем никаких тестов" (с) Martin Fowler
//------------------------------------------------------


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

        #region Тестирование сложения чисел
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
            Assert.AreEqual("3", lLogic.Data);
        }

        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Add_Number_Negative()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('+');
            lLogic.addDigit('2');
            lLogic.Sign();
            lLogic.Equality();

            //assert
            Assert.AreEqual("-1", lLogic.Data);
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
            Assert.AreEqual("2", lLogic.Data);
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
            Assert.AreEqual("1", lLogic.Data);
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
            Assert.AreEqual("1,2", lLogic.Data);
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
            Assert.AreEqual("4,2", lLogic.Data);
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
            Assert.AreEqual("4,24", lLogic.Data);
        }

        #endregion

        #region Тестирование вычитания чисел
        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Sub_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('-');
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("-1", lLogic.Data);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Sub_Number_Negative()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('-');
            lLogic.addDigit('2');
            lLogic.Sign();
            lLogic.Equality();

            //assert
            Assert.AreEqual("3", lLogic.Data);
        }
        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Zero_Sub_Number()
        {
            //arrange

            //act
            lLogic.addDigit('0');
            lLogic.Oper('-');
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("-2", lLogic.Data);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Sub_Zero()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('-');
            lLogic.addDigit('0');
            lLogic.Equality();

            //assert
            Assert.AreEqual("1", lLogic.Data);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Sub_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('-');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("0,8", lLogic.Data);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Comma_Sub_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Oper('-');
            lLogic.addDigit('3');
            lLogic.Equality();

            //assert
            Assert.AreEqual("-1,8", lLogic.Data);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Comma_Sub_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Oper('-');
            lLogic.addDigit('3');
            lLogic.Comma();
            lLogic.addDigit('0');
            lLogic.addDigit('4');
            lLogic.Equality();

            //assert
            Assert.AreEqual("-1,84", lLogic.Data);
        }
        #endregion

        #region Тестирование умножения чисел
        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Mult_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('*');
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("2", lLogic.Data);
        }

        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Mult_Number_Negative()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('*');
            lLogic.addDigit('2');
            lLogic.Sign();
            lLogic.Equality();

            //assert
            Assert.AreEqual("-2", lLogic.Data);
        }
        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Zero_Mult_Number()
        {
            //arrange

            //act
            lLogic.addDigit('0');
            lLogic.Oper('*');
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("0", lLogic.Data);
        }

        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Mult_Zero()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('*');
            lLogic.addDigit('0');
            lLogic.Equality();

            //assert
            Assert.AreEqual("0", lLogic.Data);
        }

        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Mult_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('*');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("0,2", lLogic.Data);
        }

        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Comma_Mult_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Oper('*');
            lLogic.addDigit('3');
            lLogic.Equality();

            //assert
            Assert.AreEqual("3,6", lLogic.Data);
        }

        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Comma_Mult_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Oper('*');
            lLogic.addDigit('3');
            lLogic.Comma();
            lLogic.addDigit('0');
            lLogic.addDigit('4');
            lLogic.Equality();

            //assert
            Assert.AreEqual("3,648", lLogic.Data);
        }
        #endregion

        #region Тестирование деления чисел
        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Div_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('/');
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("0,5", lLogic.Data);
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Div_Number_Negative()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('/');
            lLogic.addDigit('2');
            lLogic.Sign();
            lLogic.Equality();

            //assert
            Assert.AreEqual("-0,5", lLogic.Data);
        }
        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Zero_Div_Number()
        {
            //arrange

            //act
            lLogic.addDigit('0');
            lLogic.Oper('/');
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("0", lLogic.Data);
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Div_Zero()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('/');
            lLogic.addDigit('0');
            lLogic.Equality();
            
            //assert
            Assert.IsTrue(double.IsPositiveInfinity(double.Parse(lLogic.Data)));
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Div_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Oper('/');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Equality();

            //assert
            Assert.AreEqual("5", lLogic.Data);
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Comma_Div_Number()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Oper('/');
            lLogic.addDigit('3');
            lLogic.Equality();

            //assert
            Assert.AreEqual("0,4", lLogic.Data);
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Comma_Div_Number_Comma()
        {
            //arrange

            //act
            lLogic.addDigit('1');
            lLogic.Comma();
            lLogic.addDigit('2');
            lLogic.Oper('/');
            lLogic.addDigit('4');
            lLogic.Comma();
            lLogic.addDigit('8');
            lLogic.Equality();

            //assert
            Assert.AreEqual("0,25", lLogic.Data);
        }
        #endregion
    }
}
