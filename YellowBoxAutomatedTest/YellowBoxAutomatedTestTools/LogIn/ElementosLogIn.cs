using OpenQA.Selenium;

namespace YellowBoxAutomatedTestTools.WebDriverElementos
{
    class LogInElements
    {
        public IWebElement UserNameElement(IWebDriver driver)
        {
            IWebElement userTextBox = driver.FindElement(By.Id("UserName"));
            return userTextBox;
        }

        public IWebElement UserPassword(IWebDriver driver)
        {
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            return passwordTextBox;
        }
    }
}
