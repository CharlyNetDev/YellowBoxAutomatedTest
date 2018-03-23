using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.

namespace YellowBoxAutomatedTestTools.Procesos
{
    public class ProcesoLogIn
    {
        YellowBoxAutomatedTestTools.WebDriversComponentes.Navegadores navegadorTest = new YellowBoxAutomatedTestTools.WebDriversComponentes.Navegadores();
        YellowBoxAutomatedTestTools.WebDriversComponentes.YellowBoxObjetos objetosPrueba = new YellowBoxAutomatedTestTools.WebDriversComponentes.YellowBoxObjetos();
        YellowBoxAutomatedTestTools.WebDriverDatos.CargaDatos datoPrueba = new YellowBoxAutomatedTestTools.WebDriverDatos.CargaDatos();
        YellowBoxAutomatedTestTools.WebDriverElementos.LogInElements elemtosLogin = new YellowBoxAutomatedTestTools.WebDriverElementos.LogInElements();
        public void AccesoExitoso (string pathArchivo)
        {
            IWebDriver driver = null;
            var listaDatosPrueba = datoPrueba.CargaDatosPrueba(pathArchivo);
            driver = navegadorTest.LanzarNavegador(listaDatosPrueba[0]);
            driver.Navigate().GoToUrl(listaDatosPrueba[0].Url);
            elemtosLogin.UserNameElement(driver).SendKeys(listaDatosPrueba[0].Usuario);
            elemtosLogin.UserPassword(driver).SendKeys(listaDatosPrueba[0].Password);
            elemtosLogin.UserPassword(driver).Submit();
            


            Thread.Sleep(10000);
        }
    }
}
