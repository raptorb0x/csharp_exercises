using System;
using Calc_Logics;
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

        #region Тестирование сложения чисел
        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Add_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('+');
            Logics.addDigit('2');
            Logics.Equality();
            
            //assert
            Assert.AreEqual("3", Logics.Data);
        }

        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Add_Number_Negative()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('+');
            Logics.addDigit('2');
            Logics.Sign();
            Logics.Equality();

            //assert
            Assert.AreEqual("-1", Logics.Data);
        }

        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Zero_Add_Number()
        {
            //arrange

            //act
            Logics.addDigit('0');
            Logics.Oper('+');
            Logics.addDigit('2');
            Logics.Equality();

            //assert
            Assert.AreEqual("2", Logics.Data);
        }

        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Add_Zero()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('+');
            Logics.addDigit('0');
            Logics.Equality();

            //assert
            Assert.AreEqual("1", Logics.Data);
        }

        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Add_Number_Comma()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('+');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Equality();

            //assert
            Assert.AreEqual("1,2", Logics.Data);
        }

        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Comma_Add_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Oper('+');
            Logics.addDigit('3');
            Logics.Equality();

            //assert
            Assert.AreEqual("4,2", Logics.Data);
        }

        [TestCategory("Arifmetic_Add") TestMethod]
        public void AddTest_Number_Comma_Add_Number_Comma()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Oper('+');
            Logics.addDigit('3');
            Logics.Comma();
            Logics.addDigit('0');
            Logics.addDigit('4');
            Logics.Equality();

            //assert
            Assert.AreEqual("4,24", Logics.Data);
        }

        #endregion

        #region Тестирование вычитания чисел
        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Sub_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('-');
            Logics.addDigit('2');
            Logics.Equality();

            //assert
            Assert.AreEqual("-1", Logics.Data);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Sub_Number_Negative()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('-');
            Logics.addDigit('2');
            Logics.Sign();
            Logics.Equality();

            //assert
            Assert.AreEqual("3", Logics.Data);
        }
        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Zero_Sub_Number()
        {
            //arrange

            //act
            Logics.addDigit('0');
            Logics.Oper('-');
            Logics.addDigit('2');
            Logics.Equality();

            //assert
            Assert.AreEqual("-2", Logics.Data);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Sub_Zero()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('-');
            Logics.addDigit('0');
            Logics.Equality();

            //assert
            Assert.AreEqual("1", Logics.Data);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Sub_Number_Comma()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('-');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Equality();

            //assert
            Assert.AreEqual("0,8", Logics.Data);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Comma_Sub_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Oper('-');
            Logics.addDigit('3');
            Logics.Equality();

            //assert
            Assert.AreEqual("-1,8", Logics.Data);
        }

        [TestCategory("Arifmetic_Sub") TestMethod]
        public void SubTest_Number_Comma_Sub_Number_Comma()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Oper('-');
            Logics.addDigit('3');
            Logics.Comma();
            Logics.addDigit('0');
            Logics.addDigit('4');
            Logics.Equality();

            //assert
            Assert.AreEqual("-1,84", Logics.Data);
        }
        #endregion

        #region Тестирование умножения чисел
        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Mult_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('*');
            Logics.addDigit('2');
            Logics.Equality();

            //assert
            Assert.AreEqual("2", Logics.Data);
        }

        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Mult_Number_Negative()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('*');
            Logics.addDigit('2');
            Logics.Sign();
            Logics.Equality();

            //assert
            Assert.AreEqual("-2", Logics.Data);
        }
        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Zero_Mult_Number()
        {
            //arrange

            //act
            Logics.addDigit('0');
            Logics.Oper('*');
            Logics.addDigit('2');
            Logics.Equality();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Mult_Zero()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('*');
            Logics.addDigit('0');
            Logics.Equality();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Zero_Mult_Zero()
        {
            //arrange

            //act
            Logics.addDigit('0');
            Logics.Oper('*');
            Logics.addDigit('0');
            Logics.Equality();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Mult_Number_Comma()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('*');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Equality();

            //assert
            Assert.AreEqual("0,2", Logics.Data);
        }

        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Comma_Mult_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Oper('*');
            Logics.addDigit('3');
            Logics.Equality();

            //assert
            Assert.AreEqual("3,6", Logics.Data);
        }

        [TestCategory("Arifmetic_Mult") TestMethod]
        public void MultTest_Number_Comma_Mult_Number_Comma()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Oper('*');
            Logics.addDigit('3');
            Logics.Comma();
            Logics.addDigit('0');
            Logics.addDigit('4');
            Logics.Equality();

            //assert
            Assert.AreEqual("3,648", Logics.Data);
        }
        #endregion

        #region Тестирование деления чисел
        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Div_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('/');
            Logics.addDigit('2');
            Logics.Equality();

            //assert
            Assert.AreEqual("0,5", Logics.Data);
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Div_Number_Negative()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('/');
            Logics.addDigit('2');
            Logics.Sign();
            Logics.Equality();

            //assert
            Assert.AreEqual("-0,5", Logics.Data);
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Zero_Div_Number()
        {
            //arrange

            //act
            Logics.addDigit('0');
            Logics.Oper('/');
            Logics.addDigit('2');
            Logics.Equality();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Div_Zero()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('/');
            Logics.addDigit('0');
            Logics.Equality();
            
            //assert
            Assert.IsTrue(double.IsPositiveInfinity(double.Parse(Logics.Data)));
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Zero_Div_Zero()
        {
            //arrange

            //act
            Logics.addDigit('0');
            Logics.Oper('/');
            Logics.addDigit('0');
            Logics.Equality();

            //assert
            Assert.AreEqual("0", Logics.Data);
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Div_Number_Comma()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Oper('/');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Equality();

            //assert
            Assert.AreEqual("5", Logics.Data);
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Comma_Div_Number()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Oper('/');
            Logics.addDigit('3');
            Logics.Equality();

            //assert
            Assert.AreEqual("0,4", Logics.Data);
        }

        [TestCategory("Arifmetic_Div") TestMethod]
        public void DivTest_Number_Comma_Div_Number_Comma()
        {
            //arrange

            //act
            Logics.addDigit('1');
            Logics.Comma();
            Logics.addDigit('2');
            Logics.Oper('/');
            Logics.addDigit('4');
            Logics.Comma();
            Logics.addDigit('8');
            Logics.Equality();

            //assert
            Assert.AreEqual("0,25", Logics.Data);
        }
        #endregion
    }
}
