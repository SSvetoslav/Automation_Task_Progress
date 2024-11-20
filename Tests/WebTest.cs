using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Progress.Pages.Contact;
using Progress.Pages.ThankYou;
using System.Text.RegularExpressions;

namespace Progress.Tests
{
    [TestFixture(Utils.Localization.England)]
    //[TestFixture(Utils.Localization.Deutsch)]
    //[TestFixture(Utils.Localization.Nederlands)]
    //[TestFixture(Utils.Localization.France)]
    //[TestFixture(Utils.Localization.Spain)]
    //[TestFixture(Utils.Localization.Portugal)]
    //[TestFixture(Utils.Localization.CzechRepublic)]
    //[TestFixture(Utils.Localization.Japan)]
    //[TestFixture(Utils.Localization.Taiwan)]
    internal class WebTest
    {
        private readonly Utils.Localization localization;
        private IWebDriver Driver;
        protected ContactPage contactPage;
        protected ThankYouPage thankYouPage;

        public WebTest(Utils.Localization localization)
        {
            this.localization = localization;
        }

        [SetUp]
        public void SetUp()
        {
            ChromeOptions chromeOptions = new();
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            chromeOptions.AddArgument("--disable-search-engine-choice-screen");
            //chromeOptions.AddArgument("--headless=old");
            chromeOptions.AddArgument("window-size=1920, 1080");
            try
            {
                Driver = new ChromeDriver(chromeOptions);
                Driver.Manage().Window.Maximize();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            }
            catch (WebDriverException ex)
            {
                Driver?.Quit();
                Driver?.Dispose();
                Driver = new ChromeDriver(chromeOptions);
                Driver.Manage().Window.Maximize();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Console.WriteLine($"WebDriver execption: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Driver?.Quit();
                Driver?.Dispose();
                Console.WriteLine($"WebDriver is not started!.\nMessage: {ex.Message} \nStackTrace {ex.StackTrace}");
            }

            contactPage = new ContactPage(Driver, localization);
            thankYouPage = new ThankYouPage(Driver, localization);

        }

        [TearDown]
        public void TearDown()
        {
            if (Driver != null)
            {
                if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
                {
                    string fileName = Regex.Replace(TestContext.CurrentContext.Test.Name, "[^a-zA-Z0-9_]+", "");
                    var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
                    var ss = ((ITakesScreenshot)Driver).GetScreenshot();
                    ss.SaveAsFile(path + "\\" + fileName + DateTime.Now.ToString("dd-MM-yyyy") + ".png");

                    Driver.Quit();
                    Driver.Dispose();
                }
                else
                {
                    Driver.Quit();
                    Driver.Dispose();
                }
            }
        }
    }
}
