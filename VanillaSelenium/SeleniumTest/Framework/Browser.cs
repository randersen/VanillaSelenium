using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing;

namespace VanillaSelenium
{
    public class Browser 
    {
        public int RetryCount = Convert.ToInt32(ConfigurationManager.AppSettings["RetryCount"]);

        public bool Load(string url)
        {
            for (int i = 0; i < RetryCount; i++)
            {
                WebDriver.Driver.Navigate().GoToUrl(url);
                Thread.Sleep(3000);
                if (WebDriver.Driver.Url == url)
                    return true;
            }
            return false;
        }

        public void Close()
        {
            WebDriver.Driver.Quit();
        }

        public void Resize(int width, int height)
        {
            WebDriver.Driver.Manage().Window.Size = new Size(width, height);
        }

        public void Maximize()
        {
            WebDriver.Driver.Manage().Window.Maximize();
        }

        public void SwitchWindow(int window)
        {
            var windows = WebDriver.Driver.WindowHandles;
            string windowText = windows[window];
            WebDriver.Driver.SwitchTo().Window(windowText);
        }

        public int GetWindowCount()
        {
            int count = 0;
            var windows = WebDriver.Driver.WindowHandles;
            foreach (var i in windows)
            {
                count++;
            }

            return count;
        }

    }
}
