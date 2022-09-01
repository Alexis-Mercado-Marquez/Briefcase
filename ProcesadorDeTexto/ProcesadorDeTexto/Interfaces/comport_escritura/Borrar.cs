using System;

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
