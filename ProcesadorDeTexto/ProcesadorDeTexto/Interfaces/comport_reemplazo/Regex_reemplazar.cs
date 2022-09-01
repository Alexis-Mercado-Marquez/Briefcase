using System;
using System.Text.RegularExpressions;

namespace ProcesadorDeTexto.Interfaces.comport_reemplazo
{
    class Regex_reemplazar : I_Comport_reemplazo
    {
        public string Reemplazar_datos(Form1 frm1, string cadena, string[] palabras)
        {   //Usa un Regex para buscar una cadena que no colinde con letras o números
            var patron = frm1.DISTINGUIR
                ? @"(?<first>\b|\W)(" + palabras[0] + @")(?<second>\W)" 
                : @"(?i)(?<first>\b|\W)(" + palabras[0] + @")(?<second>\W)";
            var match = Regex.Match(cadena, patron);
            if (!match.Success) { throw new Exception(); }
            return Regex.Replace(cadena, patron, "${first}" + palabras[1] + "${second}") + "\n";
        }
    }
}
