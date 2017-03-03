using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Unleashed
{
    [Binding]
    public class LoginToUnleashedAndCreateANewProduct
    {
        [Given(@"I have logged in to Unleashed")]
        public void GivenIHaveLoggedInToUnleashed()
        {
            DriverCmn.driver = new ChromeDriver();
            DriverCmn.driver.Navigate().GoToUrl("https://go.unleashedsoftware.com/v2");
            DriverCmn.driver.Manage().Window.Maximize();

            string eml = "qa+applicant@unleashedsoftware.com";
            string pwd = "P@ssw0rd12345";

            Login LoginObj = new Login();
            LoginObj.LoginPg(eml, pwd);
        }
        
        [Given(@"I navigate to Add Product page")]
        public void GivenINavigateToAddProductPage()
        {
            AddProduct APObj = new AddProduct();
            APObj.NvgAddProduct();
        }
        
        [Then(@"I create a new product")]
        public void ThenICreateANewProduct()
        {
            string pcode = "FRIDGE2";
            string pdes = "White Fridge";
            //Product group, 2 = Consumable, 3 = Furniture, 4 = Material
            int pgroup = 3;

            AddProduct APObj = new AddProduct();
            APObj.AddNewProduct(pcode, pdes, pgroup);
        }
    }
}
