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
        public void Text1()
        {

            var page = new Page();

            page.BtnSubscribe.Click();

        }

    
    }
}
