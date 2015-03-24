using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using VanillaSelenium;

namespace VanillaSelenium
{
    [TestClass]
    public class Test : TestBase
    {
        


        [TestMethod]
        public void SubscribeButtonNoEmailEntered()
        {

            var page = new Page();

            if (page.BtnSubscribe.Click(page.BtnReEnterEmailOk, true))
                FW.FailTest("Re enter email popup was not displayed");
            page.BtnReEnterEmailOk.Click(page.BtnReEnterEmailOk, false);

        }

        [TestMethod]
        public void SubscribeButtonTextBox()
        {

            var page = new Page();
            page.TxtSearch.SendKeys("Stuff");
            page.TxtSearch.Clear();

        }

    
    }
}
