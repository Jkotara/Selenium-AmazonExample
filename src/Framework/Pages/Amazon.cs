using OpenQA.Selenium;

namespace Framework.Pages
{
    public class Amazon
    {
        private readonly IWebDriver webDriver;
        private readonly By searchBox = By.Name("field-keywords");
        private readonly By results = By.XPath("//div[@id=\"search\"]//h2/span[contains(text(),'1-48 of over')]");
        //private readonly By results = By.Id("result-stats");

        public Amazon(IWebDriver driver)
        {
            webDriver = driver;
        }

        public void Navigate() => webDriver.Navigate().GoToUrl("https://www.Amazon.com");

        public void Search(string text)
        {
            var box = webDriver.FindElement(searchBox);
            box.Clear();
            box.SendKeys(text + Keys.Enter);
        }

        public bool HasResults() => webDriver.FindElements(results).Count > 0;
    }
}
