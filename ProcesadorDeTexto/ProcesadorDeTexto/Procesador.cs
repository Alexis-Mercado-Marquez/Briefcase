using System;
using System.Collections.Generic;
using Busqueda = ProcesadorDeTexto.Interfaces.comport_busqueda;
using Lectura = ProcesadorDeTexto.Interfaces.comport_lectura;
using Escritura = ProcesadorDeTexto.Interfaces.comport_escritura;
using Reemplazo = ProcesadorDeTexto.Interfaces.comport_reemplazo;

namespace ProcesadorDeTexto
{
    public class Procesador
    {
        public Busqueda.I_Comport_busqueda comport_busqueda;
        public Lectura.I_Comport_lectura comport_lectura;
        public Escritura.I_Comport_escritura comport_escritura;
        public Reemplazo.I_Comport_reemplazo comport_reemplazo;

        public Procesador() { }

        public string Buscar_datos(Form1 frm1, string cadena)
        { return comport_busqueda.Buscar_datos(frm1, cadena); }

        public void Como_buscar_datos(Busqueda.I_Comport_busqueda CB)
        { comport_busqueda = CB; }

        public string Leer_datos(Form1 frm1, Procesador proc, string[] cadenas)
        { return comport_lectura.Leer_datos(frm1, proc, cadenas); }

        public void Como_leer_datos(Lectura.I_Comport_lectura CL)
        { comport_lectura = CL; }

        public string[] Escribir_datos(string texto, string complemento)
        { return comport_escritura.Escribir_datos(texto, complemento); }

        public void Como_escribir_datos(Escritura.I_Comport_escritura CE)
        { comport_escritura = CE; }

        public string Reemplazar_datos(Form1 frm1, string cadena, string[] palabras)
        { return comport_reemplazo.Reemplazar_datos(frm1, cadena, palabras); }

        public void Como_reemplazar_datos(Reemplazo.I_Comport_reemplazo CR)
        { comport_reemplazo = CR; }
    }
}
