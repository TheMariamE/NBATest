using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBATest
{
    public class RegistrationPage
    {
        IWebDriver driver;
        By Email = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/form/div[1]/div[1]/input");
        By Password = By.Id("password");
        By year = By.Name("dobyear");
        By Month = By.Name("dobMonth");
        By RemovePolicy = By.ClassName("onetrust-close-btn-handler");
        By AgreeTerms = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/button");
        By UncheckAds = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/form/div[1]/div[8]/label/div/div");
        By registration_submit = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/form/div[1]/button");

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void SelectYear()
        {
            SelectElement selectBirthyear = new SelectElement((IWebElement)year);
            selectBirthyear.SelectByText("1999");
        }
        public void SelectMonth()
        {
            SelectElement selectBirthmonth = new SelectElement((IWebElement)Month);
            selectBirthmonth.SelectByText("June");
        }
        public void TypeEmail()
        {
            driver.FindElement(Email).SendKeys("themariame.dev@gmail.com");
        }
        public void TypePassword()
        {
            driver.FindElement(Password).SendKeys("Passw0rd");
        }
        public void CookiePolicy()
        {
            driver.FindElement(RemovePolicy).Click();
        }
        public void TermsConditions()
        {
            driver.FindElement(AgreeTerms).Click();
        }
        public void RemoveEmailAds()
        {
            driver.FindElement(UncheckAds).Click();
        }
        public void Registration_Submit()
        {
            driver.FindElement(registration_submit).Click();
        }
    }
}
