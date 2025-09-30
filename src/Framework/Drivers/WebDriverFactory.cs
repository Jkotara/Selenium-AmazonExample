using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace Framework.Drivers
{
    public static class WebDriverFactory
    {
        public static IWebDriver Create()
        {
            var browser = Environment.GetEnvironmentVariable("BROWSER") ?? "chrome";
            var headless = (Environment.GetEnvironmentVariable("HEADLESS") ?? "false").ToLower() == "true";

            if (browser.Equals("firefox", StringComparison.OrdinalIgnoreCase))
            {
                var ffOptions = new FirefoxOptions();
                if (headless) ffOptions.AddArgument("-headless");
                return new FirefoxDriver(ffOptions);
            }
            var co = new ChromeOptions();
            if (headless) co.AddArgument("--headless=new");
            co.AddArgument("--no-sandbox");
            co.AddArgument("--disable-dev-shm-usage");
            return new ChromeDriver(co);
        }
    }
}
