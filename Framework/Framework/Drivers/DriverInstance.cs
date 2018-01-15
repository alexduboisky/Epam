using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace Framework.Driver
{
    public class DriverInstance
    {
        private static IWebDriver driver;

        public DriverInstance() { }

        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;

            foreach (var process in Process.GetProcessesByName("chromedriver"))
            {
                process.Kill();
            }
        }
    }
}