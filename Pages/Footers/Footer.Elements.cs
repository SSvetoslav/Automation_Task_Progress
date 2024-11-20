using OpenQA.Selenium;

namespace Progress.Pages.StaticElements.Footers
{
    internal partial class Footer : WebPage
    {
        // Technology section
        private readonly By LogoProgress = By.XPath("//div[@class='PRGS-Bar-branding']//a[@class='PRGS-Bar-logo']");

        // Quick Links section
        private readonly By LinkProducts = By.XPath("//div[@class='h3'][text()='Quick Links']/..//li/a[text()='Products']");
        private readonly By LinkTrials = By.XPath("//div[@class='h3'][text()='Quick Links']/..//li/a[text()='Trials']");
        private readonly By LinkServices = By.XPath("//div[@class='h3'][text()='Quick Links']/..//li/a[text()='Services']");
        private readonly By LinkPartners = By.XPath("//div[@class='h3'][text()='Quick Links']/..//li/a[text()='Partners']");
        private readonly By LinkSupport = By.XPath("//div[@class='h3'][text()='Quick Links']/..//li/a[text()='Support']");
        private readonly By LinkEvents = By.XPath("//div[@class='h3'][text()='Quick Links']/..//li/a[text()='Events']");
        private readonly By LinkBlogs = By.XPath("//div[@class='h3'][text()='Quick Links']/..//li/a[text()='Blogs']");

        protected IWebElement LinkProductsElement => FindElement(LinkProducts);
        protected IWebElement LinkTrialsElement => FindElement(LinkTrials);
        protected IWebElement LinkServicesElement => FindElement(LinkServices);
        protected IWebElement LinkPartnersElement => FindElement(LinkPartners);
        protected IWebElement LinkSupportElement => FindElement(LinkSupport);
        protected IWebElement LinkEventsElement => FindElement(LinkEvents);
        protected IWebElement LinkBlogsElemnt => FindElement(LinkBlogs);

        // About section
        private readonly By LinkCompany = By.XPath("//div[@class='h3'][text()='About']/..//li/a[text()='Company']");
        private readonly By LinkCustomerStories = By.XPath("//div[@class='h3'][text()='About']/..//li/a[text()='Customer Stories']");
        private readonly By LinkAwards = By.XPath("//div[@class='h3'][text()='About']/..//li/a[text()='Awards']");
        private readonly By LinkInvestorRelations = By.XPath("//div[@class='h3'][text()='About']/..//li/a[text()='Investor relations']");
        private readonly By LinkOffices = By.XPath("//div[@class='h3'][text()='About']/..//li/a[text()='Offices']");
        private readonly By LinkCareers = By.XPath("//div[@class='h3'][text()='About']/..//li/a[text()='Careers']");
        private readonly By Link40YearsOfProgress = By.XPath("//div[@class='h3'][text()='About']/..//li/a[text()='40 Years of Progress']");

        protected IWebElement LinkCompanyElement => FindElement(LinkCompany);
        protected IWebElement LinkCustomerStoriesElement => FindElement(LinkCustomerStories);
        protected IWebElement LinkAwardsElement => FindElement(LinkAwards);
        protected IWebElement LinkInvestorRelationsElement => FindElement(LinkInvestorRelations);
        protected IWebElement LinkOfficesElement => FindElement(LinkOffices);
        protected IWebElement LinkCareersElement => FindElement(LinkCareers);
        protected IWebElement Link40YearsOfProgressElement => FindElement(Link40YearsOfProgress);


        // Contact us
        private readonly By LinkContactUs = By.XPath("//div[@class='PRGS-col-6']/a[text()='Contact us']");
        private readonly By LinkPhoneNumber = By.XPath("//div[@class='PRGS-col-6']/a[text()='1-800-477-6473']");

        protected IWebElement LinkContactUsElement => FindElement(LinkContactUs);
        protected IWebElement LinkPhoneNumberElement => FindElement(LinkPhoneNumber);

        // Others
        private readonly By LinkTermsOfUse = By.XPath("//a[@href='/legal/terms-of-use']");
        private readonly By LinkPrivacyCenter = By.XPath("//a[@href='/legal/privacy-center']");
        private readonly By LinkTrustCenter = By.XPath("//a[@href='/trust-center']");
        private readonly By LinkTrademarks = By.XPath("//div[@class='PRGS-Footer-info']//a[@href='/legal/trademarks']");
        private readonly By LinkLicenseAgreements = By.XPath("//a[@href='/legal']");
        private readonly By LinkCodeOfConduct = By.XPath("//a[@href='/company/code-of-conduct']");

        protected IWebElement LinkTermsOfUseElement => FindElement(LinkTermsOfUse);
        protected IWebElement LinkPrivacyCenterElement => FindElement(LinkPrivacyCenter);
        protected IWebElement LinkTrustCenterElement => FindElement(LinkTrustCenter);
        protected IWebElement LinkTrademarksElement => FindElement(LinkTrademarks);
        protected IWebElement LinkLicenseAgreementsElement => FindElement(LinkLicenseAgreements);
        protected IWebElement LinkCodeOfConductElement => FindElement(LinkCodeOfConduct);
        protected IWebElement LabelDonotSellOrShareMyPersonalInformationElement => FindElement(By.XPath($""));

    }
}
