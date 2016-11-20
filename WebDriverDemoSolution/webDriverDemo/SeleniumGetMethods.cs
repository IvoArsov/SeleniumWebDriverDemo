﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace webDriverDemo
{
    class SeleniumGetMethods
    {
        public static string GetText( string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            if (elementType == PropertyType.Name)
            {
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            }
            else
            {
                return String.Empty;    
            }
        }

        public static string GetTextFromDDL(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            if (elementType == PropertyType.Name)
            {
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else
            {
                return String.Empty;
            }
        }
    }
}
