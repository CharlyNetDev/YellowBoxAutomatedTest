using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;

namespace YellowBoxAutomatedTestTools.WebDriverComponents
{
    class CargaDeDatos
    {
        public List<WebDriverComponents.YellowBoxObjetos> DatosLoguin ()
        {
            var path = "C:\\Users\\carlo\\Source\\Repos\\YellowBox\\YellowBoxAutomatedTest\\YellowBoxAutomatedTestTools\\DatosPrueba.xlsx";
            var book = new ExcelQueryFactory(path);
            var resultado = (from row in book.Worksheet("Hoja1")
                             let item = new WebDriverComponents.YellowBoxObjetos
                             {
                                 Usuario = row[0].Cast<string>(),
                                 Contrasenia = row[1].Cast<string>()
                             }
                             select item).ToList();
            book.Dispose();
            return resultado;            
        }
    }
}
