using OpenQA.Selenium;
using Progress.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Pages.ThankYou
{
    internal partial class ThankYouPage : WebPage
    {
        public ThankYouPage(IWebDriver driver, Localization localization = Localization.England) : base(driver, localization) {}
    }
}
