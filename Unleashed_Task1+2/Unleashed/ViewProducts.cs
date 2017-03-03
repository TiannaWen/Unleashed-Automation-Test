using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Unleashed
{
    class ViewProducts
    {
        public ViewProducts()
        {
            PageFactory.InitElements(DriverCmn.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='shortcuts']/div[1]/i")]
        public IWebElement Shortcuts { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='shortcuts']/div[2]/div[4]/a/div[2]")]
        public IWebElement VPShortcut { set; get; }

        [FindsBy(How = How.Id, Using = "ProductFilter")]
        public IWebElement ProductFilter { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ProductList_col2']/table/tbody/tr/td[1]")]
        public IWebElement Filter { set; get; }

        public void NvgViewProducts()
        {
            Shortcuts.Click();
            VPShortcut.Click();
            Thread.Sleep(3000);
        }

        public void QuantityCheck(String pname)
        {
            ProductFilter.SendKeys(pname);
            Filter.Click();
            string qty = DriverCmn.driver.FindElement(By.XPath("//*[@id='ProductList_tccell0_7']/a")).Text;
            Console.WriteLine("The available stock on hand of the " + pname +" is " + qty +".");
        }
    }
}

