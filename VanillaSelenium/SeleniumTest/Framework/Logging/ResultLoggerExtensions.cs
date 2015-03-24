using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanillaSelenium.Framework.Logging
{
    public static class ResultLoggerExtensions
    {
        public static void Info(this IResultLogger logger, string msg, params object[] args)
        {
            logger.Info(string.Format(msg, args));
        }

        public static void Error(this IResultLogger logger, string msg, params object[] args)
        {
            logger.Error(string.Format(msg, args));
        }
    }
}
