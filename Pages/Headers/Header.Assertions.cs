using NUnit.Framework;

namespace Progress.Pages.StaticElements.Header
{
    internal partial class Header : WebPage
    {
        protected void AssertallHearesArePresented()
        {
            Assert.Multiple(() =>
            {
                Assert.That(LogoProgressElement.Displayed, "Logo 'Progress' in header is not displayed!");
                Assert.That(DropDownSolutionsElement.Displayed, "Drop down 'Solution' is not displayed!");
                Assert.That(DropDownProductsElement.Displayed, "Drop down 'Solution' is not displayed!");
                Assert.That(DropDownSupportAndServicesElement.Displayed, "Drop down 'Suppot and service' is not displayed!");
                Assert.That(DropDownResourcesElement.Displayed, "Drop down 'Resource' is not displayed!");
                Assert.That(DropDownPartnersElement.Displayed, "Drop down 'Partner' is not displayed!");
                Assert.That(DropDownCompanyElement.Displayed, "Drop down 'Company' is not displayed!");
                Assert.That(IconSearchElement.Displayed, "Icon 'Search' is not displayed!");
                Assert.That(IconUserElement.Displayed, "Icon 'User' is not displayed!");
                Assert.That(LinkReadyToTalkElement.Displayed, "Link 'READY TO TALK?' is not displayed!");
            });
        }
    }
}
