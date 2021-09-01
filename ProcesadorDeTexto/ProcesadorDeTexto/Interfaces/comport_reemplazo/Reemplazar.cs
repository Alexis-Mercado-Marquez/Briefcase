using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProcesadorDeTexto.Interfaces.comport_reemplazo
{
    class Reemplazar : I_Comport_reemplazo
    {
        public string Reemplazar_datos(Form1 frm1, string cadena, string[] palabras)
        {   //Usa un Regex para buscar la cadena {con (?i) distingue mayúsculas de minúsculas}
            var patron = frm1.DISTINGUIR ? palabras[0] : @"(?i)" + palabras[0];
            var match = Regex.Match(cadena, patron);
            if (!match.Success) { throw new Exception(); }
            return Regex.Replace(cadena, patron, palabras[1]) + "\n";
        }
    }
}
