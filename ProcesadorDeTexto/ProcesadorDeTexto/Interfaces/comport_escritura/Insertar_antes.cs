using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesadorDeTexto.Interfaces.comport_escritura
{
    class Insertar_antes : I_Comport_escritura
    {
        public string[] Escribir_datos(string texto, string complemento)
        {   //El complemento va antes
            return new string[] { texto, complemento + texto };
        }
    }
}
