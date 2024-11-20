using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Pages.StaticElements.Header
{
    internal partial class Header : WebPage
    {
        // Locators
        private readonly By LogoProgress = By.XPath("//div[@class='PRGS-Bar-branding']//a[@class='PRGS-Bar-logo']");

        private readonly By DropDownSolutions = By.XPath("//button[@class='has-dropdown-arrow'][text()='Solutions']");
        private readonly By DropDownProducts = By.XPath("//button[@class='has-dropdown-arrow'][text()='Products']");
        private readonly By DropDownSupportAndServices = By.XPath("//button[@class='has-dropdown-arrow'][text()='Support & Services']");
        private readonly By DropDownResources = By.XPath("//button[@class='has-dropdown-arrow'][text()='Resources']");
        private readonly By DropDownPartners = By.XPath("//button[@class='has-dropdown-arrow'][text()='Partners']");
        private readonly By DropDownCompany = By.XPath("//button[@class='has-dropdown-arrow'][text()='Company']");

        private readonly By IconSearch = By.Id("js-search-trigger");
        private readonly By IconUser = By.XPath("js-user-trigger");
        private readonly By LinkReadyToTalk = By.XPath("js-close-focused");

        // Elements
        protected IWebElement DropDownSolutionsElement => FindElement(DropDownSolutions);
        protected IWebElement DropDownProductsElement => FindElement(DropDownProducts);
        protected IWebElement DropDownSupportAndServicesElement => FindElement(DropDownSupportAndServices);
        protected IWebElement DropDownResourcesElement => FindElement(DropDownResources);
        protected IWebElement DropDownPartnersElement => FindElement(DropDownPartners);
        protected IWebElement DropDownCompanyElement => FindElement(DropDownCompany);
        protected IWebElement IconSearchElement => FindElement(IconSearch);
        protected IWebElement IconUserElement => FindElement(IconUser);
        protected IWebElement LinkReadyToTalkElement => FindElement(LinkReadyToTalk);
        protected IWebElement LogoProgressElement => FindElement(LogoProgress);

    }
}
