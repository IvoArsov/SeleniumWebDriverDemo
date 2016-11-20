using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace webDriverDemo
{
    class SeleniumSetMethods 
    {

        //Enter text
        public static void EnterText(string element , string value , PropertyType elementType )
        {
            if (elementType == PropertyType.Id)
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementType == PropertyType.Name)
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }

        //Click into a btn, checkbox, option ect.
        public static void Click(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == PropertyType.Name)
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            }
        }

        //Selecting a DropDown control
        public static void SelectDropDown(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementType == PropertyType.Name)
            {
                //FindElement returns IWebElement!!!
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }        
    }
}
