using NUnit.Framework;
using Progress.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Tests.UI.Negatives
{
    internal class Negative_Tests_ContactPage : WebTest
    {
        public Negative_Tests_ContactPage(Localization localization) : base(localization) { }

        [SetUp]
        public void SetupContactPage()
        {
            contactPage.NavigateToContactPage();
        }

        [Test, Order(1)]
        public void Check_Error_Message_Is_Displayed_When_Submit_Contact_Form_With_Invalid_Email()
        {
            contactPage.AcceptCookies();
            contactPage.AssertContactFormAllLabelsArePresented();
            contactPage.FillContactFormAndSubmitIt(
                Product.Chef,
                Data.invalidEmail,
                Data.validFirstName, Data.validLastName,
                Data.validCompany,
                Iam.Reseller,
                Country.Bulgaria,
                Data.validPhone,
                Data.validMessage);
            contactPage.AsserErrorMessageInvalidEmailIsDisplayed();
        }

        // Error message for I am ... field is not presented for EN, DE, NL, FR, PT, CS, JP, TW
        [Test, Order(2)]
        public void Check_All_ErrorMessages_Are_Presented_When_Submit_Empty_ContactForm()
        {
            contactPage.AcceptCookies();
            contactPage.AssertContactFormAllLabelsArePresented();
            contactPage.SubmitContactForm();
            contactPage.AsserErrorMessagesAreDisplayed();
        }

        [Test, Order(3)]
        public void Check_Error_Message_Is_Displayed_When_Submit_Contact_Form_With_SQLInjection_In_FirstName_Field()
        {
            contactPage.AcceptCookies();
            contactPage.FillContactFormAndSubmitIt(
                        Product.Chef,
                        Data.validEmail,
                        Data.sqlInjection,
                        Data.validLastName,
                        Data.validCompany,
                        Iam.Reseller,
                        Country.Bulgaria,
                        Data.validPhone,
                        Data.validMessage);
            contactPage.AsserErrorMessagesInvalidFormatForFirstNameFieldIsPresented();
        }

        [Test, Order(4)]
        public void Check_Error_Message_Is_Displayed_When_Submit_Contact_Form_With_XSS_In_Message_Field()
        {
            contactPage.AcceptCookies();
            contactPage.FillContactFormAndSubmitIt(
                        Product.Chef,
                        Data.validEmail,
                        Data.sqlInjection,
                        Data.validLastName,
                        Data.validCompany,
                        Iam.Reseller,
                        Country.Bulgaria,
                        Data.validPhone,
                        Data.validMessage);
            contactPage.AsserErrorMessagesInvalidFormatForFirstNameFieldIsPresented();
        }

        [Test, Order(5)]
        public void Check_RedBorder_Is_Displayed_When_Fill_XSScript_In_Message_Field()
        {
            contactPage.AcceptCookies();
            contactPage.FillContactFormAndSubmitIt(
                        Product.Chef,
                        Data.validEmail,
                        Data.validFirstName,
                        Data.validLastName,
                        Data.validCompany,
                        Iam.Reseller,
                        Country.Bulgaria,
                        Data.validPhone,
                        Data.xssScript);
            contactPage.AssertRedBorderIsForMessageFieldIsDisplayed();

            // user is at the same page
            contactPage.AssertContactFormAllLabelsArePresented();
        }

        [Test, Order(6)]
        public void Check_ErrorMessages_Are_Presented_When_Fill_EmptySpaces_At_FirtAndLastName_Fields()
        {
            contactPage.AcceptCookies();
            contactPage.FillContactFormAndSubmitIt(
                        Product.Chef,
                        Data.validEmail,
                        Data.whiteSpacesFirstName,
                        Data.whiteSpacesLastName,
                        Data.validCompany,
                        Iam.Reseller,
                        Country.Bulgaria,
                        Data.validPhone,
                        Data.validMessage);
            contactPage.AsserErrorMessagesInvalidFormatForFirstAndLastNameFieldsArePresented();
        }
    }
}
