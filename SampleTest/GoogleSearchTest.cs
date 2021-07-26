﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using Framework.Enums;
using Framework.Handlers;
using Framework.Pages;
using log4net;
using log4net.Config;
using NLog;
using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;
using System.Reflection;

namespace Tests
{
    [TestFixture(BrowserType.Chrome)]
    [TestFixture(BrowserType.InternetExplorer)]
    [TestFixture(BrowserType.FireFox)]
    [TestFixture(BrowserType.Edge)]
    public class GoogleSearchTest : BaseTest
    {
        //private static NLog.Logger logger = LogManager.GetLogger("logRules");
        
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
            TestLogger.GetInstance().Info("test");
            PagesContext.GoogleHomePage.PerformSearch("C#");

        }

    }
}
