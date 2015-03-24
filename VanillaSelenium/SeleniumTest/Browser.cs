using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VanillaSelenium
{
    public class Browser 
    {

        public bool Load(string url)
        {
            WebDriver.Driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            if (WebDriver.Driver.Url == url)
                return true;
            return false;
        }

    }
}
