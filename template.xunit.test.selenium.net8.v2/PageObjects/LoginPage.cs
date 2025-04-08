using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace template.xunit.test.selenium.net8_2.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void EnterUsername(string username)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(By.Name("password")).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(By.Name("login")).Click();
        }
    }
}