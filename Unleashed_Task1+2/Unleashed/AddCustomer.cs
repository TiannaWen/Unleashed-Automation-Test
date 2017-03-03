using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unleashed
{
    class AddCustomer
    {
        public AddCustomer()
        {
            PageFactory.InitElements(DriverCmn.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='shortcuts']/div[1]/i")]
        public IWebElement Shortcuts { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='shortcuts']/div[2]/div[9]/a")]
        public IWebElement ACShortcut { set; get; }

        [FindsBy(How = How.Id, Using = "Customer_CustomerCode")]
        public IWebElement CustomerCode { set; get; }

        [FindsBy(How = How.Id, Using = "Customer_CustomerName")]
        public IWebElement CustomerName { set; get; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement SaveBtn { set; get; }

        public void NvgAddCustomer()
        {
            Shortcuts.Click();
            ACShortcut.Click();
        }

        public void AddNewCustomer(String ccode, String cname)
        {
            CustomerCode.SendKeys(ccode);
            CustomerName.SendKeys(cname);
            SaveBtn.Click();
        }
    }
}
