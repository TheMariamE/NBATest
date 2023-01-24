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
    public class NBARegister
    {
        //Process of Creating a new account on NBA site
        [TestMethod]
        public void VerifyNBARegistration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.nba.com/account/sign-up");
            RegistrationPage register = new RegistrationPage(driver);
            register.TypeEmail();
            register.TypePassword();
            register.SelectMonth();
            register.SelectYear();
            register.CookiePolicy();
            register.TermsConditions();
            register.RemoveEmailAds();
            register.Registration_Submit();
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
