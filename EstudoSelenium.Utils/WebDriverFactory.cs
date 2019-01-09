﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace EstudoSelenium.Utils
{
    public static class WebDriverFactory
    {

        public static IWebDriver CreateWebDriver(Browser browser, string pathDriver)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browser.Firefox:
                    var service = FirefoxDriverService.CreateDefaultService(pathDriver);
                    webDriver = new FirefoxDriver(service);
                    break;
                case Browser.Chrome:
                    webDriver = new ChromeDriver(pathDriver);
                    break;
            }

            return webDriver;
        }
    }
}