using System;

namespace ProcesadorDeTexto.Interfaces.comport_escritura
{
    public interface I_Comport_escritura
    {
        string[] Escribir_datos(string texto, string complemento);
    }
}
