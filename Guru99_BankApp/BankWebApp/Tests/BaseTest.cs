using AutomationResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace BankWebApp.Tests
{
    [TestClass]
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        [TestInitialize]
        public void SetupForEverySingleMethod()
        {
            var factory = new WebDriverFactory();
            Driver = factory.Create(BrowserType.Chrome);
            Driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void CleanUpAfterEverySingleMethod()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Close();
            Driver.Quit();
        }
    }
}
