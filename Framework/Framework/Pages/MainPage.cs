using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Pages
{
    class MainPage
    {
        private IWebDriver driver;

        private const string BASE_URL = "https://www.bahn.com/en/view/index.shtml";

        [FindsBy(How=How.Id,Using = "js-auskunft-autocomplete-from")]
        private IWebElement inputDepartureCity;

        [FindsBy(How = How.Id,Using = "js-auskunft-autocomplete-to")]
        private IWebElement inputArrivalCity;

        [FindsBy(How = How.XPath,Using = "/html/body/div[1]/div[2]/div/div/div[2]/div/div[4]/div/form/fieldset[3]/div[2]/select")]
        private IWebElement countTravellerList;

        [FindsBy(How = How.Name,Using = "tariffTravellerType.1")]
        private IWebElement ageTraveller1;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[2]/div/div[4]/div/form/fieldset[3]/div[5]/div[1]/select")]
        private IWebElement ageTraveller2;

        [FindsBy(How = How.XPath,Using = "/html/body/div[1]/div[2]/div/div/div[2]/div/div[4]/div/form/fieldset[3]/div[4]/div[2]/select")]
        private IWebElement bahnCardList;

        [FindsBy(How = How.Id, Using = "radio07")]
        private IWebElement firstClassRadioButton;

        [FindsBy(How =How.Id,Using = "radio08")]
        private IWebElement secondClassRadioButton;

        [FindsBy(How = How.ClassName, Using = "center-inline hasDatepicker")]
        private IWebElement dateDeparture;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[2]/div/div[4]/div/form/fieldset[1]/div[2]/div[2]/input")]
        private IWebElement timeDeparture;

        [FindsBy(How = How.ClassName, Using = "center-inline hasDatepicker")]
        private IWebElement dateReturn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[2]/div/div[4]/div/form/fieldset[1]/div[2]/div[4]/div[2]/input")]
        private IWebElement timeReturn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[2]/div/div[4]/div/form/fieldset[5]/div/input[1]")]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='js-tab-auskunft']/div/form/fieldset[1]/div[1]/a[2]")]
        private IWebElement openButton;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            this.driver.Navigate().GoToUrl(BASE_URL);
        }

        public void OpenInformation()
        {
            openButton.Click();
        }

        public void SearchTickets()
        {
            searchButton.Click();
        }

        public void setDepartureCity(string departureCity)
        {
            inputDepartureCity.SendKeys(departureCity);
        }

        public void setArrivalCity(string arrivalCity)
        {
            inputArrivalCity.SendKeys(arrivalCity);
        }

        public void setDateDeparture(string dateDeparture)
        {
            this.dateDeparture.SendKeys(dateDeparture);
        }

        public void setDateReturn(string dateReturn)
        {
            this.dateReturn.SendKeys(dateReturn);
        }

        public void setTimeDeparture(string timeDeparture)
        {
            this.timeDeparture.SendKeys(timeDeparture);
        }

        public void setTimeReturn(string timeReturn)
        {
            this.timeReturn.SendKeys(timeReturn);
        }

        public void setCountTraveller(int count)
        {
            var selectElement = new SelectElement(countTravellerList);
            selectElement.SelectByValue(Convert.ToString(count));
        }

        public void setAgeTraveller1(string ageTrav1)
        {
            var selectElement = new SelectElement(ageTraveller1);
            selectElement.SelectByValue(ageTrav1);
        }

        public void setAgeTraveller2(string ageTrav2)
        {
            var selectElement = new SelectElement(ageTraveller2);
            selectElement.SelectByValue(ageTrav2);
        }

        public void selectFirstClass()
        {
            firstClassRadioButton.Click();
        }

        public void selectSecondClass()
        {
            secondClassRadioButton.Click();
        }

        public void selectBahnCard(string bahnCard)
        {
            var selectElement = new SelectElement(bahnCardList);
            selectElement.SelectByValue(bahnCard);
        }
    }
}
