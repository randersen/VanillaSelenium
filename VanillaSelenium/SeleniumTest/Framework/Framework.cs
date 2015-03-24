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
        private readonly MsUnitTestResultsLogger logger;

        public FW(MsUnitTestResultsLogger resultLogger)
        {
            logger = resultLogger;
        }

        public void Log(string msg, bool error)
        {
            if (error)
                logger.Error(msg);

            if (!error)
                logger.Info(msg);
        }

        public void FailTest(string msg)
        {
            logger.Error(msg);
            Assert.Fail(msg);
        }
    }
}
