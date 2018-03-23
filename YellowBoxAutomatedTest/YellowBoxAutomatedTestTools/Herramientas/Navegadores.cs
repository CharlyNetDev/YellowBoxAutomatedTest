using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace YellowBoxAutomatedTestTools.WebDriversComponentes
{
    public class Navegadores
    {
        public IWebDriver LanzarNavegador(YellowBoxObjetos objetosPrueba)
        {
            IWebDriver driver = null;

            if (objetosPrueba.Navegador.Equals("Chrome"))
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
