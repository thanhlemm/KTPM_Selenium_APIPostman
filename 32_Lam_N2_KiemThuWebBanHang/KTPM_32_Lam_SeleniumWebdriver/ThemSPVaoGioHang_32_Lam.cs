
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace KTPM_32_Lam_SeleniumWebdriver
{
    [TestClass]
    public class ThemSPVaoGioHang_32_Lam
    {
        private IWebDriver driver_32_Lam;
        private PageHTML_32_Lam them_32_Lam;
        [TestInitialize]
        public void Setup()
        {
            driver_32_Lam = new ChromeDriver();
            driver_32_Lam.Manage().Window.Maximize();
            driver_32_Lam.Navigate().GoToUrl("https://whalishop.vn/products/ao-thun-new-era-vien-den");
            them_32_Lam = new PageHTML_32_Lam(driver_32_Lam);
        }

        [TestMethod]
        public void TC1_32_Lam_SoLuong1()
        {
            //TC1: Trang web hiển thị sẵn số lượng 1 người dùng chỉ cần click vào thêm vào giỏ hàng,
            //sau đó hệ thống sẽ hiển thị form giỏ hàng 
            them_32_Lam.SoLuong1_32_Lam();
            bool isErrorDisplayed_32_Lam = them_32_Lam.formcart_32_Lam.Displayed;
            Assert.IsTrue(isErrorDisplayed_32_Lam);
        }

        //-------------------------------------------------------------------------------------------------------------------
       

        [TestMethod]
        public void TC2_32_Lam_SoLuong0()
        {
            //TC2: Nhập số lượng là 0 sau đó click thêm vào giỏ sẽ hiện cảnh báo
            them_32_Lam.SoLuong_32_Lam("0");
            bool isErrorDisplayed_32_Lam = them_32_Lam.lbKQ_32_Lam.Displayed;
            Assert.IsTrue(isErrorDisplayed_32_Lam);
        }

        //-------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TC3_32_Lam_SoLuongKhac()
        {
            //TC3: Nhập số lượng sản phẩm vượt quá số lượng trong kho, website sẽ hiện cảnh báo 
            them_32_Lam.SoLuong_32_Lam("20000");

            // Kiểm tra xem cửa sổ cảnh báo có xuất hiện không
            IAlert alert_32_Lam = driver_32_Lam.SwitchTo().Alert();
            string alertText_32_Lam = alert_32_Lam.Text;
            string expectedAlertText_32_Lam = "Sản phẩm bạn vừa mua đã vượt quá tồn kho";
            Assert.AreEqual(expectedAlertText_32_Lam, alertText_32_Lam);
            // Xử lý cửa sổ cảnh báo bằng cách đóng nó
            alert_32_Lam.Accept();

        }

        //-------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void TC4_32_Lam_GioHangCoSanSP_SoLuong0()
        {
            //TC4: Thêm sản phẩm vào giỏ hàng với số lượng 1, sau đó lại thêm vào số lượng 0 
            them_32_Lam.SoLuong1_32_Lam();
            them_32_Lam.btnClose_32_Lam.Click();
            them_32_Lam.SoLuong_32_Lam("0");
            bool isErrorDisplayed_32_Lam = them_32_Lam.formcart_32_Lam.Displayed;
            Assert.IsTrue(isErrorDisplayed_32_Lam);

        }

        //-------------------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void TC5_32_Lam_GioHangCoSanSP_SoLuongTuyChon()
        {
            //TC5: Thêm sản phẩm vào giỏ hàng với số lượng 1, sau đó lại thêm vào số lượng 1 
            them_32_Lam.size_32_Lam.Click();
            them_32_Lam.sizeOption_32_Lam.Click();
            them_32_Lam.SoLuong1_32_Lam();
            them_32_Lam.btnClose_32_Lam.Click();
            
            them_32_Lam.SoLuong_32_Lam("1");

            string expected_32_Lam = "BẠN CÓ 2 SẢN PHẨM TRONG GIỎ HÀNG.";
            string actual_32_Lam = them_32_Lam.soLuong_32_Lam.Text.Trim();
            Thread.Sleep(3000);
            Assert.AreEqual(expected_32_Lam, actual_32_Lam);
        }

        //-------------------------------------------------------------------------------------------------------------------
       
        [TestMethod]
        public void TC6_32_Lam_GioHangCoSanSP_SoLuongKhac()
        {
            //TC6: Thêm sản phẩm vào giỏ hàng với số lượng 1, sau đó lại thêm vào số lượng vượt quá số lượng tồn kho 
            them_32_Lam.SoLuong1_32_Lam();
            them_32_Lam.btnClose_32_Lam.Click();

            them_32_Lam.SoLuong_32_Lam("20");

            //Kiểm tra xem cửa sổ cảnh báo có xuất hiện không
            IAlert alert_32_Lam = driver_32_Lam.SwitchTo().Alert();
            string alertText_32_Lam = alert_32_Lam.Text;
            string expectedAlertText_32_Lam = "Sản phẩm bạn vừa mua đã vượt quá tồn kho";
            Assert.AreEqual(expectedAlertText_32_Lam, alertText_32_Lam);
            //Xử lý cửa sổ cảnh báo bằng cách đóng nó
            alert_32_Lam.Accept();

        }
    }
}
