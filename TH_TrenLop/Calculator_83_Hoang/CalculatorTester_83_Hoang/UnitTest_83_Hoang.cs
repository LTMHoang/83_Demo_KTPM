using Calculator_83_Hoang;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester_83_Hoang
{
    [TestClass]
    public class UnitTest_83_Hoang
    {
        //Test với dữ liệu nhập sẵn
        private Calculation_83_Hoang c_83_Hoang;
        [TestInitialize] //thiết lập dữ liệu dùng chung cho TC
        public void SetUp_83_Hoang()
        {
            c_83_Hoang = new Calculation_83_Hoang(10, 5);
        }

        [TestMethod] //TC1: a_83_Hoang = 10, b_83_Hoang = 5, kq = 15
        public void Test_Cong_83_Hoang()
        {
            int expected_83_Hoang, actual_83_Hoang;
            expected_83_Hoang = 15;
            actual_83_Hoang = c_83_Hoang.Execute_83_Hoang("+");
            Assert.AreEqual(expected_83_Hoang, actual_83_Hoang);
        }

        [TestMethod] //TC1: a_83_Hoang = 10, b_83_Hoang = 5, kq = 5
        public void Test_Tru_83_Hoang()
        {
            int expected_83_Hoang, actual_83_Hoang;
            expected_83_Hoang = 5;
            actual_83_Hoang = c_83_Hoang.Execute_83_Hoang("-");
            Assert.AreEqual(expected_83_Hoang, actual_83_Hoang);
        }

        [TestMethod] //TC1: a_83_Hoang = 10, b_83_Hoang = 5, kq = 50
        public void Test_Nhan_83_Hoang()
        {
            int expected_83_Hoang, actual_83_Hoang;
            expected_83_Hoang = 50;
            actual_83_Hoang = c_83_Hoang.Execute_83_Hoang("*");
            Assert.AreEqual(expected_83_Hoang, actual_83_Hoang);
        }

        [TestMethod] //TC1: a_83_Hoang = 10, b_83_Hoang = 5, kq = 2
        public void Test_Chia_83_Hoang()
        {
            int expected_83_Hoang, actual_83_Hoang;
            expected_83_Hoang = 2;
            actual_83_Hoang = c_83_Hoang.Execute_83_Hoang("/");
            Assert.AreEqual(expected_83_Hoang, actual_83_Hoang);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero_83_Hoang()
        {
            c_83_Hoang = new Calculation_83_Hoang(10, 0);
            c_83_Hoang.Execute_83_Hoang("/");
        }


        //Test với dữ liệu đọc từ file .csv
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    "E:\\MY_STUDY\\CODE\\C#\\83_Demo_KTPM\\TH_TrenLop\\Calculator_83_Hoang\\CalculatorTester_83_Hoang\\Data_83_Hoang\\TestData_83_Hoang.csv", "TestData_83_Hoang#csv",
            DataAccessMethod.Sequential)]

        //Test với trường hợp cộng
        [TestMethod]
        public void TestWithDataSource_83_Hoang()
        {
            int a_83_Hoang = int.Parse(TestContext.DataRow[0].ToString());
            int b_83_Hoang = int.Parse(TestContext.DataRow[1].ToString());
            int expected_83_Hoang = int.Parse(TestContext.DataRow[2].ToString());

            Calculation_83_Hoang c_83_Hoang = new Calculation_83_Hoang(a_83_Hoang, b_83_Hoang);
            int actual_83_Hoang = c_83_Hoang.Execute_83_Hoang("+");
            Assert.AreEqual(expected_83_Hoang, actual_83_Hoang);
        }

        //Bài 1
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    "E:\\MY_STUDY\\CODE\\C#\\83_Demo_KTPM\\TH_TrenLop\\Calculator_83_Hoang\\CalculatorTester_83_Hoang\\Data_83_Hoang\\DataTest_cotToantu.csv",
                    "DataTest_cotToanTu#csv",
            DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestWithDataSource_Bai1_83_Hoang()
        {
            int a_83_Hoang = int.Parse(TestContext.DataRow[0].ToString());
            int b_83_Hoang = int.Parse(TestContext.DataRow[1].ToString());
            //Thêm remove để xóa ký tự ' trong file .csv
            string operation_83_Hoang = TestContext.DataRow[2].ToString().Remove(0, 1);
            int expected_83_Hoang = int.Parse(TestContext.DataRow[3].ToString());

            Calculation_83_Hoang c_83_Hoang = new Calculation_83_Hoang(a_83_Hoang, b_83_Hoang);
            int actual_83_Hoang = c_83_Hoang.Execute_83_Hoang(operation_83_Hoang);
            Assert.AreEqual(expected_83_Hoang, actual_83_Hoang);
        }

        //Bài 2
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    "E:\\MY_STUDY\\CODE\\C#\\83_Demo_KTPM\\TH_TrenLop\\Calculator_83_Hoang\\CalculatorTester_83_Hoang\\Data_83_Hoang\\TestData_Xn_83_Hoang.csv", "TestData_Xn_83_Hoang#csv",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource_Bai2_83_Hoang()
        {
            double x_83_Hoang = double.Parse(TestContext.DataRow[0].ToString());
            int n_83_Hoang = int.Parse(TestContext.DataRow[1].ToString());

            double expected_83_Hoang = double.Parse(TestContext.DataRow[2].ToString());

            double actual_83_Hoang = Power_83_Hoang.Power_83(x_83_Hoang, n_83_Hoang);
            Assert.AreEqual(expected_83_Hoang, actual_83_Hoang);
        }
    }
}
