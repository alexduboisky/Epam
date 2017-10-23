using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//"//a[text()='Sign in']"
namespace WBDemo
{
    [TestFixture]
    public class WDTest
    {
        [Test]
        public void OneCanOpenGoogle()
        {
            IWebDriver Chrome = new ChromeDriver();
            Chrome.Navigate().GoToUrl("https://github.com/");
           
            IWebElement SignInGitHub = Chrome.FindElement(By.XPath("/ html / body / div[1] / header / div / div[2] / div / span / div / a[1]"));
            SignInGitHub.Click();

            IWebElement InputLogin = Chrome.FindElement(By.XPath("//*[@id='login_field']"));
            InputLogin.SendKeys("alexduboisky");

            IWebElement InputPassword = Chrome.FindElement(By.XPath("//*[@id='password']"));
            InputPassword.SendKeys("8244919Ad");

            IWebElement SignInButton = Chrome.FindElement(By.XPath("//*[@id='login']/form/div[4]/input[3]"));
            SignInButton.Click();
        }
    }
}
