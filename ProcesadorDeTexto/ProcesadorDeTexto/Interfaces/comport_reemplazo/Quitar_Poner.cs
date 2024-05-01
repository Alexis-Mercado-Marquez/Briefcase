using System;

namespace ProcesadorDeTexto.Interfaces.comport_reemplazo
{
    class Quitar_Poner : I_Comport_reemplazo
    {
        public string Reemplazar_datos(Form1 frm1, string cadena, string[] palabras)
        {   //Solo reemplaza una cadena por otra

            //Para poder buscar en reversa
            int n = Convert.ToInt32(frm1.OBJ_BUSCADO);
            if (frm1.ULTIMA == true) n = cadena.Length - n;

            if (n >= 0) return cadena.Remove(n - 1, 1).Insert(n - 1, palabras[1]) + "\n";
            else        return cadena + "\n";

            //Para buscar un "RANGO" de caracteres
            /*int n = Convert.ToInt32(frm1.OBJ_BUSCADO);
            //Número de caractéres a insertar/reemplazar
            int r = Convert.ToInt32(frm1.RANGO);  //Reversa pendiente

            if (n >= 0) return cadena.Remove(n - 1, r).Insert(n - 1, palabras[1]) + "\n";
            else        return cadena + "\n";*/
        }
    }
}
