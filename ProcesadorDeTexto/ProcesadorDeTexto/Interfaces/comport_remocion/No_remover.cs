using System;

namespace ProcesadorDeTexto.Interfaces.comport_remocion
{
    class No_remover : I_Comport_remocion
    {
        public string Remover_datos(string v, string n)
        {
            return n; //Solo devuelve la nueva cadena
        }
    }
}
