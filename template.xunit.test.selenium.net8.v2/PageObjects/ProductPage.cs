using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace template.xunit.test.selenium.net8_2.PageObjects
{
    public class ProductPage
    {
        private IWebDriver driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Dashboard(string title)
        {
            driver.FindElement(By.LinkText(title)).Click();
        }
    }
}