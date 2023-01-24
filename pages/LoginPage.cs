using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBATest
{
    public class LoginPage
    {
        IWebDriver driver;
        By LogInDropdown = By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/nav/div/div/ul/li/button");
        By LogInAnchor = By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/nav/div/div/ul/li/div/div/ul/li[1]/a");
        By Email = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/div[1]/input");
        By Password = By.Id("password");
        By login_submit = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/button");
    
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void LoginDropdown()
        {
            driver.FindElement(LogInDropdown).Click();
        }
        public void LoginButton()
        {
            driver.FindElement(LogInAnchor).Click();
        }
        public void TypeEmail()
        {
            driver.FindElement(Email).SendKeys("mariamedwards.smart@gmail.com");
        }
        public void TypePassword()
        {
            driver.FindElement(Password).SendKeys("Passw0rd");
        }
        public void TypeLoginSubmit()
        {
            driver.FindElement(login_submit).Click();
        }
    }
}
