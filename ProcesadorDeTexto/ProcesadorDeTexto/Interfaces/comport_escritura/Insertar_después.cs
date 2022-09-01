using System;

namespace ProcesadorDeTexto.Interfaces.comport_escritura
{
    class Insertar_después : I_Comport_escritura
    {
        public string[] Escribir_datos(string texto, string complemento)
        {   //El complemento va después
            return new string[] { texto, texto.Replace(@"\", "") + complemento };
        }
    }
}
