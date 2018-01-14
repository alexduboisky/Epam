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
        string defaultDeparture = "FRANKFURT(MAIN)";
        string defaultArrival = "BERLIN";
        string errorArrival = "Minsk";

        IWebDriver driver;

        MainPage mainPage;
        ResultPage resultPage;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void OpenPage()
        {
            
            mainPage.OpenPage();
        }

        public void SearchButtonClick()
        {
            mainPage.SearchTickets();
        }

        public void SetDistanation(string departure, string arrive)
        {
            mainPage.setDepartureCity(departure);
            mainPage.setArrivalCity(arrive);
        }

        public void SetTimeDeparture(string timeDeparture)
        {
            mainPage.setTimeDeparture(timeDeparture);
        }

        public void SetTimeReturn(string timeReturn)
        {
            mainPage.setTimeReturn(timeReturn);
        }

        public void SetCountTraveller(string countTraveller)
        {
            mainPage.setCountTraveller(countTraveller);
        }

        public void SetAgeTraveller1(string ageTraveller1)
        {
            mainPage.setAgeTraveller1(ageTraveller1);
        }

        public void SetAgeTraveller2(string ageTraveller2)
        {
            mainPage.setAgeTraveller2(ageTraveller2);
        }

        public void SetDataDeparture(string dataDeparture)
        {
            mainPage.setDateDeparture(dataDeparture);
        }

        public void SetDataReturn(string dataReturn)
        {
            mainPage.setDataReturn(dataReturn);
        }

        public void SetFirstClass()
        {
            mainPage.selectFirstClass();
        }

        public void SetSecondClass()
        {
            mainPage.selectSecondClass();
        }

        public void SelectBahnCard(string bahnCard)
        {
            mainPage.selectBahnCard(bahnCard);
        }

        public bool Result()
        {
            resultPage.Result();
            return true;
        }

        public bool DataError()
        {
            resultPage.DataError();
            return true;
        }

        public bool PlaceError()
        {
            resultPage.PlaceError();
            return true;
        }
    }
}
