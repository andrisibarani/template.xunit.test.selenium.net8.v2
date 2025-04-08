using Xunit;
using OpenQA.Selenium;
using template.xunit.test.selenium.net8_2.PageObjects;
using template.xunit.test.selenium.net8_2.Driver;

namespace template.xunit.test.selenium.net8_2
{
    public class ProductTest : TestBase
    {
        public ProductTest(DriverFixtureCollection driverFixtureCollection) : base(driverFixtureCollection)
        {
            chromeDriver = driverFixtureCollection.ChromeDriverFixture.Driver;
            //firefoxDriver = driverFixtureCollection.FirefoxDriverFixture.Driver;
            chromeDriver.Navigate().GoToUrl(new Uri("http://localhost:33084/"));
            //firefoxDriver.Navigate().GoToUrl(new Uri("http://localhost:33084/"));
        }


        [Fact]
        public void ViewListChrome()
        {
            ProductPage productPage = new ProductPage(chromeDriver);
            productPage.Dashboard("Product");
           // Assert.Contains("List", chromeDriver.Title);
        }
    }
}