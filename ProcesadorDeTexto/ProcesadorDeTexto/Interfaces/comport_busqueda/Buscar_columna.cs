using System;

namespace ProcesadorDeTexto.Interfaces.comport_busqueda
{
    class Buscar_columna : I_Comport_busqueda
    {
        public string Buscar_datos(Form1 frm1, string cadena)
        {
            //Para poder buscar en reversa
            int num = Convert.ToInt32(frm1.OBJ_BUSCADO);
            cadena = frm1.ULTIMA 
                ? cadena.Substring(cadena.Length - num - 1, 1)
                : cadena.Substring(num - 1, 1);
            return cadena;

            //Para buscar un "RANGO" de carácteres
            /*int num = Convert.ToInt32(frm1.OBJ_BUSCADO);
            int rango = Convert.ToInt32(frm1.RANGO);
            cadena = cadena.Substring(num - 1, rango);
            return cadena;*/
        }
    }
}
