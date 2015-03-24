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
        public Element BtnReEnterEmailOk { get { return FindElement(".//*[@id='ng-app']//p[contains(text(),'Something went wrong,')]/following-sibling::button[.='OK']", FindTypes.Xpath); } }
        public Element TxtSearch { get { return FindElement(".//*[@id='wikiArticle']/p[6]/input", FindTypes.Xpath); } }
    }
}
