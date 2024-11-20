using NUnit.Framework;
using OpenQA.Selenium.DevTools.V128.Debugger;
using Progress.Utils;

namespace Progress.Tests.UI.Positives
{
    internal class Positive_Tests_ContactPage : WebTest
    {
        public Positive_Tests_ContactPage(Localization localization) : base(localization) { }

        [SetUp]
        public void SetupContactPage()
        {
            contactPage.NavigateToContactPage();
        }

        [Test, Order(1)]
        public void Check_URL_Is_Correct_For_Current_Country()
        {
            contactPage.AcceptCookies();
            contactPage.SelectDifferentLanguage(Localization.Deutsch);
            contactPage.AssertURLOfThePageIsCorrectForChoosenLanguage();
        }

        [Test, Order(2)]
        public void Check_All_Labeles_Are_Presented_In_ContactForm()
        {
            contactPage.AcceptCookies();
            contactPage.AssertContactFormAllLabelsArePresented();
        }

        [Test, Order(5)]
        public void Check_Sccessfuly_Submit_Contact_Form_With_Valid_Data_All_Fields()
        {
            contactPage.AcceptCookies();
            contactPage.AssertContactFormAllLabelsArePresented();
            contactPage.FillContactFormAndSubmitIt(
                        Product.Chef,
                        Data.validEmail,
                        Data.validFirstName, 
                        Data.validLastName,
                        Data.validCompany,
                        Iam.Reseller,
                        Country.Bulgaria,
                        Data.validPhone,
                        Data.validMessage);
            thankYouPage.AssertThatThankYouMessageIsDisplayed();
        }

        [Test, Order(6)]
        public void Check_Sccessfuly_Submit_Contact_Form_With_Valid_Data_Only_Required_Fields()
        {
            contactPage.AcceptCookies();
            contactPage.AssertContactFormAllLabelsArePresented();
            contactPage.FillContactFormAndSubmitIt(
                        Product.Chef,
                        Data.validEmail,
                        Data.validFirstName, 
                        Data.validLastName,
                        Data.validCompany,
                        Iam.Reseller,
                        Country.Bulgaria,
                        Data.validPhone);
            thankYouPage.AssertThatThankYouMessageIsDisplayed();
        }

        [Test, Order(7)]
        public void Check_Sccessfuly_Submit_Contact_Form_With_Valid_Data_With_Max_Lenght()
        {
            contactPage.AcceptCookies();
            contactPage.AssertContactFormAllLabelsArePresented();
            contactPage.FillContactFormAndSubmitIt(
                        Product.Chef,
                        Data.validEmailMaxLenght64chars,
                        Data.validFirstNameMaxLenght50chars,
                        Data.validLastNameMaxLenght50chars,
                        Data.validCompanyMaxLenght100chars,
                        Iam.Reseller,
                        Country.Bulgaria,
                        Data.validPhoneMaxLenght30chars,
                        Data.validMessageMaxLenght2000chars);
            thankYouPage.AssertThatThankYouMessageIsDisplayed();
        }

        [Test, Order(8)]
        public void Check_Accept_Cookies_And_Verify_Than_ToogleButtons_Are_Selected_In_Cookie_Window()
        {
            contactPage.AcceptCookies();
            contactPage.ClickCookiesIcon();
            contactPage.ClickOnTabPerformanceCookies();
            contactPage.AssertPositionOfToggleButtonIsSetToTrueForPerformanceCookies();
            contactPage.ClickOnTabFunctionalCookies();
            contactPage.AssertPositionOfToggleButtonIsSetToTrueForFunctionalCookies();
            contactPage.ClickOnTabTargetingCookies();
            contactPage.AssertPositionOfToggleButtonIsSetToTrueForTargetingCookies();
        }

        [Test, Order(9)]
        public void Reject_Cookies_And_Verify_Than_ToogleButtons_Are_Not_Selected_In_Cookie_Window()
        {
            contactPage.RejectCookie();
            contactPage.ClickCookiesIcon();
            contactPage.ClickOnTabPerformanceCookies();
            contactPage.AssertPositionOfToggleButtonIsSetToFalseForPerformanceCookies();
            contactPage.ClickOnTabFunctionalCookies();
            contactPage.AssertPositionOfToggleButtonIsSetToFalseForFunctionalCookies();
            contactPage.ClickOnTabTargetingCookies();
            contactPage.AssertPositionOfToggleButtonIsSetToFalseForTargetingCookies();
        }

        // da proverq broq na simvolite koito se broqt v message poleto
    }
}
