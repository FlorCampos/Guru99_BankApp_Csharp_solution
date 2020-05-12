using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

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
                    return lblMessageHomePage.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

    }
}
