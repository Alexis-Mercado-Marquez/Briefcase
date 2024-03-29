﻿using System;

namespace ProcesadorDeTexto.Interfaces.comport_lectura
{
    class Leer_Contador : I_Comport_lectura
    {
        public string Leer_datos(Form1 frm1, Procesador proc, string cadena)
        {   //Manda a llamar a los demás comportamientos para alterar el texto
            int contador = frm1.CONTADOR;
            string buscado = proc.Buscar_datos(frm1, cadena); //Devuelve el texto buscado
            string[] palabras = proc.Escribir_datos(buscado, contador.ToString()); //Crea la cadena complemento/reemplazo
            string nueva_cadena = proc.Reemplazar_datos(frm1, cadena, palabras); //Busca la cadena/posición y la cambia/reemplaza

            //Se incrementa el contador SOLO si se altero la cadena
            if (nueva_cadena != cadena + "\n") frm1.CONTADOR += frm1.INCREMENTO;

            return proc.Remover_datos(cadena, nueva_cadena); //Remueve el resto de la cadena, si así se indica
        }
    }
}
