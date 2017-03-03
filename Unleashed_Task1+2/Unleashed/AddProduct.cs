using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Unleashed
{
    class AddProduct
    {
        public AddProduct()
        {
            PageFactory.InitElements(DriverCmn.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='shortcuts']/div[1]/i")]
        public IWebElement Shortcuts { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='shortcuts']/div[2]/div[3]/a/div[2]")]
        public IWebElement APShortcut { set; get; }

        [FindsBy(How = How.Id, Using = "Product_ProductCode")]
        public IWebElement ProductCode { set; get; }

        [FindsBy(How = How.Id, Using = "Product_ProductDescription")]
        public IWebElement ProductDes { set; get; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement SaveBtn { set; get; }

        public void NvgAddProduct()
        {
            Thread.Sleep(1000);
            Shortcuts.Click();
            APShortcut.Click();
        }

        public void AddNewProduct(String pcode, String pdes, int pgroup)
        {
            ProductCode.SendKeys(pcode);

            ProductDes.SendKeys(pdes);
            
            for(int i = 2; i<5; i++)
            {
                string ProductGroup = "//*[@id='Product_ProductGroupId']/option["+i+"]";
                if (i == pgroup)
                {
                    DriverCmn.driver.FindElement(By.XPath(ProductGroup)).Click();
                }
            }

            SaveBtn.Click();
        }
    }
}
