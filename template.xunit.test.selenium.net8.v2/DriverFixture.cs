using OpenQA.Selenium;
using template.xunit.test.selenium.net8.v2.Driver;

namespace template.xunit.test.selenium.net8.v2
{
    public class DriverFixture : IDisposable
    {
        IWebDriver driver;
        public DriverFixture(BrowserType browserType)
        {
            driver = GetWebDriver(browserType);
        }

        public IWebDriver Driver => driver;

        private IWebDriver GetWebDriver(BrowserType browserType)
        {
            BrowserDriver driver = new BrowserDriver();
            return browserType switch
            {
                BrowserType.Chrome => driver.GetChromeDriver(),
                BrowserType.Firefox => driver.GetFirefoxDriver(),
                _ => driver.GetChromeDriver()
            };
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
