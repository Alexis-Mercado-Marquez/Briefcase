using System;

namespace ProcesadorDeTexto.Interfaces.comport_reemplazo
{
    class Quitar_Poner : I_Comport_reemplazo
    {
        public string Reemplazar_datos(Form1 frm1, string cadena, string[] palabras)
        {   //Solo reemplaza una cadena por otra
            int n = Convert.ToInt32(frm1.OBJ_BUSCADO);
            return cadena.Remove(n - 1, 1).Insert(n - 1, palabras[1]) + "\n";
        }
    }
}
