using _83_Hoang_Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _83_CalculatorTester
{
    [TestClass]
    //public class UnitTest1
    //{
    //    [TestMethod]
    //    public void TestMethod1()
    //    {
    //    }
    //}
    public class UnitTest_83 
    {
        private Calculation_83 c_83;
        [TestInitialize] //thiết lập dữ liệu dùng chung cho TC
        public void SetUp_83() 
        {
            c_83 = new Calculation_83(10, 5);
        }
        [TestMethod] //TC1: a_83 = 10, b_83 = 5, kq = 15
        public void Test_Cong_83()
        {
            int expected_83, actual_83;
            expected_83 = 15;
            actual_83 = c_83.Execute_83("+");
            Assert.AreEqual(expected_83, actual_83);
        }

        [TestMethod] //TC1: a_83 = 10, b_83 = 5, kq = 5
        public void Test_Tru_83()
        {
            int expected_83, actual_83;
            expected_83 = 5;
            actual_83 = c_83.Execute_83("-");
            Assert.AreEqual(expected_83, actual_83);
        }

        [TestMethod] //TC1: a_83 = 10, b_83 = 5, kq = 50
        public void Test_Nhan_83()
        {
            int expected_83, actual_83;
            expected_83 = 50;
            actual_83 = c_83.Execute_83("*");
            Assert.AreEqual(expected_83, actual_83);
        }

        [TestMethod] //TC1: a_83 = 10, b_83 = 5, kq = 2
        public void Test_Chia_83()
        {
            int expected_83, actual_83;
            expected_83 = 2;
            actual_83 = c_83.Execute_83("/");
            Assert.AreEqual(expected_83, actual_83);
        }

        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero_83()
        {
            c_83 = new Calculation_83(10, 0);
            c_83.Execute_83("/");
        }
    }
}
