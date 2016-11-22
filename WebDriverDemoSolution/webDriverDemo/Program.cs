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

            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            PropertiesCollection.driver.Manage().Window.Maximize();
            
        }
        [Test]
        public void FirstDemoTest()
        {

            //Login to application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("Ivo", "ivo");
            
            pageEA.FillUserForm("ivo", "test", "theTest");
            
        }

        [Test]
        public void SecondDemoTest()
        {
            //Login to application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("x", "y");

            pageEA.FillUserForm("x", "xy", "theTestZ");
        }
        
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }
    }
    
}
