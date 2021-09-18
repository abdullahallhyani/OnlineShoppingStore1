using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            
            IWebDriver driver = new FirefoxDriver("./");
            //driver.Url = "http://www.google.com";

             //driver.Url = "https://www.dominos.sa/ar/pages/order/menu#!/menu/category/pizza/";
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //-- driver.FindElement(By.ClassName("media__image productImage")).Click();



            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.dominos.sa/ar/pages/customer/#!/customer/login/";
            //driver.Url = "https://localhost:44328/Home/Index/";

            //driver.FindElement(By.LinkText("customerLoginPage"));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Email")).SendKeys("abdullah.s.allhyani@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("Aa123456");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector("js-loginSubmit")).Submit();
           // driver.FindElement(By.CssSelector("btn btn--small js-loginSubmit")).Click();
            





        }
}
}
