using NewAutomationTestin.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAutomationTestin.PageObject
{
    class RegistrationDataPage
    {
        public RegistrationDataPage() 
        {
            driver = Hooks1.driver;

           
         }   
        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement Email => driver.FindElement(By.CssSelector("input[type='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement SignupButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));
        public void ClickonSignUp() 
        { 
        SignUp.Click();
        }

        public void EnterUsername(string username) 
        { 
        Username.SendKeys(username);
        }
       
        public void EnterEmail(string email) 
        { 
        Email.SendKeys(email);  
        
        }

        public void EnterPassword(string password) 
        { 
        Password.SendKeys(password);
        }

        public void ClickonSignupButton() 
        { 
        SignupButton.Click();
        }
        
        public bool IsNewArticleDisplayed() 
        { 
        return  NewArticle.Displayed;
        }

        public void NavigateToWebsite(string url) 
        { 
        driver.Navigate().GoToUrl(url); 
        
        }



























    }

}
