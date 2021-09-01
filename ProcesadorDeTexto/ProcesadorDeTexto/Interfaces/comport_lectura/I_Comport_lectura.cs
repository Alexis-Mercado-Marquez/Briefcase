using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesadorDeTexto.Interfaces.comport_lectura
{
    public interface I_Comport_lectura
    {
        string Leer_datos(Form1 frm1, Procesador proc, string[] cadenas);
    }
}
