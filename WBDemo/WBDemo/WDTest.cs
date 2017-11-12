using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBDemo
{
    [TestFixture]
    public class WDTest
    {
        const string login = "testautomationuser";
        const string password = "Time4Death!";

        [Test]
        public void OneCanOpenGoogle()
        {
            IWebDriver Chrome = new ChromeDriver();
            Chrome.Manage().Window.Maximize();
            Chrome.Navigate().GoToUrl("https://github.com/");

            IWebElement SignInGitHub = Chrome.FindElement(By.XPath("//a[text()='Sign in']"));
            SignInGitHub.Click();

            IWebElement InputLogin = Chrome.FindElement(By.XPath("//*[@name='login']"));
            InputLogin.SendKeys(login);

            IWebElement InputPassword = Chrome.FindElement(By.XPath("//*[@name='password']"));
            InputPassword.SendKeys(password);

            IWebElement SignInButton = Chrome.FindElement(By.XPath("//*[@name='commit']"));
            SignInButton.Click();

            String user = Chrome.FindElement(By.XPath("//meta[@name='user-login']")).GetAttribute("content");
            Assert.AreEqual(user, login);
            
            Chrome.Quit();
        }
    }
}
