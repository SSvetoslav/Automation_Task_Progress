using NUnit.Framework;

namespace Progress.Pages.ThankYou
{
    internal partial class ThankYouPage : WebPage
    {
        public void AssertThatThankYouMessageIsDisplayed()
        {
            Assert.DoesNotThrow(() =>
            {
               Assert.That(FindElement(LabelThankYouelement).Displayed, Is.EqualTo(true));
            }, "Error: Thank you message is not displayed!");
        }
    }
}
