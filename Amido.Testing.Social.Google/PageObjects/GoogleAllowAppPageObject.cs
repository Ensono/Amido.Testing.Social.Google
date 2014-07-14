using System;

using Amido.WebDriver.Utilities.Extensions;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Amido.Testing.Social.Google.PageObjects
{
    public class GoogleAllowAppPageObject
    {
        private static Func<IWebDriver> webDriver;

        public static void Init(Func<IWebDriver> webDriverFunc)
        {
            webDriver = webDriverFunc;
        }

        public GoogleAllowAppPageObject()
        {
            if (webDriver == null)
            {
                throw new Exception("You must call GoogleAllowAppPageObject.Init once before using this class");
            }

            PageFactory.InitElements(webDriver(), this);
        }

        [FindsBy(How = How.Name, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Name, Using = "Passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "signIn")]
        public IWebElement SignInAllow { get; set; }

        public bool IsLoaded()
        {
            return this.SignInAllow.WaitUntil(e => e.Displayed).Displayed;
        }
    }
}
