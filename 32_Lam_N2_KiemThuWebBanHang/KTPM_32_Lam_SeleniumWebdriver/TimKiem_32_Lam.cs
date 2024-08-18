
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace KTPM_32_Lam_SeleniumWebdriver
{
    [TestClass]
    public class TimKiem_32_Lam
    {
        private IWebDriver driver_32_Lam;
        private PageHTML_32_Lam search_32_Lam;
        [TestInitialize]
        public void Setup()
        {
            driver_32_Lam = new ChromeDriver();
            driver_32_Lam.Manage().Window.Maximize();
            driver_32_Lam.Navigate().GoToUrl("https://whalishop.vn/");
            search_32_Lam = new PageHTML_32_Lam(driver_32_Lam);
        }

        [TestMethod]
        public void TC1_32_Lam_NhapTimKiem()
        //TC1: Nhập tìm kiếm sau đó hệ thống sẽ hiện danh sách sản phẩm có liên quan đến từ khóa   
        {
            search_32_Lam.NhapTimKiem_32_Lam("Ao");
            string expected_url_32_Lam = "https://whalishop.vn/search?type=product&q=Ao";
            string actual_url_32_Lam = driver_32_Lam.Url;
            Thread.Sleep(3000);
            Assert.AreEqual(expected_url_32_Lam, actual_url_32_Lam);
        }

        //-------------------------------------------------------------------------------------------------------------------
        

        [TestMethod]
        public void TC2_32_Lam_NhapTimKiemRong()
        //TC2: Không nhập tìm kiếm sau đó hệ thống sẽ hiện lại thanh tìm kiếm khác   
        {
            search_32_Lam.NhapTimKiem_32_Lam("");
            bool isErrorDisplayed_32_Lam = search_32_Lam.boxSearch_32_Lam.Displayed;
            Assert.IsTrue(isErrorDisplayed_32_Lam);
        }

    }
}
