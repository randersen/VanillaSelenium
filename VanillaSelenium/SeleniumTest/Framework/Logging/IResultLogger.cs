using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanillaSelenium.Framework.Logging
{
    public interface IResultLogger
    {
        void Info(string msg);
        void Error(string msg);
        //void Summarize();
    }
}
