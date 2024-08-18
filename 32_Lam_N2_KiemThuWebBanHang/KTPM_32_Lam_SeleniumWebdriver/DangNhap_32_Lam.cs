
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace KTPM_32_Lam_SeleniumWebdriver
{
    [TestClass]
    public class DangNhap_32_Lam
    {
        private IWebDriver driver_32_Lam;
        private PageHTML_32_Lam login_32_Lam;
        [TestInitialize]
        public void Setup()
        {
            driver_32_Lam = new ChromeDriver();
            driver_32_Lam.Manage().Window.Maximize();
            driver_32_Lam.Navigate().GoToUrl("https://whalishop.vn/account/login");
            login_32_Lam = new PageHTML_32_Lam(driver_32_Lam);
        }

        

        [TestMethod]
        public void TC1_32_Lam_NhapDungEmailPassWord()
        //TC1: Nhập đúng email và password sau đó hệ thống sẽ hiển thị thông tin tài khoản của KH  
        {
            login_32_Lam.InputDangNhap_32_Lam("tan036075@gmail.com", "TThanhlemmilk212");
            string expected_url_32_Lam = "https://whalishop.vn/account";
            string actual_url_32_Lam = driver_32_Lam.Url;
            Thread.Sleep(3000);
            Assert.AreEqual(expected_url_32_Lam, actual_url_32_Lam);
        }

        //-----------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TC2_32_Lam_NhapThieuPass()
        //TC2: Nhập thiếu password sau đó hệ thống sẽ cảnh báo  
        {
            login_32_Lam.InputDangNhap_32_Lam("tan036075@gmail.com", "");
            string expected_url_32_Lam = "https://whalishop.vn/account/login";
            string actual_url_32_Lam = driver_32_Lam.Url;
            Thread.Sleep(3000);
            Assert.AreEqual(expected_url_32_Lam, actual_url_32_Lam);
        }

        //-------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TC3_32_Lam_NhapThieuEmail()
        //TC3: Nhập thiếu email sau đó hệ thống sẽ cảnh báo  
        {
            login_32_Lam.InputDangNhap_32_Lam("", "TThanhlemmilk212");
            string expected_url_32_Lam = "https://whalishop.vn/account/login";
            string actual_url_32_Lam = driver_32_Lam.Url;
            Thread.Sleep(3000);
            Assert.AreEqual(expected_url_32_Lam, actual_url_32_Lam);
        }

        //-------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TC4_32_Lam_KhongNhapEmailPassword()
        //TC4: Không nhập email và pass sau đó hệ thống sẽ cảnh báo  
        {
            login_32_Lam.InputDangNhap_32_Lam("", "");
            string expected_url_32_Lam = "https://whalishop.vn/account/login";
            string actual_url_32_Lam = driver_32_Lam.Url;
            Thread.Sleep(3000);
            Assert.AreEqual(expected_url_32_Lam, actual_url_32_Lam);
        }

        //-------------------------------------------------------------------------------------------------------------------
        
        [TestMethod]
        public void TC5_32_Lam_NhapSaiEmail()
        //TC5: Nhập email chưa đăng ký sau đó hệ thống sẽ kiểm tra và thông báo "Thông tin đăng nhập không hợp lệ" 
        {
            login_32_Lam.InputDangNhap_32_Lam("lam036075@gmail.com", "TThanhlemmilk212");
            bool isErrorDisplayed = login_32_Lam.divError_32_Lam.Displayed;
            Assert.IsTrue(isErrorDisplayed);
        }

        //-------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TC6_32_Lam_NhapSaiPass()
        //TC6: Nhập sai pass sau đó hệ thống sẽ kiểm tra và thông báo "Thông tin đăng nhập không hợp lệ" 
        {
            login_32_Lam.InputDangNhap_32_Lam("tan036075@gmail.com", "123");
            bool isErrorDisplayed = login_32_Lam.divError_32_Lam.Displayed;
            Assert.IsTrue(isErrorDisplayed);
        }

        //-------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TC7_32_Lam_NhapEmailKhongHopLe()
        //TC7: Nhập email thiếu @ sau đó hệ thống sẽ cảnh báo  
        {
            login_32_Lam.InputDangNhap_32_Lam("tan036075gmail.com", "TThanhlemmilk212");
            string expected_url_32_Lam = "https://whalishop.vn/account/login";
            string actual_url_32_Lam = driver_32_Lam.Url;
            Thread.Sleep(3000);
            Assert.AreEqual(expected_url_32_Lam, actual_url_32_Lam);
        }
    }
}
