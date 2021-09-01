using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesadorDeTexto.Interfaces.comport_reemplazo
{
    public interface I_Comport_reemplazo
    {
        string Reemplazar_datos(Form1 frm1, string cadena, string[] palabras);
    }
}
