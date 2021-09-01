using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesadorDeTexto.Interfaces.comport_escritura
{
    public interface I_Comport_escritura
    {
        string[] Escribir_datos(string texto, string complemento);
    }
}
