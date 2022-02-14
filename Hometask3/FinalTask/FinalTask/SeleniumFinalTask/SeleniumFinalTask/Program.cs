using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFinalTask.Pages
{
    public class Program
    {
        public static void Main(string[] args)
        {
           IWebDriver driver = new ChromeDriver();
            driver.Url = "https://mail.ru/";

           LoginSection loginSection = new LoginSection(driver);
           MailBoxPage mailBoxPage = new MailBoxPage(driver);

            var thisIsInboxpage = loginSection.LoginToMailBox;
            var emailSent = mailBoxPage.ReplyEmail;
           
           driver.Quit();
        }
    }
}