using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NBATest
{
    [TestClass]
    public class NBALogin
    {
        //Process of Loggin into the NBA site
        [TestMethod]
        public void VerifyNBALogin() 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.nba.com/");
            LoginPage login = new LoginPage(driver);
            login.LoginDropdown();
            login.LoginButton();
            login.TypeEmail();
            login.TypePassword();
            login.TypeLoginSubmit();
            Thread.Sleep(8000);
            driver.Quit();
        }
    }
}
