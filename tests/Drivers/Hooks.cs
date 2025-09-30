using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Framework.Drivers;

namespace Tests.Drivers
{
    [Binding]
    public sealed class Hooks
    {
        public static IWebDriver? Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = WebDriverFactory.Create();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver?.Quit();
            Driver = null;
        }
    }
}
