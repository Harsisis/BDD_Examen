using MStest_Workstate1.Helpers;
using OpenQA.Selenium;
using SpecFlowProject_BDD.BasesClasses;
using System;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class CreditCardValidatorStepDefinitions
    {

        private By creditCardNumber = By.Id("creditCardNumber");
        private By expirationDate = By.Id("expirationDate");
        private By cvc = By.Id("cvc");
        private By submit = By.Id("submitCard");
        private By paymentConfirmed = By.Id("paymentConfirmed");

        [Given(@"user fills the three inputs")]
        public void GivenUserFillsTheThreeInputs()
        {
            TextBoxHelper.TypeInTextBox(creditCardNumber, "1234567890123456");
            TextBoxHelper.TypeInTextBox(expirationDate, "09/2001");
            TextBoxHelper.TypeInTextBox(cvc, "123");
        }

        [Given(@"credit card number is sixteen digits long")]
        public void GivenCreditCardNumberIsSixteenDigitsLong()
        {
            WebElement cardNumber = (WebElement)GenericHelper.GetElement(creditCardNumber);
            string str = cardNumber.GetAttribute("value");
            Assert.IsTrue(cardNumber.GetAttribute("value").Length == 16);
        }

        [Given(@"expiration date is at format MM/YYYY")]
        public void GivenExpirationDateIsAtFormatMMYYYY()
        {
            WebElement expirationDateNumber = (WebElement)GenericHelper.GetElement(expirationDate);
            string[] values = expirationDateNumber.GetAttribute("value").Split("/");
            Assert.IsTrue(values.Length == 2 && 
                values[0].Length == 2 && 
                values[1].Length == 4 && 
                int.TryParse(values[0], out _) && 
                int.TryParse(values[1], out _));
        }

        [Given(@"cvc is three digits long")]
        public void GivenCvcIsThreeDigitsLong()
        {
            WebElement cvcNumber = (WebElement)GenericHelper.GetElement(cvc);
            Assert.IsTrue(cvcNumber.GetAttribute("value").Length == 3);
        }

        [When(@"submit button is pressed")]
        public void WhenSubmitButtonIsPressed()
        {
            ButtonHelper.ClickButton(submit);
        }

        [Then(@"user is on page paymentConfirmed")]
        public void ThenUserIsOnPagePaymentConfirmed()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(paymentConfirmed));
        }

        [Given(@"credit card number is not sixteen digits long")]
        public void GivenCreditCardNumberIsNotSixteenDigitsLong()
        {
            WebElement cardNumber = (WebElement)GenericHelper.GetElement(creditCardNumber);
            TextBoxHelper.TypeInTextBox(creditCardNumber, "123456");
            Assert.IsTrue(cardNumber.GetAttribute("value").Length != 16);
        }

        [Then(@"user is on homePage")]
        public void ThenUserIsOnHomePage()
        {
            Assert.IsFalse(GenericHelper.IsElementPresentOnce(paymentConfirmed));
        }

        [Given(@"expiration date is not at format MM/YYYY")]
        public void GivenExpirationDateIsNotAtFormatMMYYYY()
        {
            WebElement expirationDateNumber = (WebElement)GenericHelper.GetElement(expirationDate);
            TextBoxHelper.TypeInTextBox(expirationDate, "123456");
            string[] values = expirationDateNumber.GetAttribute("value").Split("/");
            Assert.IsFalse(values.Length == 2 &&
                values[0].Length == 2 &&
                values[1].Length == 4 &&
                int.TryParse(values[0], out _) &&
                int.TryParse(values[1], out _));
        }

        [Given(@"cvc is not three digits long")]
        public void GivenCvcIsNotThreeDigitsLong()
        {
            WebElement cvcNumber = (WebElement)GenericHelper.GetElement(cvc);
            TextBoxHelper.TypeInTextBox(cvc, "123456");
            Assert.IsTrue(cvcNumber.GetAttribute("value").Length != 3);
        }
    }
}
