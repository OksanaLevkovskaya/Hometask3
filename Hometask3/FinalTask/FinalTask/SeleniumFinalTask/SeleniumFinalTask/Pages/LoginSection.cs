using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumFinalTask.Pages
{
    public class LoginSection: LandingPage
    {
        const string EMAIL_INPUT_FIELD_XPATH = "//*[@data-testid='login-input']";
        const string NEXT_BUTTON_XPATH = "//*[@data-testid='enter-password']";
        const string PASSWORD_INPUT_FIELD_XPATH = "//*[@data-testid='password-input']";
        const string LOGIN_BUTTON_XPATH = "//*[@data-testid='login-to-mail']";

        IWebElement _emailinputfield;
        IWebElement _passwordinputfield;
        IWebElement _nextbutton;
        IWebElement _loginbutton;

        public LoginSection(IWebDriver driver): base(driver)
        {
            _emailinputfield = GetElementByXpath(EMAIL_INPUT_FIELD_XPATH);
            _nextbutton = GetElementByXpath(NEXT_BUTTON_XPATH);
            _passwordinputfield = GetElementByXpath(PASSWORD_INPUT_FIELD_XPATH);
            _loginbutton = GetElementByXpath(LOGIN_BUTTON_XPATH);
        }

        string login = "oksanalevkovskaya22";
        string password = "jackdaniels1";
        

        public LoginSection LoginToMailBox(string login,string password)
        {
            _emailinputfield.SendKeys(login);
            _nextbutton.Click();
            _passwordinputfield.SendKeys(password);
            _loginbutton.Click();

            return null;
        }
        
    }
}
