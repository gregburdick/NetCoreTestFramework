// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using Framework.Enums;
using Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Tests
{
    [TestFixture(BrowserType.Chrome)]
    [TestFixture(BrowserType.InternetExplorer)]
    [TestFixture(BrowserType.FireFox)]
    [TestFixture(BrowserType.Edge)]
    public class GoogleSearchTest : BaseTest
    {
        public GoogleSearchTest(BrowserType type) : base(type) { }

        public GoogleHomePage _homePage;

        [Test(Description ="This will perform a google search")]
        [TestCase(TestName = "Search Google 1")]
        [Category("UITest")]
        public void SearchTermInGoogle()
        {
            PagesContext.GoogleHomePage.PerformSearch("Selenium");
        }

        [Test(Description = "This will perform a google search")]
        [TestCase(TestName = "Search Google 2")]
        [Category("UITest")]
        public void SearchTermInGoogle2()
        {
            PagesContext.GoogleHomePage.PerformSearch("C#");
        }

    }
}
