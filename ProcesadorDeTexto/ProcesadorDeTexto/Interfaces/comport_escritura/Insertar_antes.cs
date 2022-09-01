using System;

namespace ProcesadorDeTexto.Interfaces.comport_escritura
{
    class Insertar_antes : I_Comport_escritura
    {
        public string[] Escribir_datos(string texto, string complemento)
        {   //El complemento va antes
            return new string[] { texto, complemento + texto.Replace(@"\","") };
        }
    }
}
