using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanillaSelenium.Framework.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VanillaSelenium.Framework
{
    public class FW
    {
        private readonly IResultLogger logger;

        public void Log(string msg, bool error)
        {
            if (error)
                logger.Error(msg);

            if (!error)
                logger.Info(msg);
        }

        public void FailTest(string msg)
        {
            Assert.Fail(msg);
        }
    }
}
