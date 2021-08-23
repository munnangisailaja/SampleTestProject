using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SimpleTestProject.Hooks
{
    [Binding]
    public class DriverSetup
    {
        private IObjectContainer _objectContainer;
        public IWebDriver Driver;

        public DriverSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();

            _objectContainer.RegisterInstanceAs(Driver);
        }       
    }
}

