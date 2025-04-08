using Xunit;
using OpenQA.Selenium;
using template.xunit.test.selenium.net8.v2.PageObjects;
using template.xunit.test.selenium.net8.v2.Driver;

namespace template.xunit.test.selenium.net8.v2
{
    public class LoginTest : TestBase
    {
        public LoginTest(DriverFixtureCollection driverFixtureCollection) : base(driverFixtureCollection)
        {
            chromeDriver = driverFixtureCollection.ChromeDriverFixture.Driver;
            firefoxDriver = driverFixtureCollection.FirefoxDriverFixture.Driver;
            chromeDriver.Navigate().GoToUrl(new Uri("http://localhost:33084/"));
            firefoxDriver.Navigate().GoToUrl(new Uri("http://localhost:33084/"));
        }

        [Fact]
        public void TestLoginChrome()
        {
            LoginPage loginPage = new LoginPage(chromeDriver);
            loginPage.EnterUsername("username");
            loginPage.EnterPassword("password");
            loginPage.ClickLoginButton();

            Assert.Contains("Home Page", chromeDriver.Title);
        }

        [Fact]
        public void TestLoginFirefox()
        {
            LoginPage loginPage = new LoginPage(firefoxDriver);
            loginPage.EnterUsername("username");
            loginPage.EnterPassword("password");
            loginPage.ClickLoginButton();

            Assert.Contains("Home Page", firefoxDriver.Title);
        }
    }
}