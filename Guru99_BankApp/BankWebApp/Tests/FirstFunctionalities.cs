using System;
using System.Text;
using System.Collections.Generic;
using BankWebApp.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BankWebApp.Tests
{
    [TestClass]
    public class FirstFunctionalities : BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FirstPage firstPage = new FirstPage(Driver);
            firstPage.GoTo();
            firstPage.LoginWithRightCredentials();
            Assert.IsTrue(firstPage.IsLoaded, "The Home Page did not open successfully");
            Assert.IsTrue(firstPage.IsVisibleTitle,"The title is not visible");
           //EXPECTED 
        }
    }
}
