using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesadorDeTexto.Interfaces.comport_lectura
{
    class Leer_Cadena : I_Comport_lectura
    {
        public string Leer_datos(Form1 frm1, Procesador proc, string[] cadenas)
        {   //Por cada fila (cadena) manda a llamar los demás comportamientos para alterar el texto
            string texto = "";
            foreach (string cadena in cadenas)
            {   //Si se encuentra un error, se devuelve la cadena sin cambios
                try {
                    if (cadena == "\r") { throw new Exception(); }
                    string buscado = proc.Buscar_datos(frm1, cadena); //Devuelve el dato a buscar
                    string[] palabras = proc.Escribir_datos(buscado, frm1.CADENA); //Crea la cadena complemento/reemplazo
                    texto += proc.Reemplazar_datos(frm1, cadena, palabras); //Busca la cadena/posición y la cambia/reemplaza
                }
                catch { texto += cadena + "\n"; }
            }
            return texto;
        }
    }
}
