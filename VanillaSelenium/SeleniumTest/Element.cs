using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using VanillaSelenium;

namespace VanillaSelenium
{
    public class Element
    {

        public IWebElement WebElement;
        private SelectElement DropDown;
        private Actions action;

        public string Query;
        public static int RetryCount;
        

        public bool IsDisplayed;
        public static string Text;
        public bool IsSelected;
        public FindTypes Type;

        public Element(IWebElement e, string q, FindTypes t)
        {
            WebElement = e;
            Query = q;
            IsDisplayed = SetIsDisplayed();
            Text = GetText();
            Type = t;
            RetryCount = Convert.ToInt32(ConfigurationManager.AppSettings["Retry"]);

        }
        
        private bool SetIsDisplayed()
        {

            return WebElement.Displayed;
        }

        private string GetText()
        {
            return WebElement.Text;
        }

        public void Click()
        {

            WebElement.Click();
        }

        public bool Click(Element verifyElement)
        {

            for (int i = 0; i < RetryCount; i++)
            {
                WebElement.Click();
                Thread.Sleep(1000);
                if (verifyElement.IsDisplayed)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Clear()
        {
            for (int i = 0; i < RetryCount; i++)
            {
                WebElement.Clear();
                Thread.Sleep(1000);
                if (WebElement.Text == null)
                {
                    return true;
                }

            }

            return false;
        }

        public bool SendKeys(string text)
        {
            for (int i = 0; i < RetryCount; i++)
            {
                WebElement.SendKeys(text);
                Thread.Sleep(1000);
                if (WebElement.Text == text)
                {
                    return true;
                }
                WebElement.Clear();
            } 
            return false;
        }

    }
}
