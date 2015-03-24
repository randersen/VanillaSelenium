using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Configuration;

namespace VanillaSelenium
{
    public class PageBase
    {
        public Element FindElement(string key, FindTypes type)
        {
            switch (type)
            {
                case (FindTypes.Id):
                    return new Element(WebDriver.Driver.FindElement(By.Id(key)), key, type);
                case (FindTypes.Xpath):
                    return new Element(WebDriver.Driver.FindElement(By.XPath(key)), key, type);
                case (FindTypes.ClassName):
                    return new Element(WebDriver.Driver.FindElement(By.ClassName(key)), key, type);
                case (FindTypes.Css):
                    return new Element(WebDriver.Driver.FindElement(By.CssSelector(key)), key, type);

            }

            return null;
        }

    }
}
