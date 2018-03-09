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
        private ExcelQueryFactory _excel;

        public void ManipularExcel (string nombreArchivo)
        {
            _excel = new ExcelQueryFactory(nombreArchivo)
            {
                ReadOnly = true,
                UsePersistentConnection = true
            };
        }

        public IEnumerable<WebDriversComponentes.YellowBoxObjetos> CargaDatosPrueba()
        {
            List<WebDriversComponentes.YellowBoxObjetos> ListaDatosPrueba = null;




            return ListaDatosPrueba;
        }
    }
}
