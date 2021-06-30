using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Selenium
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Clickar em uns botões

        public static void Click(IWebElement element)
        {
            element.Click();
        }

        //Selecionar um dropdown
        public static void SelectDropdown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
