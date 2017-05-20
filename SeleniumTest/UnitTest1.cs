using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        private static string Url = "http://linkedin.com";

        [TestMethod]
        public void LoginVerification() 
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            var username = driver.FindElementById("login-email");
            var password = driver.FindElementById("login-password");
            var loginBtn = driver.FindElementById("login-submit");

            username.SendKeys("email");
            password.SendKeys("pass");
            loginBtn.Click();

            driver.Navigate().Refresh();

            var logoutEl = driver.FindElementByClassName("nav-item__dropdown-trigger--title");
            var check = false;

            if (logoutEl != null)
            {
                if (!logoutEl.Text.Equals("Me"))
                {
                    check = true;
                }
            }

            Assert.Equals(check, true);
        }
    }
}
