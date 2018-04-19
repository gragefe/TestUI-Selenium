using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsUI.Configuration;
using TestsUI.Pages;
using DAL;
using DAL.Entidades;
using System.Threading;

namespace TestsUI.TestCases
{
    [TestFixture]
    public class VerificarErrosConsole : BaseUITest
    {

        private DAL.ContextDB.ContextDb db = new DAL.ContextDB.ContextDb();

        [Test]
        public void VerificarErros()
        {
            //Inicia o teste na pagina do google
            GooglePage gPage = new GooglePage();

            gPage.NavigateToMainPage();

            //Urls que vão ser testadas
            List<string> ListaDeUrls = new UrlsParaTeste().ListaDeUrls();

            foreach (var item in ListaDeUrls)
            {
                ConsoleBrowser objConsole = new ConsoleBrowser();

                Driver.Navigate().GoToUrl(item);

                var consoleLog = Driver.Manage().Logs.GetLog(LogType.Browser);

                objConsole.Url = item;

                objConsole.DetalhesLog = new List<DetalhesLog>();

                foreach (var log in consoleLog)
                {
                    DetalhesLog objDetalhesLog = new DetalhesLog();

                    objDetalhesLog.Tipo = log.Level.ToString();
                    objDetalhesLog.Mensagem = log.Message;
                    objDetalhesLog.Data = log.Timestamp;

                    objConsole.DetalhesLog.Add(objDetalhesLog);
                }

                db.ConsoleBrowser.Add(objConsole);
                db.SaveChanges();
            }

          
        }
    }
}



