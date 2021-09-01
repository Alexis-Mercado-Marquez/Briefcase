using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesadorDeTexto.Interfaces.comport_busqueda
{
    class Buscar_número : I_Comport_busqueda
    {
        public string Buscar_datos(Form1 frm1, string cadena)
        {
            int num = Convert.ToInt32(frm1.OBJ_BUSCADO);
            return cadena.Substring(num - 1,1);
        }
    }
}
