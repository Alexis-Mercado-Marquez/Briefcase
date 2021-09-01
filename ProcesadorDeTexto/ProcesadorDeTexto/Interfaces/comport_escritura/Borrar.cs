using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesadorDeTexto.Interfaces.comport_escritura
{
    class Borrar : I_Comport_escritura
    {
        public string[] Escribir_datos(string texto, string complemento)
        {   //No se usa el complemento
            return new string[] { texto, "" };
        }
    }
}
