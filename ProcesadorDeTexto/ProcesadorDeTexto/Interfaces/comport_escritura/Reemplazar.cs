using System;

namespace ProcesadorDeTexto.Interfaces.comport_escritura
{
    class Reemplazar : I_Comport_escritura
    {
        public string[] Escribir_datos(string texto, string complemento)
        {   //El complemento lo reemplaza
            return new string[] { texto, complemento };
        }
    }
}
