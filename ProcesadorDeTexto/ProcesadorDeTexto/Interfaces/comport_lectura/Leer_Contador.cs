using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesadorDeTexto.Interfaces.comport_lectura
{
    class Leer_Contador : I_Comport_lectura
    {
        public string Leer_datos(Form1 frm1, Procesador proc, string[] cadenas)
        {   //Por cada fila (cadena) manda a llamar los demás comportamientos para alterar el texto
            string texto = "";
            foreach (string cadena in cadenas)
            {   //Si se encuentra un error, se devuelve la cadena sin cambios
                try { 
                    if (cadena == "\r") { throw new Exception(); }
                    int contador = frm1.CONTADOR;
                    string buscado = proc.Buscar_datos(frm1, cadena); //Devuelve el dato a buscar
                    string[] palabras = proc.Escribir_datos(buscado, contador.ToString()); //Crea la cadena complemento/reemplazo
                    string nueva_cadena = proc.Reemplazar_datos(frm1, cadena, palabras); //Busca la cadena/posición y la cambia/reemplaza
                    if (nueva_cadena != cadena + "\n") //Se incrementa el contador SOLO si se altero la cadena
                        frm1.CONTADOR += frm1.INCREMENTO;
                    texto += nueva_cadena;
                }
                catch { texto += cadena + "\n"; }
            }
            return texto;
        }
    }
}
