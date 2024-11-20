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
        private By LabelThankYouelement = By.XPath("//h1[@class='-mb4']");
    }
}
