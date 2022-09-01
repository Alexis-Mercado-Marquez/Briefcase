using System;

namespace ProcesadorDeTexto.Interfaces.comport_remocion
{
    class Remover_despues : I_Comport_remocion
    {
        public string Remover_datos(string v, string n)
        {
            if (string.IsNullOrEmpty(v) || string.IsNullOrEmpty(n)) { return ""; }
            n = n.Replace("\n", ""); //Siempre acaba en un salto de línea

            string m_largo = n.Length > v.Length ? n : v;
            string m_corto = n.Length > v.Length ? v : n;
            int dif = m_largo.Length - m_corto.Length;

            for (int i = m_corto.Length - 1; i >= 0; i--)
                if (m_corto[i] != m_largo[i + dif])
                {
                    if (n.Length > v.Length)
                        return n.Substring(0, i + 1 + dif) + "\r\n";
                    else //Si es mas corto
                        return n.Substring(0, i + 1) + "\r\n";
                }

            return n; //Por defecto retorna la nueva cadena
        }
    }
}
