using NewAutomationTestin.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace NewAutomationTestin.StepDefinitions
{
    [Binding]
    public class RegistrationDataStepDefinitions
    {
        RegistrationDataPage registrationDataPage;

        public RegistrationDataStepDefinitions() 
        { 
        
        registrationDataPage = new RegistrationDataPage();  
        
        
        }
        
        
        
        
        
        
        
         [Given(@"I Navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            registrationDataPage.NavigateToWebsite(url);
        }

        [Given(@"I Click on Sign Up")]
        public void GivenIClickOnSignUp()
        {
            registrationDataPage.ClickonSignUp();
        }

        [Given(@"I enter my Username ""([^""]*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            registrationDataPage.EnterUsername(username); 
        }

        [Given(@"I enter my Email ""([^""]*)""")]
        public void GivenIEnterMyEmail(string email)
        {
            registrationDataPage.EnterEmail(email);
        }

        [Given(@"I enter my Password ""([^""]*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            registrationDataPage.EnterPassword(password);
        }

        [When(@"I Click on the Sign up Button")]
        public void WhenIClickOnTheSignUpButton()
        {
            registrationDataPage.ClickonSignupButton();
        }

        [Then(@"I should be to register successfully")]
        public void ThenIShouldBeToRegisterSuccessfully()
        {
           Thread.Sleep(5000);
            Assert.That(registrationDataPage.IsNewArticleDisplayed);
        
        }
    }
}
