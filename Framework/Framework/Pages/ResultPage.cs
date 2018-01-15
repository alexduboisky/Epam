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
                IWebElement resultList = driver.FindElement(By.ClassName("boxShadow  scheduledCon"));
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
                IWebElement dataError = driver.FindElement(By.Id("dateErr21"));
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
                IWebElement placeError = driver.FindElement(By.Id("errormsg_Z"));
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Place2Error()
        {
            try
            {
                IWebElement placeError = driver.FindElement(By.ClassName("clearfix"));
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
