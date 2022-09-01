using System;

namespace ProcesadorDeTexto.Interfaces.comport_lectura
{
    public interface I_Comport_lectura
    {
        string Leer_datos(Form1 frm1, Procesador proc, string cadena);
    }
}
