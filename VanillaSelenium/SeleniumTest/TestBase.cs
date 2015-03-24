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

namespace VanillaSelenium
{
    [TestClass]
    public class TestBase 
    {
        public WebDriver Driver = new WebDriver();
        public Browser Browser = new Browser();
        
        [TestInitialize]
        public void Initialize()
        {
            Browser.Load(WebDriver.Environment);

        }

        [TestCleanup]
        public void TearDown()
        {
            
        }    

    }
}
