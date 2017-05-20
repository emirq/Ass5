using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Assignment5
{
    class Program
    {
        private static string Url = "http://linkedin.com";


        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            var username = driver.FindElementById("login-email");
            var password = driver.FindElementById("login-password");
            var loginBtn = driver.FindElementById("login-submit");
            


            username.SendKeys("sk4yb3n@gmail.com");
            password.SendKeys("Ikbhsiqlfg123");
            loginBtn.Click();

            driver.Navigate().Refresh();
            var logoutEl = driver.FindElementByClassName("nav-item__dropdown-trigger--title");

            if (!logoutEl.Text.Equals("Me"))
            {
                Console.WriteLine("Ne valja");
            }

        }
    }
}
