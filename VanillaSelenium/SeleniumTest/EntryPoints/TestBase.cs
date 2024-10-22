﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VanillaSelenium.Framework.Logging;
using VanillaSelenium.Framework;

namespace VanillaSelenium
{
    [TestClass]
    public class TestBase 
    {
        public WebDriver Driver = new WebDriver();
        public Browser Browser = new Browser();
        public FW FW;

        // TestContext will get set by the unit test framework
        public TestContext TestContext { get; set; }
        
        [TestInitialize]
        public void Initialize()
        {
            FW = new FW(new MsUnitTestResultsLogger(TestContext));
            Browser.Maximize();
            if (Driver.FormFactor == "Mobile")
                Browser.Resize(360, 720);         
            Browser.Load(WebDriver.Environment);

        }

        [TestCleanup]
        public void TearDown()
        {
            Browser.Close();
        }    

    }
}
