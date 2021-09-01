using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Busqueda = ProcesadorDeTexto.Interfaces.comport_busqueda;
using Lectura = ProcesadorDeTexto.Interfaces.comport_lectura;
using Escritura = ProcesadorDeTexto.Interfaces.comport_escritura;
using Reemplazo = ProcesadorDeTexto.Interfaces.comport_reemplazo;

namespace ProcesadorDeTexto
{
    public partial class Form1 : Form
    {
        public string ACCION = "";
        public string CADENA = ""; //Toma el valor de B_TB_Cadena
        public int CONTADOR; //Toma el valor de B_NDD_Inicio
        public int INCREMENTO; //Toma el valor de B_NDD_Increm
        public string OBJ_BUSCADO; //Toma el valor de los controles A
        public bool DISTINGUIR; //Toma el valor de A_CB_Mayus

        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            A_CB_Cadenas.SelectedIndex = 0;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {   //Expliación
            if (tab_reemplazable.SelectedTab == tabPage1)
                MessageBox.Show("Red");
            else if (tab_reemplazable.SelectedTab == tabPage2)
                MessageBox.Show("Blue");
            else if (tab_reemplazable.SelectedTab == tabPage3)
                MessageBox.Show("Yellow");
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {   //Imprime una copia de la primer textBox, modificada
            Procesador proc1 = new Procesador();
            Procesador proc2 = new Procesador();
            String[] cadenas = new String[1];
            textBox2.Text = "";
            //Separa la cadena por línea
            cadenas = textBox1.Text.Split('\n');

            //Elegir el "comportamiento" al leer los datos del bloque B
            if (tab_reemplazo.SelectedTab == tabPage4)
            {   //El procesador tomará el texto de B_TB_Cadena
                CADENA = B_TB_Cadena.Text;
                proc1.Como_leer_datos(new Lectura.Leer_Cadena());
            }
            else if (tab_reemplazo.SelectedTab == tabPage5)
            {   //El procesador tomará el texto de B_NDD_Inicio
                CONTADOR = Convert.ToInt32(B_NDD_Inicio.Value);
                INCREMENTO = Convert.ToInt32(B_NDD_Increm.Value);
                proc1.Como_leer_datos(new Lectura.Leer_Contador());
            }

            //Elegir el "comportamiento" de escritura según los radio buttons
            if (rdInsertBefore.Checked == true)
                proc2.Como_escribir_datos(new Escritura.Insertar_antes());
            else if (rdInsertAfter.Checked == true)
                proc2.Como_escribir_datos(new Escritura.Insertar_después());
            else if (rdReplace.Checked == true)
                proc2.Como_escribir_datos(new Escritura.Reemplazar());
            else //rdBorrar
                proc2.Como_escribir_datos(new Escritura.Borrar());

            //Elegir el "comportamiento" (método a llamar) y el "comportamiento" de busqueda
            if (tab_reemplazable.SelectedTab == tabPage1)
            {   //Guarda el text a buscar y si debe distinguir mayusculas de minusculas
                OBJ_BUSCADO = A_TB_Cadena.Text;
                DISTINGUIR = A_CB_Mayus.Checked;
                if (A_CB_Cadenas.SelectedIndex == 0)
                    proc2.Como_reemplazar_datos(new Reemplazo.Reemplazar());
                else //Palabras completas
                    proc2.Como_reemplazar_datos(new Reemplazo.Regex_reemplazar());
                //Comportamiento de busqueda
                proc2.Como_buscar_datos(new Busqueda.Buscar_cadena());
            }
            else if (tab_reemplazable.SelectedTab == tabPage2)
            {   //Se buscará el texto de la columna indicada
                OBJ_BUSCADO = A_NDD_Columna.Value.ToString();
                proc2.Como_reemplazar_datos(new Reemplazo.Quitar_Poner());
                proc2.Como_buscar_datos(new Busqueda.Buscar_número());
            }

            //Ejecuta el método con la estrategia escogida y devuelve el texto modificado
            textBox2.Text = proc1.Leer_datos(this, proc2, cadenas);

        }

        /* CÓMO BUSCAR */
        private string buscar_x_cadenas(string cadena)
        {   //Explicación
            if (rdInsertBefore.Checked == true)
            {
                if (tab_reemplazo.SelectedTab == tabPage4)
                {   //Inserta una cadena antes de la cadena buscada
                    try
                    {   //Cualquier coincidencia.
                        if (A_CB_Cadenas.SelectedIndex == 0) {
                            //return cadena.Insert(cadena.IndexOf(A_TB_Cadena.Text), B_TB_Cadena.Text) + "\n";
                            return cadena.Replace(A_TB_Cadena.Text, B_TB_Cadena.Text + A_TB_Cadena.Text) + "\n";
                        }
                        else if (A_CB_Cadenas.SelectedIndex == 1) {
                            //Concidencia con palabra completa.
                            var patron = A_CB_Mayus.Checked ? @"(?<first>\b|\W)(" + A_TB_Cadena.Text + @")(?<second>\W)"
                                : @"(?i)(?<first>\b|\W)(" + A_TB_Cadena.Text + @")(?<second>\W)";
                            var match = Regex.Match(cadena, patron);
                            if (!match.Success) { throw new Exception(); }
                            return Regex.Replace(cadena, patron, "${first}" + B_TB_Cadena.Text + A_TB_Cadena.Text + "${second}").ToString() + "\n";
                        }
                    }
                    catch { return cadena + "\n"; } //Cuando no encuentra la cadena
                }
                if (tab_reemplazo.SelectedTab == tabPage5)
                {   //Inserta un contador antes de la cadena buscada
                    try
                    {   //Se incrementa el contador DESPUES de insertarlo
                        if (A_CB_Cadenas.SelectedIndex == 0)
                        {   //Cualquier coincidencia.
                            //cadena = cadena.Insert(cadena.IndexOf(A_TB_Cadena.Text), CONTADOR.ToString()) + "\n";
                            cadena = cadena.Replace(A_TB_Cadena.Text, CONTADOR.ToString() + A_TB_Cadena.Text) + "\n";
                            CONTADOR += Convert.ToInt32(B_NDD_Increm.Value);
                            return cadena;
                        }
                        else if (A_CB_Cadenas.SelectedIndex == 1)
                        {   //Concidencia con palabra completa.
                            var patron = A_CB_Mayus.Checked ? @"(?<first>\b|\W)(" + A_TB_Cadena.Text + @")(?<second>\W)"
                                : @"(?i)(?<first>\b|\W)(" + A_TB_Cadena.Text + @")(?<second>\W)";
                            var match = Regex.Match(cadena, patron);
                            if (!match.Success) { throw new Exception(); }
                            cadena = Regex.Replace(cadena, patron, "${first}" + CONTADOR + A_TB_Cadena.Text + "${second}").ToString() + "\n";
                            CONTADOR += Convert.ToInt32(B_NDD_Increm.Value);
                            return cadena;
                        }
                    }
                    catch { return cadena + "\n"; } //Cuando no encuentra la cadena
                }
            }
            if (rdInsertAfter.Checked == true)
            {
                if (tab_reemplazo.SelectedTab == tabPage4)
                {   //Inserta una cadena después de la cadena buscada
                    try
                    {   //Se incrementa el contador DESPUES de insertarlo
                        if (A_CB_Cadenas.SelectedIndex == 0)
                        {   //Cualquier coincidencia
                            if (cadena.IndexOf(A_TB_Cadena.Text) == -1)
                                throw new Exception(); //-1 indica que no existe la cadena allí
                            //return cadena.Insert((cadena.IndexOf(A_TB_Cadena.Text) + A_TB_Cadena.Text.Length), B_TB_Cadena.Text) + "\n";
                            return cadena.Replace(A_TB_Cadena.Text, A_TB_Cadena.Text + B_TB_Cadena.Text) + "\n";
                        }
                        else if (A_CB_Cadenas.SelectedIndex == 1)
                        {   //Concidencia con palabra completa. Se incrementa el contador DESPUES de insertarlo
                            var patron = A_CB_Mayus.Checked ? @"(?<first>\b|\W)(" + A_TB_Cadena.Text + @")(?<second>\W)"
                                : @"(?i)(?<first>\b|\W)(" + A_TB_Cadena.Text + @")(?<second>\W)";
                            var match = Regex.Match(cadena, patron);
                            if (!match.Success) { throw new Exception(); }
                            return Regex.Replace(cadena, patron, "${first}" + A_TB_Cadena.Text + B_TB_Cadena.Text + "${second}").ToString() + "\n";
                        }
                    }
                    catch { return cadena + "\n"; } //Cuando no encuentra la cadena
                }
                if (tab_reemplazo.SelectedTab == tabPage5)
                {   //Inserta un contador después de la cadena buscada
                    try
                    {   //Se incrementa el contador DESPUES de insertarlo
                        if (A_CB_Cadenas.SelectedIndex == 0)
                        {   //Cualquier coincidencia
                            if (cadena.IndexOf(A_TB_Cadena.Text) == -1)
                                throw new Exception(); //-1 indica que no existe la cadena allí
                            //cadena = cadena.Insert((cadena.IndexOf(A_TB_Cadena.Text) + A_TB_Cadena.Text.Length), CONTADOR.ToString()) + "\n";
                            cadena = cadena.Replace(A_TB_Cadena.Text, A_TB_Cadena.Text + CONTADOR.ToString()) + "\n";
                            CONTADOR += Convert.ToInt32(B_NDD_Increm.Value);
                            return cadena;
                        }
                        else if (A_CB_Cadenas.SelectedIndex == 1)
                        {   //Concidencia con palabra completa.
                            var patron = A_CB_Mayus.Checked ? @"(?<first>\b|\W)(" + A_TB_Cadena.Text + @")(?<second>\W)"
                                : @"(?i)(?<first>\b|\W)(" + A_TB_Cadena.Text + @")(?<second>\W)";
                            var match = Regex.Match(cadena, patron);
                            if (!match.Success) { throw new Exception(); }
                            cadena = Regex.Replace(cadena, patron, "${first}" + A_TB_Cadena.Text + CONTADOR + "${second}").ToString() + "\n";
                            CONTADOR += Convert.ToInt32(B_NDD_Increm.Value);
                            return cadena;
                        }
                    }
                    catch { return cadena + "\n"; } //Cuando no encuentra la cadena
                }
            }
            if (rdReplace.Checked == true)
            {
                if (tab_reemplazo.SelectedTab == tabPage4)
                {   //Reemplazar la cadena buscada con otra cadena
                    if (A_CB_Cadenas.SelectedIndex == 0)
                    {   //Cualquier coincidencia
                        return cadena.Replace(A_TB_Cadena.Text, B_TB_Cadena.Text) + "\n";
                    }
                    else if (A_CB_Cadenas.SelectedIndex == 1)
                    {   //Concidencia con palabra completa
                        var patron = A_CB_Mayus.Checked ? @"(?<first>\W)(" + A_TB_Cadena.Text + @")(?<second>\W)"
                            : @"(?i)(?<first>\W)(" + A_TB_Cadena.Text + @")(?<second>\W)";
                        return Regex.Replace(cadena, patron, "${first}" + B_TB_Cadena.Text + "${second}").ToString() + "\n";
                    }
                }
                if (tab_reemplazo.SelectedTab == tabPage5)
                {   //Reemplazar la cadena buscada con un contador
                    if (A_CB_Cadenas.SelectedIndex == 0)
                    {   //Cualquier coincidencia
                        cadena = cadena.Replace(A_TB_Cadena.Text, CONTADOR.ToString()) + "\n";
                        CONTADOR += Convert.ToInt32(B_NDD_Increm.Value);
                        return cadena;
                    }
                    else if (A_CB_Cadenas.SelectedIndex == 1)
                    {   //Concidencia con palabra completa (ERROR AL REEMPLAZAR CON UN NÚMERO)
                        var patron = A_CB_Mayus.Checked ? @"(?<first>\W)(" + A_TB_Cadena.Text + @")(?<second>\W)"
                            : @"(?i)(?<first>\W)(" + A_TB_Cadena.Text + @")(?<second>\W)";
                        cadena = Regex.Replace(cadena, patron, "${first}" + CONTADOR + "${second}").ToString() + "\n";
                        CONTADOR += Convert.ToInt32(B_NDD_Increm.Value);
                        return cadena;
                    }
                }
            }
            //Por defecto elimina texto
            if (A_CB_Cadenas.SelectedIndex == 0)
            {   //Cualquier coincidencia
                return Regex.Replace(cadena, A_TB_Cadena.Text, "").ToString() + "\n";
            }
            if (A_CB_Cadenas.SelectedIndex == 1)
            {   //Concidencia con palabra completa
                var patron = A_CB_Mayus.Checked ? @"(?<first>\W)(" + A_TB_Cadena.Text + @")(?<second>\W)"
                            : @"(?i)(?<first>\W)(" + A_TB_Cadena.Text + @")(?<second>\W)";
                return Regex.Replace(cadena, patron, "${first}${second}").ToString() + "\n";
            }
            return "";
        }

        private string buscar_x_columnas(string cadena)
        {   //Explicación
            if (rdInsertBefore.Checked == true)
            {   
                if (tab_reemplazo.SelectedTab == tabPage4)
                {   //Inserta una cadena en la columna buscada
                    try { return cadena.Insert(Convert.ToInt32(A_NDD_Columna.Value-1), B_TB_Cadena.Text) + "\n"; }
                    catch { return cadena + "\n"; }
                }
                if (tab_reemplazo.SelectedTab == tabPage5)
                {   //Inserta un contador en la columna buscada
                    try
                    {   //Uso el try-catch por si una línea es mas corta que la posición que indico
                        cadena = cadena.Insert(Convert.ToInt32(A_NDD_Columna.Value - 1), CONTADOR.ToString()) + "\n";
                        CONTADOR += Convert.ToInt32(B_NDD_Increm.Value);
                        return cadena;
                    }
                    catch { return cadena + "\n"; }
                }
            }
            if (rdInsertAfter.Checked == true)
            {
                if (tab_reemplazo.SelectedTab == tabPage4)
                {   //Inserta una cadena después la columna buscada
                    try { return cadena.Insert(Convert.ToInt32(A_NDD_Columna.Value), B_TB_Cadena.Text) + "\n"; }
                    catch { return cadena + "\n"; }
                }
                if (tab_reemplazo.SelectedTab == tabPage5)
                {   //Inserta un contador después de la columna buscada
                    try
                    {   //Uso el try-catch por si una línea es mas corta que la posición que indico
                        cadena = cadena.Insert(Convert.ToInt32(A_NDD_Columna.Value), CONTADOR.ToString()) + "\n";
                        CONTADOR += Convert.ToInt32(B_NDD_Increm.Value);
                        return cadena;
                    }
                    catch { return cadena + "\n"; }
                }
            }
            if (rdReplace.Checked == true)
            {
                if (tab_reemplazo.SelectedTab == tabPage4)
                {   //Reemplazar un caracter con una cadena
                    try
                    {   //Uso el try-catch por si una línea es mas corta que la posición que indico
                        return cadena.Substring(0, Convert.ToInt32(A_NDD_Columna.Value-1))
                            + B_TB_Cadena.Text + cadena.Substring(Convert.ToInt32(A_NDD_Columna.Value)) + "\n";
                    }
                    catch { return cadena + "\n"; }
                }
                if (tab_reemplazo.SelectedTab == tabPage5)
                {   //Reemplazar un caracter con un contador
                    try
                    {   //Uso el try-catch por si una línea es mas corta que la posición que indico
                        cadena = cadena.Substring(0, Convert.ToInt32(A_NDD_Columna.Value-1))
                            + CONTADOR.ToString() + cadena.Substring(Convert.ToInt32(A_NDD_Columna.Value)) + "\n";
                        CONTADOR += Convert.ToInt32(B_NDD_Increm.Value);
                        return cadena;
                    }
                    catch { return cadena + "\n"; }
                }
            }
            //Por defecto elimina
            try
            {   //Uso el try-catch por si una línea es mas corta que la posición que indico
                return cadena.Substring(0, Convert.ToInt32(A_NDD_Columna.Value - 1)) 
                    + cadena.Substring(Convert.ToInt32(A_NDD_Columna.Value)) + "\n";
            }
            catch { return cadena + "\n"; }
        }

        private string buscar_x_lista(string cadena)
        {   //Expliación
            return "";
        }

        /* QUÉ INSERTAR */
        private string insertar_cadena(string cadena)
        {   //Expliación
            return "";
        }

        private string insertar_numeros(string cadena)
        {   //Expliación
            return "";
        }

        private string insertar_lista(string cadena)
        {   //Expliación
            return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //Explicación
            A_CB_Cadenas.SelectedIndex = 0;
        }

        /* CHECAR RADIO BUTTONS */
        private void rdInsertBefore_CheckedChanged(object sender, EventArgs e)
        {
            ACCION = "insertar_antes";
            lb_desc.Text = "Escoja que texto insertar:";
            btn_replace.Text = "Insertar";
            mostrar_tablon();
        }

        private void rdReplace_CheckedChanged(object sender, EventArgs e)
        {
            ACCION = "reemplazar";
            lb_desc.Text = "Escoja con que texto reemplazarlo:";
            btn_replace.Text = "Reemplazar";
            mostrar_tablon();
        }

        private void rdInsertAfter_CheckedChanged(object sender, EventArgs e)
        {
            ACCION = "insertar_despues";
            lb_desc.Text = "Escoja que texto insertar:";
            btn_replace.Text = "Insertar";
            mostrar_tablon();
        }

        private void rdDelete_CheckedChanged(object sender, EventArgs e)
        {
            ACCION = "borrar";
            btn_replace.Text = "Eliminar";
            mostrar_tablon(false);
        }

        private void mostrar_tablon(bool mostrar = true)
        {   //Muestra u oculta los tab de abajo según quien lo llame
            if (mostrar == true) {
                lb_desc.Visible = true;
                tab_reemplazo.Visible = true;
                tab_reemplazo.Enabled = true;
            }
            else {
                lb_desc.Visible = false;
                tab_reemplazo.Visible = false;
                tab_reemplazo.Enabled = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        { /*No se usa*/ }

        private void A_CB_Mayus_CheckedChanged(object sender, EventArgs e)
        { /*No se usa*/ }

        /* IDEAS
         * Poder reemplazar el texto con un salto de línea
         * Desplegar un mensaje de error cuando no se inserta texto en el textBox1
         * Añadir una pantalla o ícono de carga mientras se procesa el texto.
         * Evitar que se ajusten las MAYUSCULAS/minusculas con la opción "Distinguir mayús..." apagada
         * Colorear el texto cambiado (con color AZUL)
         * Añadir una lista desplegable de ayuda arriba
         */
    }
}
