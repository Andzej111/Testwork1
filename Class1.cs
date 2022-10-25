using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    class firsthomework
    {

        [TestCase("2", "2", "4", TestName = "Testas 2 plius 2")]
        public static void TestSum(string firstInputValue, string secondInputValue, string resultValue)
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://demo.seleniumeasy.com/basic-first-form-demo.html";
            chromeDriver.Manage().Window.Maximize();

            IWebElement inputFieldA = chromeDriver.FindElement(By.Id("sum1"));
            inputFieldA.SendKeys(firstInputValue);
            IWebElement inputFieldB = chromeDriver.FindElement(By.Id("sum2"));
            inputFieldB.SendKeys(secondInputValue);
            chromeDriver.FindElement(By.CssSelector("#gettotal>button")).Click();
            IWebElement element = chromeDriver.FindElement(By.CssSelector("#displayvalue"));
            Assert.IsTrue(resultValue.Equals(element.Text), "Result is not correct");
            chromeDriver.Quit();
        }
