using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanillaSelenium
{
    public class Page :  PageBase
    {

        public Element BtnSubscribe { get { return FindElement("subscribeBtn", FindTypes.Id); } }
        public Element TxtSubscribeEmail { get { return FindElement("subscribeEmail", FindTypes.Id); } }

    }
}
