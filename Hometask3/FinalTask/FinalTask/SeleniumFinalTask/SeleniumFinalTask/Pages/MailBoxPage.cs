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
    public class MailBoxPage: LandingPage
    {

        const string EMAIL_SELECTION = "//a[contains(@data-id,'1:e3c78534365a0cc8:0')]";
        const string REPLY_BUTTON = "//span[contains(@title,'Ответить')]";
        const string BODY_FIELD = "/html/body/div[1]/div/div[2]/div/div[1]/div[2]/div[3]/div[5]/div/div/div[2]/div[1]";
        const string SEND_BUTTON= "/html/body/div[1]/div/div[2]/div/div[2]/div[1]/span[1]/span";
        const string SUCCESS = "/html/body/div[11]/div/div/div[2]/div[2]/div/div/div[2]/a";
        IWebElement _emailselection;
        IWebElement _replybutton;
        IWebElement _bodyfield;
        IWebElement _sendbutton;
        IWebElement _success;


        public MailBoxPage(IWebDriver driver) : base(driver)
        {
          _emailselection = GetElementByXpath(EMAIL_SELECTION);
          _replybutton = GetElementByXpath(REPLY_BUTTON);
          _bodyfield = GetElementByXpath(BODY_FIELD);
          _sendbutton = GetElementByXpath(SEND_BUTTON);
          _success = GetElementByXpath(SUCCESS);
            
        }

        string text = "This is a letter send via SeleniumTest";

        public MailBoxPage ReplyEmail(string text)
        {
            _emailselection.Click();
            _replybutton.Click();
            _bodyfield.Click();
            _bodyfield.SendKeys(text);
            _sendbutton.Click();

            return null;
        }


    }
}
