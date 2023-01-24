using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Threading;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools.V107.Browser;

namespace NBATest
{
    [TestClass]
    public class SpeedTest
    {
        //Opening the NBA site on Edge Browser
        [TestMethod]
        public void EdgeMethod()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.nba.com/");
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();
        }

        //Opening the NBA site with Chrome Browser and verifying the Title of Page
        [TestMethod]
        public void ChromeMethod()
        {
            string RealResult;
            string ExpectedResult = "The official site of the NBA for the latest NBA Scores, Stats & News. | NBA.com";
            //If uncommented, test case should fail -> string ExpectedResult = "Testing Title";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.nba.com/");
            driver.Manage().Window.Maximize();
            RealResult = driver.Title;
            if (RealResult.Contains(ExpectedResult))
            {
                Console.WriteLine("Test Case Passed");
            }
            else
            {
                Console.WriteLine("Test Case Failed");
            }
            driver.Close();
            driver.Quit();
        }

        //Process of Creating a new account on NBA site
        [TestMethod]
        public void CreateAccount()
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl("https://www.nba.com/account/sign-up");
                driver.Manage().Window.Maximize();
                //add email
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/form/div[1]/div[1]/input")).SendKeys("mariamedwards.smart@gmail.com");
                //add password
                driver.FindElement(By.Id("password")).SendKeys("Passw0rd");
                //select birth month
                SelectElement selectBirthmonth = new SelectElement(driver.FindElement(By.Name("dobMonth")));
                selectBirthmonth.SelectByText("June");
                //select birth year
                SelectElement selectBirthyear = new SelectElement(driver.FindElement(By.Name("dobyear")));
                selectBirthyear.SelectByText("1999");
                //remove cookie policy bar
                driver.FindElement(By.ClassName("onetrust-close-btn-handler")).Click();
                //checkbox to agree terms of use
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/form/div[1]/div[7]/label/div")).Click();
                //uncheck box to avoid ads
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/form/div[1]/div[8]/label/div/div")).Click();
                //click on create account button
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/form/div[1]/button")).Click();
                //small pause to view the process
                Thread.Sleep(10000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                driver.Close();
                driver.Quit();
            }
        }

        //Process of Loggin into the NBA site
        [TestMethod]
        public void LogInAccount()
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl("https://www.nba.com/");
                driver.Manage().Window.Maximize();
                //Start on the HomePage clicking on the Sign In
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/nav/div/div/ul/li/button")).Click();
                //After that It'll dropdown and click on the anchor link of the Sign In page
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/nav/div/div/ul/li/div/div/ul/li[1]/a")).Click();
                //add email
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/div[1]/input")).SendKeys("mariamedwards.smart@gmail.com");
                //add password
                driver.FindElement(By.Id("password")).SendKeys("Passw0rd");
                //click on sign in button
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/button")).Click();
                Thread.Sleep(10000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                driver.Close();
                driver.Quit();
            }
        }

        //Process of Loggin into the NBA site + Following Preffered Team to Account
        [TestMethod]
        public void FollowFavoriteTeam()
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl("https://www.nba.com/");
                driver.Manage().Window.Maximize();
                //Start on the HomePage clicking on the Sign In
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/nav/div/div/ul/li/button")).Click();
                //After that It'll dropdown and click on the anchor link of the Sign In page
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/nav/div/div/ul/li/div/div/ul/li[1]/a")).Click();
                //add email
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/div[1]/input")).SendKeys("mariamedwards.smart@gmail.com");
                //add password
                driver.FindElement(By.Id("password")).SendKeys("Passw0rd");
                //click on sign in button
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/button")).Click();
                Thread.Sleep(8000);
                //Click on profile icon to display dropdown
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/nav/div/div/ul/li/button")).Click();
                //Enter profile to edit team of preference
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/nav/div/div/ul/li/div/div/ul/li[1]/a")).Click();
                //remove cookie policy bar
                driver.FindElement(By.ClassName("onetrust-close-btn-handler")).Click();
                //Select button to start adding preffered teams
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[1]/div[3]/div[2]/div/div/button")).Click();
                Thread.Sleep(5000);
                //For this Test Case, We'll choose the Atlanta Hawks, Nets and Celtics (In that order)
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/button[1]")).Click();
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[2]/div/div/button[2]")).Click();
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[2]/div/div/button[3]")).Click();
                Thread.Sleep(5000);
                //Then we'll edit the favorite team by clicking on the edit favorite button
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[1]/div[1]/button")).Click();
                //Selecting another team
                driver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[2]/button[2]")).Click();
                //Save progress
                driver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[3]/button")).Click();
                Thread.Sleep(10000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                driver.Close();
                driver.Quit();
            }
        }
    }
}
