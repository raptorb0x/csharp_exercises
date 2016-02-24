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
    /// Тесты базовой арифметики
    /// </summary>
    [TestClass]
    public class Logics_Arifmetic_Tests
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

        #region Тестирование сложения чисел

        /// <summary>
        /// Сложение числа и числа
        /// </summary>
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

        /// <summary>
        /// Сложение числа и отрицательного числа
        /// </summary>
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

        /// <summary>
        /// Сложение нуля и числа
        /// </summary>
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

        /// <summary>
        /// Сложение чсила с нулем
        /// </summary>
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

        /// <summary>
        /// Сложение число и числа с запятой
        /// </summary>
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

        /// <summary>
        /// Сложения числа с запятой и числа
        /// </summary>
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

        /// <summary>
        /// Сложение числел с запятыми
        /// </summary>
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

        //-----------------------------------------------------------------------

        #region Тестирование вычитания чисел

        /// <summary>
        /// Вычитание чисел
        /// </summary>
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

        /// <summary>
        /// Вычитание отрицательного числа
        /// </summary>
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

        /// <summary>
        /// Вчитание числа из нуля
        /// </summary>
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

        /// <summary>
        /// Вычитание нуля из числа
        /// </summary>
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

        /// <summary>
        /// Вычитание из числа числа с запятой
        /// </summary>
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

        /// <summary>
        /// ВЫчитание из числа с запятой числа
        /// </summary>
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

        /// <summary>
        /// Вычитание из числа с запятой число с запятой
        /// </summary>
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

        //-----------------------------------------------------------------------

        #region Тестирование умножения чисел

        /// <summary>
        /// Умножение чисел
        /// </summary>
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

        /// <summary>
        /// Умножение на отрицательное число
        /// </summary>
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

        /// <summary>
        /// Умножение нуля на число
        /// </summary>
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

        /// <summary>
        /// Умножение числа на ноль
        /// </summary>
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

        /// <summary>
        /// Перемножение нулей
        /// </summary>
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

        /// <summary>
        /// Умножение числа на число с запятой
        /// </summary>
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

        /// <summary>
        /// Умножение числа с запятой на число
        /// </summary>
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

        /// <summary>
        /// Перемножение чисел с запятой
        /// </summary>
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

        //-----------------------------------------------------------------------

        #region Тестирование деления чисел

        /// <summary>
        /// Деление чисел
        /// </summary>
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

        /// <summary>
        /// Деление числа на отрицательное
        /// </summary>
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

        /// <summary>
        /// Деление нуля на число
        /// </summary>
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

        /// <summary>
        /// Деление числа на ноль - воспользуемся тем, что double может в бесконечность
        /// </summary>
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

        /// <summary>
        /// Деление нуля на ноль - результат не определен
        /// </summary>
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
            Assert.IsTrue(double.IsNaN(double.Parse(Logics.Data)));
        }

        /// <summary>
        /// Деление числа на число с запятой
        /// </summary>
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

        /// <summary>
        /// Деление числа с запятой на число
        /// </summary>
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

        /// <summary>
        /// Деление числда с запятой на число с запятой
        /// </summary>
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

        //-----------------------------------------------------------------------
    }
}
