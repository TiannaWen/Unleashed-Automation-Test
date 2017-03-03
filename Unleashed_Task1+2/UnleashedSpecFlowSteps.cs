using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Unleashed;

namespace UnleashedSpecFlow
{
    [Binding]
    public class UnleashedSpecFlowSteps
    {
        [Given(@"I have entered Unleashed login page")]
        public void GivenIHaveEnteredUnleashedLoginPage()
        {
            DriverCmn.driver = new ChromeDriver();
            DriverCmn.driver.Navigate().GoToUrl("https://go.unleashedsoftware.com/v2");
        }
        
        [Given(@"I have entered email and password")]
        public void GivenIHaveEnteredEmailAndPassword()
        {
            DriverCmn.driver = new ChromeDriver();
            DriverCmn.driver.Navigate().GoToUrl("https://go.unleashedsoftware.com/v2");
            //Email
            string eml = "qa+applicant@unleashedsoftware.com";
            //Password
            string pwd = "P@ssw0rd12345";

            Login LoginObj = new Login();
            LoginObj.LoginPg(eml, pwd);
        }
        
        [When(@"I press Log On")]
        public void WhenIPressLogOn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it navigates to the Dashboard page")]
        public void ThenItNavigatesToTheDashboardPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
