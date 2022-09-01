using System;

namespace ProcesadorDeTexto.Interfaces.comport_remocion
{
    class Remover_antes : I_Comport_remocion
    {
        public string Remover_datos(string v, string n)
        {
            if (string.IsNullOrEmpty(v) || string.IsNullOrEmpty(n)) { return ""; }

            string m_largo = n.Length > v.Length ? n : v;
            string m_corto = n.Length > v.Length ? v : n;

            for (int i = 0; i < m_corto.Length; i++) 
                if (m_corto[i] != m_largo[i])
                    return n.Substring(i);

            return n; //Por defecto retorna la nueva cadena
        }
    }
}
