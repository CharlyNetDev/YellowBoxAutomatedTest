using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YellowBoxAutomatedTest
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestCase
    {

        YellowBoxAutomatedTestTools.Procesos.ProcesoLogIn logIn = new YellowBoxAutomatedTestTools.Procesos.ProcesoLogIn();

        [TestMethod]
        public void LogInYellowBoxExitoso()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\YellowBoxAutomatedTest\\YellowBoxAutomatedTest\\YellowBoxAutomatedTestTools\\Herramientas\\DatosPrueba.xlsx");
            logIn.AccesoExitoso(pathArchivo);
            
        }

    }
}
