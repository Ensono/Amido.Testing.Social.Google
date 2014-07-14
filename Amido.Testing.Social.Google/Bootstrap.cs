using System;

using Amido.Testing.Social.Google.PageObjects;

using OpenQA.Selenium;

namespace Amido.Testing.Social.Google
{
    public static class Bootstrap
    {
        public static void Init(Func<IWebDriver> webDriver)
        {
            GoogleAllowAppPageObject.Init(webDriver);
        } 
    }
}