using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Configuration;
using System.Runtime.Remoting.Messaging;
using VanillaSelenium;

namespace VanillaSelenium
{

    public enum FindTypes
    {
        Id, Xpath, ClassName, Css
    }

    public class WebDriver
    {
        string browserType;
        public static string Environment;
        public static IWebDriver Driver;
        public string FormFactor;
        
        public WebDriver()
        {
            browserType = ConfigurationManager.AppSettings["Browser"];
            Environment = ConfigurationManager.AppSettings["Environment"];
            Driver = GetDriver();
            FormFactor = ConfigurationManager.AppSettings["FormFactor"];

        }

        public IWebDriver GetDriver()
       {
           IWebDriver driverType = null;

           switch (ConfigurationManager.AppSettings["Browser"])
           {
               case "Chrome": driverType = new ChromeDriver();
                   break;

               case "Firefox": driverType = new FirefoxDriver();
                   break;

               case "IE": driverType = new InternetExplorerDriver();
                   break;               
           }

           return driverType;
           ;
       }

        

    }
}
