using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VanillaSelenium.Framework.Logging
{
    public class MsUnitTestResultsLogger : IResultLogger
    {
        private TestContext _testContext;

        public MsUnitTestResultsLogger(TestContext testContext)
        {
            _testContext = testContext;
        }

        public void Info(string msg)
        {
            _testContext.WriteLine(msg);
        }

        public void Error(string msg)
        {
            _testContext.WriteLine("Error: " + msg);
        }
    }

}
