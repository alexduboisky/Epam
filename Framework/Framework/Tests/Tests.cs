using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Framework.Tests
{
    [TestFixture]
    class Tests
    {
        Steps.Steps steps = new Steps.Steps();

        string defaultDeparture = "FRANKFURT(MAIN)";
        string defaultArrival = "BERLIN";
        string errorArrival = "Minsk";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void InvalidStation()
        {
            steps.SetDistanation(defaultDeparture, errorArrival);
            steps.SearchButtonClick();
            Assert.IsTrue(steps.PlaceError());
        }

        [Test]
        public void InvalidTime()
        {
            steps.SetDistanation(defaultDeparture, defaultArrival);
            steps.SetDateReturn(Convert.ToString(DateTime.Today));
            steps.SetTimeDeparture("15:00");
            steps.SetTimeReturn("13:00");
            steps.SearchButtonClick();
            Assert.IsTrue(steps.DataError());
        }

        [Test]
        public void ValidStation()
        {
            steps.SetDistanation(defaultDeparture, defaultArrival);
            steps.SearchButtonClick();
            Assert.IsTrue(steps.Result());
        }

        [Test]
        public void InvalidStation2()
        {
            steps.SetDistanation(defaultArrival, defaultArrival);
            steps.SearchButtonClick();
            Assert.IsTrue(steps.Place2Error());
        }

        [Test]
        public void ValidDate()
        {
            steps.SetDistanation(defaultDeparture, defaultArrival);
            steps.SetDateDeparture(Convert.ToString(DateTime.Now.AddDays(+3)));
            steps.SearchButtonClick();
            Assert.IsTrue(steps.Result());
        }

        [Test]
        public void CountTraveller()
        {
            steps.SetDistanation(defaultArrival, defaultArrival);
            steps.SetCountTraveller(2);
            steps.SearchButtonClick();
            Assert.IsTrue(steps.Result());
        }

        [Test]
        public void AgeTraveller()
        {
            steps.SetDistanation(defaultDeparture, defaultArrival);
            steps.SetAgeTraveller1("F");
            steps.SearchButtonClick();
            Assert.IsTrue(steps.Result());
        }

        [Test]
        public void AgeAndCountTraveller()
        {
            steps.SetDistanation(defaultDeparture, defaultArrival);
            steps.SetCountTraveller(2);
            steps.SetAgeTraveller2("F");
            steps.SearchButtonClick();
            Assert.IsTrue(steps.Result());
        }

        [Test]
        public void ClassTraveller()
        {
            steps.SetDistanation(defaultDeparture, defaultArrival);
            steps.SetFirstClass();
            steps.SearchButtonClick();
            Assert.IsTrue(steps.Result());
        }

        [Test]
        public void ClassAndBahnCardTraveller()
        {
            steps.SetDistanation(defaultDeparture, defaultArrival);
            steps.SetFirstClass();
            steps.SelectBahnCard("3");
            steps.SearchButtonClick();
            Assert.IsTrue(steps.Result());
        }
    }
}
