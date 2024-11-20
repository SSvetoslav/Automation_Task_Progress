using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V128.Network;
using System.Text;

namespace Progress.Pages.Contact
{
    internal partial class ContactPage : WebPage
    {
        private const string English = "EN";
        private const string Deutsch = "DE";
        private const string Nederlands = "NL";
        private const string France = "RF";
        private const string Spain = "ES";
        private const string Portugal = "PT";
        private const string CzechRepublic = "CZ";
        private const string Japan = "JP";
        private const string Taiwan = "TW";

        // Labels - Contact form
        private By LabelGetInTouchElement(string value) => By.XPath($"//form//h5[text()='{value}']");
        private By LabelHowCanWeHelpElement(string value) => By.XPath($"//h1[@class='-mb2 -tac'][contains(.,'{value}')]");
        private By LabelProductElement(string value) => By.XPath($"//label[@for='Dropdown-1'][contains(.,'{value}')]");
        private By LabelBusinessEmailElement(string value) => By.XPath($"//label[@for='Email-1'][contains(.,'{value}')]");
        private By LabelFirstNameElement(string value) => By.XPath($"//label[@for='Textbox-1'][contains(.,'{value}')]");
        private By LabelLastNameElement(string value) => By.XPath($"//label[@for='Textbox-2'][contains(.,'{value}')]");
        private By LabelCompanyElement(string value) => By.XPath($"//label[@for='Textbox-3'][contains(.,'{value}')]");
        private By LabelIamElement(string value) => By.XPath($"//label[@for='Dropdown-2'][contains(.,'{value}')]");
        private By LabelCountryElement(string value) => By.XPath($"//label[@for='Country-1'][contains(.,'{value}')]");
        private By LabelPhoneElement(string value) => By.XPath($"//label[@for='Textbox-5'][contains(.,'{value}')]");
        private By LabelMessageElement(string value) => By.XPath($"//label[@for='Textarea-1'][contains(.,'{value}')]");
        private By ButtonContactSalesElement(string value) => By.XPath($"//button[@type='submit'][contains(.,'{value}')]");
        private By LabelIfYouHaveQuestionsElement(string value) => By.XPath($"//div[@id='Content_C036_Col00']//p[contains(., '{value}')]");


        // Fields - contact form
        private By DropDownProductElement = By.XPath("//select[@id='Dropdown-1']");
        private By InputBusinessEmailElement = By.XPath("//input[@id='Email-1']");
        private By InputFirstNameElement = By.XPath("//input[@id='Textbox-1']");
        private By InputLastNameElement = By.XPath("//input[@id='Textbox-2']");
        private By InputCompanyElement = By.XPath("//input[@id='Textbox-3']");
        private By DropDownIAmElement = By.XPath("//select[@id='Dropdown-2']");
        private By DropDownCountryElement = By.XPath("//select[@id='Country-1']");
        private By InputPhoneElement = By.XPath("//input[@id='Textbox-5']");
        private By InputMessageElement = By.XPath("//textarea[@id='Textarea-1']");
        private By CheckBoxIAgreeToReciveEmailElement = By.XPath("//input[@type='checkbox'][@class='js-i-agree-checkbox']");
        private By LinksLicalizations = By.XPath("//li[@class='has-dropdown no-mobile is-open']//ul[@id='js-prgs-nav-locales-desktop']//a");

        // Error messages
        private By ErrorMessageProductElement(string value) => By.XPath(DropDownProductElement.ToString().Replace("By.XPath: ", "") + @"//parent::div//p[@role='alert']");
        private By ErrorMessageBusinessEmailElement(string value) => By.XPath(InputBusinessEmailElement.ToString().Replace("By.XPath: ", "") + @"//parent::div//p[@role='alert']");
        private By ErrorMessageFirstNameElement(string value) => By.XPath(InputFirstNameElement.ToString().Replace("By.XPath: ", "") + @"//parent::div//p[@role='alert']");
        private By ErrorMessageLastNameElement(string value) => By.XPath(InputLastNameElement.ToString().Replace("By.XPath: ", "") + @"//parent::div//p[@role='alert']");
        private By ErrorMessageCompanyElement(string value) => By.XPath(InputCompanyElement.ToString().Replace("By.XPath: ", "") + @"//parent::div//p[@role='alert']");
        private By ErrorMessageCountryElement(string value) => By.XPath(DropDownCountryElement.ToString().Replace("By.XPath: ", "") + @"//parent::div//p[@role='alert']");
        private By ErrorMessagePhoneElement(string value) => By.XPath(InputPhoneElement.ToString().Replace("By.XPath: ", "") + @"//parent::div//p[@role='alert']");

        private By ErrorMessageFirstNameInvalidFormatElement(string value) => By.XPath($"//label[@for='Textbox-1']/..//p[@data-sf-role='error-message' and contains(., '{ErrorMessageFirstNameInvalidFormat}')]");
        private By ErrorMessageLastNameInvalidFormatElement(string value) => By.XPath($"//label[@for='Textbox-1']/..//p[@data-sf-role='error-message' and contains(., '{ErrorMessageLastNameInvalidFormat}')]");

        private By InputMessafesRedBorderelemnt = By.XPath(@"//div[contains(@class, 'collapse-inner sf-fieldWrp sfErrorWrp') or contains(@class, 'collapse-inner sf-fieldWrp Required sfErrorWrp')]//textarea");
        // Cookies
        private By ButtonOpenCookieElement(string value) => By.XPath($"//button[contains(@aria-label,'{value}')]");

        // Tabs presented on the left side at Cookie window
        private By TabCookieInformationElement(string value) => By.XPath($"//h3[contains(.,'{value}')]");

        // Toogle Buttons for each cookie value
        // Position true
        private By ToggleButtonPerformanceCookiesIsTrueElement(string value) => By.XPath($"//span[@class='ot-switch-nob']/..//span/..//span[contains(text(), '{value}')]/../span[@aria-checked='true']");
        private By ToggleButtonFunctionalCookiesIsTrueElement(string value) => By.XPath($"//span[@class='ot-switch-nob']/..//span/..//span[contains(text(), '{value}')]/../span[@aria-checked='true']");
        private By ToggleButtonTargetingCookiesIsTrueElement(string value) => By.XPath($"//span[@class='ot-switch-nob']/..//span/..//span[contains(text(), '{value}')]/../span[@aria-checked='true']");

        // Position false
        private By ToggleButtonPerformanceCookiesIsFalseElement(string value) => By.XPath($"//span[@class='ot-switch-nob']/..//span/..//span[contains(text(), '{value}')]/../span[@aria-checked='false']");
        private By ToggleButtonFunctionalCookiesIsFalseElement(string value) => By.XPath($"//span[@class='ot-switch-nob']/..//span/..//span[contains(text(), '{value}')]/../span[@aria-checked='false']");
        private By ToggleButtonTargetingCookiesIsFalseElement(string value) => By.XPath($"//span[@class='ot-switch-nob']/..//span/..//span[contains(text(), '{value}')]/../span[@aria-checked='false']");
        private By ButtonSaveSettingsElement(string value) => By.XPath($"//button[@class='save-preference-btn-handler onetrust-close-btn-handler'][contains(text(),'{value}')]");
        private By ButtonAllowAllElement(string value) => By.XPath($"//span[@class='ot-switch-nob']/..//span/..//span[contains(text(), '{value}')]/../span[@aria-checked='true']");
        private By ButtonCloseCookieElement = By.XPath("//button[contains(@id,'close-pc-btn-handler')]");

        // Cookie pop-up buttons
        private By ButtonAcceptCookiesAndCloseElement = By.XPath("//button[@id='onetrust-accept-btn-handler']");
        private By ButtonRejectAllCookiesElement = By.XPath("//button[@id='onetrust-reject-all-handler']");
        private By ButtonChangeSettingsCookiesElement = By.XPath("onetrust-pc-btn-handler");

        // Localization button
        private By LabelCurrenLocalizationElement = By.XPath("//li[@class='has-dropdown no-mobile']//span[@class='PRGS-is-active -vam -ttu']");
        private By ButtonLocalizationElement = By.XPath("//li[@class='has-dropdown no-mobile']");
        private By ButtonLocalizationExpandedElement = By.XPath("//li[@class='has-dropdown no-mobile is-open']");
       
    }
}
