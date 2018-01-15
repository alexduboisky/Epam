using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Framework.Pages;

namespace Framework.Steps
{
    class Steps
    {
        IWebDriver driver;

        private MainPage mainPage;
        ResultPage resultPage;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void SearchButtonClick()
        {
            var mainPage = new MainPage(driver);
            mainPage.SearchTickets();
        }

        public void SetDistanation(string departure, string arrive)
        {
            var mainPage = new MainPage(driver);
            mainPage.OpenPage();
            mainPage.setDepartureCity(departure);
            mainPage.setArrivalCity(arrive);
        }

        public void SetTimeDeparture(string timeDeparture)
        {
            var mainPage = new MainPage(driver);
            mainPage.setTimeDeparture(timeDeparture);
        }

        public void SetTimeReturn(string timeReturn)
        {
            var mainPage = new MainPage(driver);
            mainPage.setTimeReturn(timeReturn);
        }

        public void SetCountTraveller(int countTraveller)
        {
            var mainPage = new MainPage(driver);
            mainPage.setCountTraveller(countTraveller);
        }

        public void SetAgeTraveller1(string ageTraveller1)
        {
            var mainPage = new MainPage(driver);
            mainPage.setAgeTraveller1(ageTraveller1);
        }

        public void SetAgeTraveller2(string ageTraveller2)
        {
            var mainPage = new MainPage(driver);
            mainPage.setAgeTraveller2(ageTraveller2);
        }

        public void SetDateDeparture(string dateDeparture)
        {
            var mainPage = new MainPage(driver);
            mainPage.setDateDeparture(dateDeparture);
        }

        public void SetDateReturn(string dateReturn)
        {
            var mainPage = new MainPage(driver);
            mainPage.setDateReturn(dateReturn);
        }

        public void SetFirstClass()
        {
            var mainPage = new MainPage(driver);
            mainPage.selectFirstClass();
        }

        public void SetSecondClass()
        {
            var mainPage = new MainPage(driver);
            mainPage.selectSecondClass();
        }

        public void SelectBahnCard(string bahnCard)
        {
            mainPage.selectBahnCard(bahnCard);
        }

        public bool Result()
        {
            var resultPage = new ResultPage(driver);
            resultPage.Result();
            return true;
        }

        public bool DataError()
        {
            var resultPage = new ResultPage(driver);
            resultPage.DataError();
            return true;
        }

        public bool PlaceError()
        {
            var resultPage = new ResultPage(driver);
            resultPage.PlaceError();
            return true;
        }

        public bool Place2Error()
        {
            var resultPage = new ResultPage(driver);
            resultPage.Place2Error();
            return true;
        }
    }
}
