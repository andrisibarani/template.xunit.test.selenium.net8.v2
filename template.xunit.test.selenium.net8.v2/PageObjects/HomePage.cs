using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace template.xunit.test.selenium.net8_2.PageObjects
{
    public class BrowserDriver
    {
        private IWebDriver driver;

        public BrowserDriver(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}