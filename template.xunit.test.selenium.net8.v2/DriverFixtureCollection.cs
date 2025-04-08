using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template.xunit.test.selenium.net8.v2.Driver;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace template.xunit.test.selenium.net8.v2
{
    public class DriverFixtureCollection : IDisposable
    {
        public DriverFixture ChromeDriverFixture { get; }
        public DriverFixture FirefoxDriverFixture { get; }

        public DriverFixtureCollection()
        {
            ChromeDriverFixture = new DriverFixture(BrowserType.Chrome);
            FirefoxDriverFixture = new DriverFixture(BrowserType.Firefox);
        }

        public void Dispose()
        {
            ChromeDriverFixture.Dispose();
            FirefoxDriverFixture.Dispose();
        }
    }
}
