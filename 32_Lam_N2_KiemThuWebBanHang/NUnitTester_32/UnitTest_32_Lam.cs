using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit_32_ThanhLam;

namespace NUnitTester_32_Lam
{
    [TestClass]
    public class UnitTest_32_Lam
    {
        private Calculation_32_Lam c;
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void Setup()
        {
            c = new Calculation_32_Lam(7, 8);

        }
        [TestMethod] //TC1: kq= 225
        public void TC1_bptong_32_Lam()
        {
            double expected, actual;
            expected = 225;
            actual = c.Excute_32_Lam("(A+B)^2");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC2:  kq=1
        public void TC2_bphieu_32_Lam()
        {
            double expected, actual;
            expected = 1;
            actual = c.Excute_32_Lam("(A-B)^2");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC3:  kq=-15
        public void TC3_hieu2bp_32_Lam()
        {
            double expected, actual;
            expected = -15;
            actual = c.Excute_32_Lam("A^2 - B^2");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC4: kq=3375
        public void TC4_lptong_32_Lam()
        {
            double expected, actual;
            expected = 3375;
            actual = c.Excute_32_Lam("(A+B)^3");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC5: kq=-1
        public void TC5_lphieu_32_Lam()
        {
            double expected, actual;
            expected = -1;
            actual = c.Excute_32_Lam("(A-B)^3");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC6: kq=855
        public void TC6_tong2lp_32_Lam()
        {
            double expected, actual;
            expected = 855;
            actual = c.Excute_32_Lam("A^3 + B^3");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC7: kq=-169
        public void TC7_hieu2lp_32_Lam()
        {
            double expected, actual;
            expected = -169;
            actual = c.Excute_32_Lam("A^3 - B^3");
            Assert.AreEqual(expected, actual);
        }

        //Liên kết Test data với project
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data_32_Lam\TestData_32_Lam.csv", "TestData_32_Lam#csv", DataAccessMethod.Sequential)]

        public void TC8_TestWithDataSource_32_Lam()
        {
            int a, b ;
            Double expected, actual;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            expected = Double.Parse(TestContext.DataRow[3].ToString());
            
            c = new Calculation_32_Lam(a, b);
            actual = c.Excute_32_Lam(operation);
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod1()
        {
        }
    }
}
