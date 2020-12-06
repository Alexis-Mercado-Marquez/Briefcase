using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;
using E2_Transporte.Properties;

namespace E2_Transporte
{
    class BDComun
    {
        public static string ObtenerString()
        {   //Los datos de la conexión
            return Settings.Default.E2_ConnectionString;
        }

        public static MySqlConnection ObtenerCon()
        {
            MySqlConnection conec = new MySqlConnection(ObtenerString());
            conec.Open(); //Se abre la conexión 
            return conec;
        }
    }
}
