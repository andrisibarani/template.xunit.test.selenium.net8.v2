using OpenQA.Selenium;
using template.xunit.test.selenium.net8.v2.Driver;

namespace template.xunit.test.selenium.net8.v2
{
    public class TestBase : IClassFixture<DriverFixtureCollection>
    {
        protected IWebDriver chromeDriver;
        protected IWebDriver firefoxDriver;

        public TestBase(DriverFixtureCollection driverFixtureCollection)
        {
            chromeDriver = driverFixtureCollection.ChromeDriverFixture.Driver;
            firefoxDriver = driverFixtureCollection.FirefoxDriverFixture.Driver;
        }
    }
}
