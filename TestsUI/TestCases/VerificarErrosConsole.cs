using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsUI.Configuration;
using TestsUI.Pages;


namespace TestsUI.TestCases
{
    [TestFixture]
    public class VerificarErrosConsole : BaseUITest
    {
        [Test]
        public void VerificarErros()
        {
            
            GooglePage gPage = new GooglePage();

            gPage.NavigateToMainPage();

            Driver.Navigate().GoToUrl("https://buscando.extra.com.br");


            var teste = "";


        }
    }
}
