using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFinalTask.Pages;
using System;


namespace MailRuTests
{
    [TestClass]
    public class PositiveChecks
    {
        [TestMethod]
        public void CheckUserisLoggedIn()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://mail.ru/";
            LoginSection loginSection = new LoginSection(driver);

            var thisIsInboxpage = loginSection.LoginToMailBox;
            string expectedTitle = "Входящие - Почта Mail.ru";
            string actualtitle = driver.Title;
            Assert.AreEqual(actualtitle, expectedTitle); ;
        }

        [TestMethod]
        public void CheckEmailIsSent()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://mail.ru/";
            MailBoxPage mailBoxPage = new MailBoxPage(driver);

            var thisIsEmailSentPage = mailBoxPage.ReplyEmail;
            string expectedTitle = "Письмо Отправлено";
            string actualtitle = driver.Title;
            Assert.AreEqual(actualtitle, expectedTitle);

        }
    }
}