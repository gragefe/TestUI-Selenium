using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsUI.Helpers
{
    /// <summary>
    /// Wrapper class for getter methods.
    /// </summary>
    public static class GetterHelpers
    {
        public static string GetText(this IWebElement element)
        {
            return element.Text;
        }

        public static string GetValue(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDDL(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}