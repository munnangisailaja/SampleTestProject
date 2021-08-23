namespace SimpleTestProject.StepDefinitions
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using PageObjects;
    using System;
    using System.Threading;
    using TechTalk.SpecFlow;

    [Binding]
    public class Navigation
    {
        private NavigationBar NavBar => new NavigationBar(_driver);
        private IWebDriver _driver;
        private ScenarioContext _scenarioContext;

        public Navigation(IWebDriver driver, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to the (.*) page")]
        public void GivenINavigateToPage(string page)
        {
            _driver.Navigate().GoToUrl($"https://www.vicroads.vic.gov.au/registration/limited-use-permits/unregistered-vehicle-permits/get-an-unregistered-vehicle-permit");
            _scenarioContext["pageTitle"] = _driver.Title;
            _scenarioContext["pageName"] = page;
        }
        
        [When(@"the verify the page title is (.*)")]
        public void GivenTheVerifyThePageTitleIs(string pageTitle)
        {
            Assert.That(_scenarioContext["pageTitle"].ToString().Contains(pageTitle));
        }

        [When(@"I select (.*) from Vehicle type dropdown")]
        public void GivenISelectFromVehicleTypeDropdown(string valueToSelect)
        {
            NavBar.VehicleType.SendKeys(valueToSelect);          
        }

        [When(@"I select (.*) from Engine capacity dropdown")]
        public void GivenISelectFromEngineCapacityDropdown(string valueToSelect)
        {
            NavBar.EngineCapacity.SendKeys(valueToSelect);           
        }
        [When(@"input customer address (.*)")]
        public void GivenInputCustomerAddress(string valueToInput)
        {
            NavBar.CustAddress.SendKeys(valueToInput);            
        }
        
        [When(@"select (.*) from permit duration dropdown")]
        public void GivenSelectFromPermitDurationDropdown(string valueToSelect)
        {
            NavBar.PermitDuration.SendKeys(valueToSelect);            
        }
        
        [When(@"click on (.*) button on (.*)")]
        public void GivenClickOnButtonOn(string p0, string p1)
        {
            NavBar.NextButton.Click();
            Thread.Sleep(1500);
        }
        [Then(@"permit types displayed as ""(.*)""")]
        public void ThenPermitTypesDisplayedAs(string permitTypes)
        {
            Assert.That(NavBar.PermitTypes.Text.Contains(permitTypes));
        }

    }
}


