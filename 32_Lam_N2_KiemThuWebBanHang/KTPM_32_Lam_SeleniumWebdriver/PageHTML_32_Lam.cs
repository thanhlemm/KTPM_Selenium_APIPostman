using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;


namespace KTPM_32_Lam_SeleniumWebdriver
{
     public class PageHTML_32_Lam
    {
        public IWebDriver driver_32_Lam;
        public PageHTML_32_Lam(IWebDriver browser_32_Lam)
        {
            driver_32_Lam = browser_32_Lam;
        }

        //ĐĂNG NHẬP-------------------------------------------------------------------

        //ô nhập email
        private IWebElement txtEmail_32_Lam => driver_32_Lam.FindElement(By.Id("customer_email"));

        //ô nhập password
        private IWebElement txtPass_32_Lam => driver_32_Lam.FindElement(By.Name("customer[password]"));

        //nút đăng nhập
        private IWebElement btnLoginClick_32_Lam => driver_32_Lam.FindElement(By.ClassName("btn"));

        public void InputDangNhap_32_Lam(string email, string pass) 
        {
            //Gửi dữ liệu thông qua SendKeys
            txtEmail_32_Lam.SendKeys(email);
            txtPass_32_Lam.SendKeys(pass);
            Thread.Sleep(2000);
            btnLoginClick_32_Lam.Click();
            Thread.Sleep(5000);
        }

        //Phần tử div xuất hiện lỗi sau khi nhập sai email hoặc password
        public IWebElement divError_32_Lam => driver_32_Lam.FindElement(By.CssSelector("div[class = 'errors']"));
        
        //TÌM KIẾM----------------------------------------------------------------------------
        //Thanh tìm kiếm
        private IWebElement inputSearch_32_Lam => driver_32_Lam.FindElement(By.CssSelector("input[placeholder='Tìm kiếm...']"));

        public void NhapTimKiem_32_Lam(string word_32_Lam)
        {
            inputSearch_32_Lam.SendKeys(word_32_Lam);
            Thread.Sleep(2000);
            inputSearch_32_Lam.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }


        //thanh tìm kiếm lớn
        public IWebElement boxSearch_32_Lam => driver_32_Lam.FindElement(By.ClassName("search_box"));

        //THÊM VÀO GIỎ HÀNG---------------------------------------------------------------------
        
        //ô nhập số lượng
        private IWebElement txtSoLuong => driver_32_Lam.FindElement(By.XPath("//*[@id=\"quantity\"]"));

        //nút thêm vào giỏ hàng
        private IWebElement btnThem_32_Lam => driver_32_Lam.FindElement(By.Id("add-to-cart"));
        public void SoLuong1_32_Lam()
        {
            btnThem_32_Lam.Click();
            Thread.Sleep(5000);

        }

        public void SoLuong_32_Lam(string sl_32_Lam)
        {
            //Xóa dữ liệu hiện có trong ô
            txtSoLuong.Clear();
            //Gửi dữ liệu mới vào ô
            txtSoLuong.SendKeys(sl_32_Lam);
            btnThem_32_Lam.Click();
            Thread.Sleep(5000);
        }

        //form giỏ hàng
        public IWebElement formcart_32_Lam => driver_32_Lam.FindElement(By.CssSelector("form[id = 'cartform']"));

        //thành phần div chứa cảnh báo 
        public IWebElement lbKQ_32_Lam => driver_32_Lam.FindElement(By.CssSelector("div[class='modal-dialog modal-lg']"));

        //Nút đóng form giỏ hàng
        public IWebElement btnClose_32_Lam => driver_32_Lam.FindElement(By.CssSelector("span[class = 'hrv-close-modal']"));

        //Thành phần div check số lượng
        public IWebElement soLuong_32_Lam => driver_32_Lam.FindElement(By.Id("exampleModalLabel"));

        //Đổi size
        public IWebElement size_32_Lam => driver_32_Lam.FindElement(By.Id("product-select-option-0"));
        public IWebElement sizeOption_32_Lam => driver_32_Lam.FindElement(By.CssSelector(" option[value='M']"));
    }
}
