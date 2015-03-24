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
        public string Text;
        public bool IsSelected;
        public FindTypes Type;

        public Element(IWebElement e, string q, FindTypes t)
        {
            WebElement = e;
            Query = q;
            IsDisplayed = WebElement.Displayed;
            IsSelected = WebElement.Selected;
            Text = WebElement.GetAttribute("value");
            Type = t;
            RetryCount = Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]);           
        }

        public Element(string q, FindTypes t)
        {
            Query = q;
            Type = t;
        }

        public void Click()
        {          
            WebElement.Click();
        }

        public void Submit()
        {
            WebElement.Submit();
        }

        public bool Click(Element verifyElement, bool displayed)
        {

            for (int i = 0; i < RetryCount; i++)
            {
                var Base = new PageBase();
                try
                {
                    WebElement.Click();
                }
                catch(ElementNotVisibleException)
                {
                }
                Thread.Sleep(1000);
                var newElement = Base.FindElement(verifyElement.Query, verifyElement.Type);

                if (newElement.IsDisplayed && displayed)
                {
                    return true;
                }
                
                if (!newElement.IsDisplayed && !displayed)
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
                var Base = new PageBase();
                var newElement = Base.FindElement(Query, Type);
                if (newElement.Text == null)
                {
                    return true;
                }
                Thread.Sleep(500);

            }

            return false;
        }

        public bool SendKeys(string text)
        {
            for (int i = 0; i < RetryCount; i++)
            {
                WebElement.SendKeys(text);

                var Base = new PageBase();
                var newElement = Base.FindElement(Query, Type);
              
                if (newElement.Text == text)
                {
                    return true;
                }
                WebElement.Clear();

                Thread.Sleep(500);
            } 
            return false;
        }

        public void SendKeys(string text, bool validate)
        {
            WebElement.SendKeys(text);
        }

        public bool Select(int index)
        {
            
            var selectElement = new SelectElement(WebElement);

            selectElement.SelectByIndex(index);

            return true;

        }

        public bool Select(string text)
        {
            var selectElement = new SelectElement(WebElement);


            for (int i = 0; i < RetryCount; i++)
            {
                selectElement.SelectByText(text);


                var Base = new PageBase();

                
                var newElement = Base.FindElement(Query, Type);
                var newSelectElement = new SelectElement(newElement.WebElement);

                if (newSelectElement.SelectedOption.Text == text)
                    return true;

                Thread.Sleep(500);
                    
            }
          return false;
        }

    }
}
