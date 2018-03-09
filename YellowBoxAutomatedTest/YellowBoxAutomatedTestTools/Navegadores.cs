using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;

namespace YellowBoxAutomatedTestTools.WebDriversComponentes
{
    public class Navegadores
    { 
        public IWebDriver LanzarNavegador (string tipoNavegador)
        {
            IWebDriver driver = null;

            if (tipoNavegador == "Chrome")
            {
                ChromeOptions opciones = new ChromeOptions();

                opciones.AddArguments("-incognito");
                opciones.AddArguments("--disble-infobars");
                opciones.AddArguments("--disable-popup-bloking");
                opciones.AddArguments("-start-maximized");
            }
            return driver;
        }
    }
}
