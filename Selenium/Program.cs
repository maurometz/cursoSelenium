using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class Program
    {

        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            //Navegar para a página do Google
            PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            Console.WriteLine("Abriu URL");
        }

        [Test]
        public void ExecuteTest()
        {

            //ExcelLib.PopulateInCollection(@"C:\Data.xlsx");

            //Login na aplication
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("sadasd","UserName");


            pageEA.FillUserForm("sd", "d", "das");


           /* //Título
            SeleniumSetMethods.SelectDropdown("TitleId", "Mr.", PropertyType.Id);

            //Inicial
            SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));


            //Clicar
            SeleniumSetMethods.Click("Save", PropertyType.Name);
           */
        }
        [TearDown]
        public void CleanUp()
        {
            //Fechar o navegador
            //PropertiesCollection.driver.Close();

            Console.WriteLine("Fechou o navegador");

        }
    }
}
