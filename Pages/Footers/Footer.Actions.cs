using OpenQA.Selenium;
using Progress.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Pages.StaticElements.Footers
{
    internal partial class Footer : WebPage
    {
        public Footer(IWebDriver driver, Localization localization) : base(driver, localization) 
        {
            if (Localization.England == localization)
            {

            }
        }
    }
}
