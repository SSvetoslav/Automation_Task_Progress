using NUnit.Framework;
using Progress.Utils;
using System.Reflection.Metadata.Ecma335;

namespace Progress.Pages.Contact
{
    internal partial class ContactPage : WebPage
    {
        public void AssertContactFormAllLabelsArePresented()
        {
            Assert.DoesNotThrow(() => 
            {
                Assert.That(AssertLabelGetInTouchElementIsPresented(), Is.EqualTo(true));
            }, $"Error: The '{LabelGetInTouch}' label is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertLabelHowCanWeHelpElementIsPresented(), Is.EqualTo(true));
            }, $"Error: The '{LabelHowCanWeHelp}' label is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertLabelProductElementIsPresented(), Is.EqualTo(true));
            }, $"Error: The '{LabelProduct}' label is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertLabelBusinessEmailElementIsDisplayed, Is.EqualTo(true));
            }, $"Error: The '{LabelBusinessEmail}' label is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertLabelFirstNameElementIsDisplayed, Is.EqualTo(true));
            }, $"Error: The '{LabelFirstName}' label is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertLabelLastNameElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The '{LabelLastName}' label is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertLabelCompanyElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The '{LabelCompany}' label is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertLabelIamElementIsDisplayed, Is.EqualTo(true));
            }, $"Error: The '{LabelIam}' label is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertLabelCountryElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The '{LabelCountry}' label is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertLabelPhoneElementIsDisplayed, Is.EqualTo(true));
            }, $"Error: The '{LabelPhone}' label is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertLabelMessageElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The '{LabelMessage}' label is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertButtonContactSalesElementIsDisplayed, Is.EqualTo(true));
            }, $"Error: The '{ButtonContactSales}' button is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertLabelIfYouHaveQuestionsElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The '{LabelIfYouHaveQuestions}' label is not displayed for {Localization}.");
        }

        public void AssertURLOfThePageIsCorrectForChoosenLanguage()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(GetUrl(), Is.EqualTo(url));
            }, $"Error: Presented url is: {GetUrl()}!");
        }

        public void AsserErrorMessagesInvalidFormatForFirstAndLastNameFieldsArePresented()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertErrorMessgeFistNameEmptyFieldElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The message '{ErrorMessageFirstNameInvalidFormat}' is not displayed for {Localization}");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertErrorMessgeLastNameEmptyFieldElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The message '{ErrorMessageLastNameInvalidFormat}' is not displayed for {Localization}");
        }

        public void AsserErrorMessagesInvalidFormatForFirstNameFieldIsPresented()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertErrorMessgeFistNameEmptyFieldElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The message '{ErrorMessageFirstNameInvalidFormat}' is not displayed for {Localization}");
        }

        public void AsserErrorMessagesAreDisplayed()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertErrorMessageProductElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The message '{ErrorMessageProduct}' is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertErrorMessageBusinessEmailElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The message '{ErrorMessageBusinessEmail}' is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertErrorMessageFirstNameElementIsdisplayed(), Is.EqualTo(true));
            }, $"Error: The message '{ErrorMessageFirstName}' is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertErrorMessageLastNameElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The message '{ErrorMessageLastName}' is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertErrorMessageCompanyElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The message '{ErrorMessageCompany}' is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertErrorMessageCountryElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The message '{ErrorMessageCountry}' is not displayed for {Localization}.");
            Assert.DoesNotThrow(() =>
            {
                Assert.That(AssertErrorMessagePhoneElementIsDisplayed(), Is.EqualTo(true));
            }, $"Error: The message '{ErrorMessagePhone}' is not displayed for {Localization}.");
        }

        public void AssertPositionOfToggleButtonIsSetToTrueForPerformanceCookies()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(FindElement(ToggleButtonPerformanceCookiesIsTrueElement(TabPerformanceCookies)).Displayed, Is.EqualTo(true));
            }, $"Error: Toggle button for {TabPerformanceCookies} is not set to false.");
        }

        public void AssertPositionOfToggleButtonIsSetToTrueForFunctionalCookies()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(FindElement(ToggleButtonFunctionalCookiesIsTrueElement(TabFunctionalCookies)).Displayed, Is.EqualTo(true));
            }, $"Error: Toggle button for {TabFunctionalCookies} is not set to false.");
        }

        public void AssertPositionOfToggleButtonIsSetToTrueForTargetingCookies()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(FindElement(ToggleButtonTargetingCookiesIsTrueElement(TabTargetingCookies)).Displayed, Is.EqualTo(true));
            }, $"Error: Toggle button for {TabTargetingCookies} is not set to false.");
        }

        public void AssertPositionOfToggleButtonIsSetToFalseForPerformanceCookies()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(FindElement(ToggleButtonPerformanceCookiesIsFalseElement(TabPerformanceCookies)).Displayed, Is.EqualTo(true));
            }, $"Error: Toggle button for {TabPerformanceCookies} is not set to true.");
        }

        public void AssertPositionOfToggleButtonIsSetToFalseForFunctionalCookies()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(FindElement(ToggleButtonFunctionalCookiesIsFalseElement(TabFunctionalCookies)).Displayed, Is.EqualTo(true));
            }, $"Error: Toggle button for {TabFunctionalCookies} is not set to true.");
        }

        public void AssertPositionOfToggleButtonIsSetToFalseForTargetingCookies()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(FindElement(ToggleButtonTargetingCookiesIsFalseElement(TabTargetingCookies)).Displayed, Is.EqualTo(true));
            }, $"Error: Toggle button for {TabTargetingCookies} is not set to true.");
        }

        public void AsserErrorMessageInvalidEmailIsDisplayed()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(FindElement(ErrorMessageBusinessEmailElement(ErrorMessageBusinessEmail)).Displayed, Is.EqualTo(true));
            }, $"Error: The message '{ErrorMessageBusinessEmail}' is not displayed for {Localization}.");
        }

        public void AssertRedBorderIsForMessageFieldIsDisplayed()
        {
            Assert.DoesNotThrow(() =>
            {
                Assert.That(CetCSSValueRedBorderMessageField(), Is.EqualTo(RGBColorValue));
            }, $"Error: The red border for Message field is not displayed for {Localization}.");
        }

        private bool AssertLabelGetInTouchElementIsPresented() => FindElement(LabelGetInTouchElement(LabelGetInTouch)).Displayed;
        private bool AssertLabelHowCanWeHelpElementIsPresented() => FindElement(LabelHowCanWeHelpElement(LabelHowCanWeHelp)).Displayed;
        private bool AssertLabelProductElementIsPresented() => FindElement(LabelProductElement(LabelProduct)).Displayed;
        private bool AssertLabelBusinessEmailElementIsDisplayed() => FindElement(LabelBusinessEmailElement(LabelBusinessEmail)).Displayed;
        private bool AssertLabelFirstNameElementIsDisplayed() => FindElement(LabelFirstNameElement(LabelFirstName)).Displayed;
        private bool AssertLabelLastNameElementIsDisplayed() => FindElement(LabelLastNameElement(LabelLastName)).Displayed;
        private bool AssertLabelCompanyElementIsDisplayed()  => FindElement(LabelCompanyElement(LabelCompany)).Displayed;
        private bool AssertLabelIamElementIsDisplayed() => FindElement(LabelIamElement(LabelIam)).Displayed;
        private bool AssertLabelCountryElementIsDisplayed() => FindElement(LabelCountryElement(LabelCountry)).Displayed;
        private bool AssertLabelPhoneElementIsDisplayed() => FindElement(LabelPhoneElement(LabelPhone)).Displayed;
        private bool AssertLabelMessageElementIsDisplayed() => FindElement(LabelMessageElement(LabelMessage)).Displayed;
        private bool AssertButtonContactSalesElementIsDisplayed() => FindElement(ButtonContactSalesElement(ButtonContactSales)).Displayed;
        private bool AssertLabelIfYouHaveQuestionsElementIsDisplayed() => FindElement(LabelIfYouHaveQuestionsElement(LabelIfYouHaveQuestions)).Displayed;
        private bool AssertErrorMessageProductElementIsDisplayed() => FindElement(ErrorMessageProductElement(ErrorMessageProduct)).Displayed;
        private bool AssertErrorMessageBusinessEmailElementIsDisplayed() => FindElement(ErrorMessageBusinessEmailElement(ErrorMessageBusinessEmail)).Displayed;
        private bool AssertErrorMessageFirstNameElementIsdisplayed() => FindElement(ErrorMessageFirstNameElement(ErrorMessageFirstName)).Displayed;
        private bool AssertErrorMessageLastNameElementIsDisplayed() => FindElement(ErrorMessageLastNameElement(ErrorMessageLastName)).Displayed;
        private bool AssertErrorMessageCompanyElementIsDisplayed() => FindElement(ErrorMessageCompanyElement(ErrorMessageCompany)).Displayed;
        private bool AssertErrorMessageCountryElementIsDisplayed() => FindElement(ErrorMessageCountryElement(ErrorMessageCountry)).Displayed;
        private bool AssertErrorMessagePhoneElementIsDisplayed() => FindElement(ErrorMessagePhoneElement(ErrorMessagePhone)).Displayed;
        private bool AssertErrorMessgeFistNameEmptyFieldElementIsDisplayed() => FindElement(ErrorMessageFirstNameInvalidFormatElement(ErrorMessageFirstNameInvalidFormat)).Displayed;
        private bool AssertErrorMessgeLastNameEmptyFieldElementIsDisplayed() => FindElement(ErrorMessageLastNameInvalidFormatElement(ErrorMessageLastNameInvalidFormat)).Displayed;
    }
}
