using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;

namespace Selenium
{
    class EAPageObject
    {

        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "TitleId")]
        public IWebElement ddlTitleId { get; set; }

        [FindsBy(How = SeleniumExtras.PageObjects.How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = SeleniumExtras.PageObjects.How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = SeleniumExtras.PageObjects.How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = SeleniumExtras.PageObjects.How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string middleName, string firstName)
        {
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            btnSave.Clicks();
        }
    }
}