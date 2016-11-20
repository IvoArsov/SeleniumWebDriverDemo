using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace webDriverDemo
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

            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");

            PropertiesCollection.driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts();
            Console.WriteLine("Init");
        }
        [Test]
        public void ExecuteTests()
        {

            //Init this page by calling its reference
            EAPageObject page = new EAPageObject();
            page.txtInitial.SendKeys("Ivo");
            page.btnSave.Click();

            //TODO: "Page Navigation in Selenium C#"


            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            ////Initial
            //SeleniumSetMethods.EnterText("Initial", "Ivo", PropertyType.Id);

            //Console.WriteLine("The value of Title is: "
            //    + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

            //Console.WriteLine("The value of Initial is: "
            //    + SeleniumGetMethods.GetText("Initial", PropertyType.Id));

            ////Click Save button
            //SeleniumSetMethods.Click("Save", PropertyType.Name);

            //Console.WriteLine("Test is done.");


        }



        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("tearDown");
        }
    }
    
}
