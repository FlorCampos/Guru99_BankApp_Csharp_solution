using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace BankWebApp.Pages
{
    public class FirstPage : BaseApplicationPage
    {
        
        public FirstPage(IWebDriver driver) : base(driver)
        {
           
        }
        
        private IWebElement txtUserID => Driver.FindElement(By.XPath("//input[@name='uid']"));
        private IWebElement txtPassword => Driver.FindElement(By.XPath("//input[@name='password']"));
        private IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@name='btnLogin']"));
        private IWebElement lblMessageHomePage => Driver.FindElement(By.XPath("//td[starts-with(text(),'Manger')]"));
        internal void GoTo()
        {
            var url = "http://www.demo.guru99.com/V4/";
            Driver.Navigate().GoToUrl(url);
        }

        public void LoginWithRightCredentials()
        {
            txtUserID.Clear();
            HighlightElementUsingJavaScript(By.XPath("//input[@name='uid']"));
            txtUserID.SendKeys("mngr260516");
            HighlightElementUsingJavaScript(By.XPath("//input[@name='password']"));
            txtPassword.SendKeys("vygybAv");
            btnLogin.Click();
        }

        public bool IsLoaded
        {
            get
            {
                try
                {
                    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
                    var lblMessageHomePage = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//td[starts-with(text(),'Manger')]")));
                    return lblMessageHomePage.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public bool IsVisibleTitle {
            get => Driver.Title.Contains("Guru99 Bank Manager HomePage");
            internal set { }
        }

    }
}
