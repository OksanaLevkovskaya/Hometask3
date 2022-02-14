using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFinalTask;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFinalTask.Pages
{
   public abstract class LandingPage
    {
        protected IWebDriver _driver;

        protected LandingPage(IWebDriver driver)
        {
            _driver = driver;
        }

        protected IWebElement GetElementByXpath(string xpath)
        {
            int attemptCount = 0;
            while (attemptCount < 10)
            {
                try
                {
                    return _driver.FindElement(By.XPath(xpath));
                }
                catch
                {
                    Thread.Sleep(2000);
                    attemptCount++;
                }
            }
            return null;

        }


    }
}

