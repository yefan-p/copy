using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CopyPost
{
    class Browser
    {
        public IWebDriver BrowserMan;
        private string ChromeUserDataPath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Google\Chrome\User Data";

        public void Open()
        {
            ChromeOptions OptionsBrowser = new ChromeOptions();
            OptionsBrowser.AddArgument(@"user-data-dir=" + ChromeUserDataPath);
            //OptionsBrowser.PageLoadStrategy = PageLoadStrategy.None;

            BrowserMan = new ChromeDriver(OptionsBrowser);
        }

        public void Close()
        {
            BrowserMan.Quit();
        }

        public bool isElementExists(By locator)
        {
            IList<IWebElement> elements = this.BrowserMan.FindElements(locator);
            if (elements.Count() > 0)
                return true;
            else
                return false;
        }
    }
}
