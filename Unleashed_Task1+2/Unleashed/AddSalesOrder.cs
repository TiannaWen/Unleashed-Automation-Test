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
    class AddSalesOrder
    {
        public AddSalesOrder()
        {
            PageFactory.InitElements(DriverCmn.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='shortcuts']/div[1]/i")]
        public IWebElement Shortcuts { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='shortcuts']/div[2]/div[7]/a")]
        public IWebElement AOShortcut { set; get; }

        //Customer Search elements
        [FindsBy(How = How.Id, Using = "CustomerSearchButton")]
        public IWebElement SearchCustomer { set; get; }

        [FindsBy(How = How.Id, Using = "CustomerSearchCode")]
        public IWebElement SearchCode { set; get; }

        [FindsBy(How = How.Id, Using = "CustomerSearchName")]
        public IWebElement SearchName { set; get; }

        [FindsBy(How = How.Id, Using = "RunCustomerSearch")]
        public IWebElement RunSearch { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='CustomerLocalSearch_tccell0_0']/a")]
        public IWebElement SelectCustomer { set; get; }

        //Product Search elements
        [FindsBy(How = How.Id, Using = "ProductSearchButton")]
        public IWebElement SearchProduct { set; get; }

        [FindsBy(How = How.Id, Using = "LocalProductSearch")]
        public IWebElement SearchPName { set; get; }

        [FindsBy(How = How.Id, Using = "RunProductLocalSearch")]
        public IWebElement RunPSearch { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ProductLocalSearch_tccell0_0']/a")]
        public IWebElement SelectProduct { set; get; }


        [FindsBy(How = How.Id, Using = "QtyAddLine")]
        public IWebElement AddQty { set; get; }

        [FindsBy(How = How.Id, Using = "btnAddOrderLine")]
        public IWebElement AddBtn { set; get; }

        [FindsBy(How = How.Id, Using = "btnComplete")]
        public IWebElement CompleteBtn { set; get; }

        public void NvgAddOrder()
        {
            Shortcuts.Click();
            AOShortcut.Click();
        }

        public void AddOrder(String ccode, String cname, String pname, String qty)
        {
            //Select Customer
            SearchCustomer.Click();
            Thread.Sleep(3000);
            SearchCode.SendKeys(ccode);
            SearchName.SendKeys(cname);
            RunSearch.Click();
            Thread.Sleep(3000);
            SelectCustomer.Click();
            Thread.Sleep(5000);

            //Select Product
            SearchProduct.Click();
            Thread.Sleep(3000);
            SearchPName.SendKeys(pname);
            RunPSearch.Click();
            Thread.Sleep(3000);
            SelectProduct.Click();
            Thread.Sleep(3000);

            //Finish the follow flow
            AddQty.SendKeys(qty);
            AddBtn.Click();
            Thread.Sleep(3000);
            CompleteBtn.Click();
        }
    }
}
