using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Framework.Pages
{
    class ResultPage
    {
        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public bool Result()
        {
            try
            {
                IWebElement resultList = driver.FindElement(By.ClassName("resultContentHolder"));
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DataError()
        {
            try
            {
                IWebElement dataError = driver.FindElement(By.XPath("//*[@id='dateErr21']"));
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool PlaceError()
        {
            try
            {
                IWebElement placeError = driver.FindElement(By.XPath("//*[@id='errormsg_Z']"));
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
