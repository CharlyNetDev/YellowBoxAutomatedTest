using OpenQA.Selenium.Chrome;
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
                opciones.AddArguments("--disable-infobars");
                opciones.AddArguments("--disable-popup-bloking");
                opciones.AddArguments("-start-maximized");

                driver = new ChromeDriver(opciones);
            }
            return driver;
        }
    }
}
