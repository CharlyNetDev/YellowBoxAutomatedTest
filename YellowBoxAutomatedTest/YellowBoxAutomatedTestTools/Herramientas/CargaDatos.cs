using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using System.IO;

namespace YellowBoxAutomatedTestTools.WebDriverDatos
{
    public class CargaDatos
    {
        WebDriversComponentes.YellowBoxObjetos ObjetosPrueba = new WebDriversComponentes.YellowBoxObjetos();
      
        public List<WebDriversComponentes.YellowBoxObjetos> CargaDatosPrueba(string pathFichero)
        {
            var book = new ExcelQueryFactory(pathFichero);
            var resultado = (from row in book.Worksheet("UsuariosEscuela")
                            let item = new WebDriversComponentes.YellowBoxObjetos
                            {
                                TestCase = row["CasoPrueba"].Cast<string>(),
                                Usuario = row["Usuario"].Cast<string>(),
                                Password = row["Password"].Cast<string>(),
                                Url = row["Url"].Cast<string>(),
                                ResultadoEsperado = row["ResultadoEsperado"].Cast<string>(),
                                Navegador = row["Browser"].Cast<string>()
                            }
                            select item).ToList();

            book.Dispose();
            return resultado;
        }
    }
}
