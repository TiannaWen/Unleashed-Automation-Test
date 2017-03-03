using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unleashed
{
    public class Login
    {
        public Login()
        {
            PageFactory.InitElements(DriverCmn.driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement uname { set; get; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement pword { set; get; }

        [FindsBy(How = How.Id, Using = "btnLogOn")]
        public IWebElement logonbtn { set; get; }

        public void LoginPg(String eml, String pwd)
        {
            uname.SendKeys(eml);
            pword.SendKeys(pwd);
            logonbtn.Click();
        }
    }
}
