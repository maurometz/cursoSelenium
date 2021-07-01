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
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = SeleniumExtras.PageObjects.How.Name, Using = "UserName")]
        public IWebElement txtUserName  { get; set; }

        [FindsBy(How = SeleniumExtras.PageObjects.How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@id=\"userName\"]/p[3]/input")]
        public IWebElement btnLogin { get; set; }
        //[FindsBy(How = SeleniumExtras.PageObjects.How.Name, Using = "Login")]
        //public IWebElement btnLogin { get; set; }

        public EAPageObject Login(string userName, string password)
        {
            //Login
            txtUserName.EnterText(userName);
            //senha
            txtPassword.EnterText(password);
            //Clicar no botão
            btnLogin.Clicks();
            //Return the page object
            return new EAPageObject();
        }

    }
}
