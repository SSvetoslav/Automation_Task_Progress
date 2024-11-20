using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Communication;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Progress.Utils;
using System.Resources;
using System.Security.Cryptography.X509Certificates;

namespace Progress.Pages.Contact
{
    internal partial class ContactPage : WebPage
    {
        protected string lang { get; private set; }
        private string url;
        protected string PageUrl;

        public ContactPage(IWebDriver driver, Localization localisation) : base(driver, localisation)
        {
            switch (localisation)
            {
                case Localization.England: SetLinkEngland(); break;
                case Localization.Deutsch: SetLinkDeutsch(); break;
                case Localization.Nederlands: SetLinkNederland(); break;
                case Localization.France: SetLinkFrance(); break;
                case Localization.Spain: SetLinkSpain(); break;
                case Localization.Portugal: SetLinkPortugal(); break;
                case Localization.CzechRepublic: SetLinkCzechRepublic(); break;
                case Localization.Japan: SetLinkJapan(); break;
                case Localization.Taiwan: SetLinkTaiwan(); break;
            }
        }

        public void FillContactFormAndSubmitIt(
    Product product,
    string email,
    string firstName,
    string lastName,
    string company,
    Iam iam,
    Country country,
    string phone,
    string message = null)
        {
            SelectProduct(product);
            EnterBussinesEmail(email);
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterCompany(company);
            SelectIam(iam);
            SelectCountry(country);
            EnterPhone(phone);
            EnterMessage(message);
            ClickIAgreeCheckBox();
            ClickSubmitFormButton(ButtonContactSales);
        }

        public void RejectCookie()
        {
            try
            {
                if (!ElementPresent(ButtonRejectAllCookiesElement))
                {
                    WaitsUntilVisible(ButtonRejectAllCookiesElement);
                    ClickJS(ButtonRejectAllCookiesElement);
                }
                else
                {
                    ClickJS(ButtonRejectAllCookiesElement);
                }

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Cookies are not presented!\nWait 10 seconds again and try to reject them!");
                if (!ElementPresent(ButtonRejectAllCookiesElement))
                {
                    WaitsUntilVisible(ButtonRejectAllCookiesElement);
                    ClickJS(ButtonRejectAllCookiesElement);
                }
                else
                {
                    ClickJS(ButtonRejectAllCookiesElement);
                }
            }

        }

        public void AcceptCookies()
        {
            try
            {
                if (!ElementPresent(ButtonAcceptCookiesAndCloseElement))
                {
                    WaitsUntilVisible(ButtonAcceptCookiesAndCloseElement);
                    ClickJS(ButtonAcceptCookiesAndCloseElement);
                }
                else
                {
                    ClickJS(ButtonAcceptCookiesAndCloseElement);
                }

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Cookies are not presented after!\nWait 10 seconds again and try to accept them!");
                if (!ElementPresent(ButtonAcceptCookiesAndCloseElement))
                {
                    WaitsUntilVisible(ButtonAcceptCookiesAndCloseElement);
                    ClickJS(ButtonAcceptCookiesAndCloseElement);
                }
                else
                {
                    ClickJS(ButtonAcceptCookiesAndCloseElement);
                }
            }
        }

        public void SubmitContactForm()
        {
            ClickSubmitFormButton(ButtonContactSales);
        }

        public void ClickCookiesIcon()
        {
            Click(ButtonOpenCookieElement(ButtonCookie));
        }

        public void ClickOnTabPerformanceCookies()
        {
            Click(TabCookieInformationElement(TabPerformanceCookies));
        }

        public void ClickOnTabFunctionalCookies()
        {
            Click(TabCookieInformationElement(TabFunctionalCookies));
        }

        public void ClickOnTabTargetingCookies()
        {
            Click(TabCookieInformationElement(TabTargetingCookies));
        }

        public void NavigateToContactPage()
        {
            StartApp(PageUrl);
        }

        public void SelectDifferentLanguage(Localization localization)
        {
            SetLanguage(localization);
            string currenLeng = GetAttribute(LabelCurrenLocalizationElement, "innerText");
            if ((currenLeng == "EN") && (Localization.England == localization))
            {
                Console.WriteLine(Message());
            }
            else if ((currenLeng == "DE") && (Localization.Deutsch == localization))
            {
                Console.WriteLine(Message());
            }
            else if ((currenLeng == "NL") && (Localization.Nederlands == localization))
            {
                Console.WriteLine(Message());
            }
            else if ((currenLeng == "RF") && (Localization.France == localization))
            {
                Console.WriteLine(Message());
            }
            else if ((currenLeng == "ES") && (Localization.Spain == localization))
            {
                Console.WriteLine(Message());
            }
            else if ((currenLeng == "PT") && (Localization.Portugal == localization))
            {
                Console.WriteLine(Message());
            }
            else if ((currenLeng == "CZ") && (Localization.CzechRepublic == localization))
            {
                Console.WriteLine(Message());
            }
            else if ((currenLeng == "JP") && (Localization.Japan == localization))
            {
                Console.WriteLine(Message());
            }
            else if ((currenLeng == "TW") && (Localization.Taiwan == localization))
            {
                Console.WriteLine(Message());
            }
            else
            {
                HooverElement(ButtonLocalizationElement);
                IList<IWebElement> elements = FindElements(LinksLicalizations);
                IWebElement element = elements.Where(e => e.Text == lang).First();
                element.Click();
            }
        }

        private void SetLanguage(Localization localization)
        {
            switch (localization)
            {
                case Localization.England: lang = "English"; url = URLContactPageEngland; break;
                case Localization.Deutsch: lang = "Deutsch"; url = URLContactPageDeutsch; break;
                case Localization.Nederlands: lang = "Nederlands"; url = URLContactPageNederlands; break;
                case Localization.France: lang = "Français"; url = URLContactPageFrance; break;
                case Localization.Spain: lang = "Español"; url = URLContactPageSpain; break;
                case Localization.Portugal: lang = "Portuguese"; url = URLContactPagePortugal; break;
                case Localization.CzechRepublic: lang = "Czech"; url = URLContactPageCzechRepublic; break;
                case Localization.Japan: lang = "日本語"; url = URLContactPageJapan; break;
                case Localization.Taiwan: lang = "繁體中文"; url = URLContactPageTaiwan; break;
            }
        }

        private string Message()
        {
            return "The choosen country is already selected!";
        }
        private void SetLinkEngland()
        {
            PageUrl = URLContactPageEngland;
        }
        private void SetLinkDeutsch()
        {
            PageUrl = URLContactPageDeutsch;
        }
        private void SetLinkNederland()
        {
            PageUrl = URLContactPageNederlands;
        }
        private void SetLinkFrance()
        {
            PageUrl = URLContactPageFrance;
        }
        private void SetLinkSpain()
        {
            PageUrl = URLContactPageSpain;
        }
        private void SetLinkPortugal()
        {
            PageUrl = URLContactPagePortugal;
        }
        private void SetLinkCzechRepublic()
        {
            PageUrl = URLContactPageCzechRepublic;
        }
        private void SetLinkJapan()
        {
            PageUrl = URLContactPageJapan;
        }
        private void SetLinkTaiwan()
        {
            PageUrl = URLContactPageTaiwan;
        }

        private void SelectProduct(Product productToSelectValue)
        {
            SelectsDropDownItem(DropDownProductElement, productToSelectValue.ToString());   
        }

        private void EnterBussinesEmail(string email)
        {
            Type(InputBusinessEmailElement, email);
        }

        private void EnterFirstName(string firstName)
        {
            Type(InputFirstNameElement, firstName);
        }

        private void EnterLastName(string lastName)
        {
            Type(InputLastNameElement, lastName);
        }

        private void EnterCompany(string company)
        {
            Type(InputCompanyElement, company);
        }

        private void SelectIam(Iam iamValie)
        {
            SelectsDropDownItem(DropDownIAmElement, iamValie.ToString());
        }

        private void SelectCountry(Country country)
        {
            SelectsDropDownItem(DropDownCountryElement, country.ToString());
        }

        private void EnterPhone(string phone)
        {
            Type(InputPhoneElement, phone);
        }

        private void EnterMessage(string message)
        {
            if (message != null)
            {
                Type(InputMessageElement, message);
            }           
        }

        private void ClickIAgreeCheckBox()
        {
            if (ElementPresent(CheckBoxIAgreeToReciveEmailElement))
            {
                Click(CheckBoxIAgreeToReciveEmailElement);
            }
        }

        private void ClickSubmitFormButton(string value)
        {
            Click(ButtonContactSalesElement(value));
        }

        private string CetCSSValueRedBorderMessageField()
        {
            return GetCSSValue(InputMessafesRedBorderelemnt, "border-color");
        }


    }
}
