﻿using System;

namespace ProcesadorDeTexto.Interfaces.comport_busqueda
{
    class Buscar_cadena : I_Comport_busqueda
    {
        public string Buscar_datos(Form1 frm1, string cadena)
        {
            return frm1.OBJ_BUSCADO;
        }
    }
}
