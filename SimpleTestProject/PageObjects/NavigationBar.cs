namespace SimpleTestProject.PageObjects
{
    using OpenQA.Selenium;

    class NavigationBar
    {
        public IWebElement VehicleType => _driver.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_VehicleType_DDList"));
        public IWebElement EngineCapacity => _driver.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_MotorcycleSubType_DDList"));
        public IWebElement CustAddress => _driver.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_AddressLine_SingleLine_CtrlHolderDivShown"));        
        public IWebElement PermitDuration => _driver.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_PermitDuration_DDList"));
        public IWebElement NextButton => _driver.FindElement(By.XPath("//input[contains(@value, " + "\"Next\"" + ")]"));
        public IWebElement PermitTypes => _driver.FindElement(By.XPath("//div[contains(@class, " + "\"ctrl-holder v-no-valid-status with-help-content\"" + ")]"));
        private IWebDriver _driver;

        public NavigationBar(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
