using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Busqueda = ProcesadorDeTexto.Interfaces.comport_busqueda;
using Lectura = ProcesadorDeTexto.Interfaces.comport_lectura;
using Escritura = ProcesadorDeTexto.Interfaces.comport_escritura;
using Reemplazo = ProcesadorDeTexto.Interfaces.comport_reemplazo;
using Remocion = ProcesadorDeTexto.Interfaces.comport_remocion;

namespace ProcesadorDeTexto
{
    public partial class Form1 : Form
    {
        #region VARIABLES GLOBALES
        public string ACCION = "";
        public string CADENA = ""; //Toma el valor de B_TB_Cadena
        public int CONTADOR; //Toma el valor de B_NDD_Inicio
        public int INCREMENTO; //Toma el valor de B_NDD_Increm
        public string OBJ_BUSCADO; //Toma el valor de los controles A
        public bool ULTIMA; //Toma el valor de A_CB_Ultima
        public bool DISTINGUIR; //Toma el valor de A_CB_Mayus
        public Stack<string> LISTA; //Toma el valor de textBox3
        #endregion

        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Both;
            textBox2.ScrollBars = ScrollBars.Both;
            A_CB_Cadenas.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //Explicación
            A_CB_Cadenas.SelectedIndex = 0;
            cb_Explain.SelectedIndex = 0;
            cb_AditionalAction.SelectedIndex = 0;
            cb_AditionalAction2.SelectedIndex = 0;
            activar_tercer_caja(false);
        }

        #region BOTONES
        //Modificar texto (flujo principal)
        private void btn_replace_Click(object sender, EventArgs e)
        {   //Imprime una copia de la primer textBox, modificada
            Procesador proc1 = new Procesador();
            Procesador proc2 = new Procesador();
            string[] cadenas; textBox2.Text = "";

            //Separa la cadena por línea
            cadenas = textBox1.Text.Split('\n');
            //Y agrega un salto de línea al final
            if (cadenas[cadenas.Length - 1].Contains("\r") == false)
                cadenas[cadenas.Length - 1] += "\r";

            #region Leer datos
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
            else
            {   //El procesador tomará el texto de textBox3
                LISTA = new Stack<string>(A_btn_clean.Text.Split('\n').Reverse());
                proc1.Como_leer_datos(new Lectura.Leer_Lista());

                if (B_CB_Replace.Checked)
                {
                    var linea = textBox1.Text.Split('\n')[0] + "\r";
                    cadenas = new string[LISTA.Count];

                    for (int x = 0; x < cadenas.Length; x++)
                        cadenas[x] = linea; //Todos las elementas tienen el mismo valor
                }
            }
            #endregion

            #region Escribir datos
            //Elegir el "comportamiento" de escritura según los radio buttons
            if (rdInsertBefore.Checked == true)
                proc2.Como_escribir_datos(new Escritura.Insertar_antes());
            else if (rdInsertAfter.Checked == true)
                proc2.Como_escribir_datos(new Escritura.Insertar_después());
            else if (rdReplace.Checked == true)
                proc2.Como_escribir_datos(new Escritura.Reemplazar());
            else //rdBorrar
                proc2.Como_escribir_datos(new Escritura.Borrar());
            #endregion

            #region Buscar/Reemplazar datos
            //Elegir el "comportamiento" (método a llamar) y el "comportamiento" de busqueda
            if (tab_reemplazable.SelectedTab == tabPage1)
            {   //Guarda el texto a buscar y si debe distinguir mayusculas de minusculas
                OBJ_BUSCADO = Regex.Replace(A_TB_Cadena.Text, @"[^\w\d\s]", @"\$&");
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
                ULTIMA = A_CB_Ultima.Checked;

                proc2.Como_reemplazar_datos(new Reemplazo.Quitar_Poner());
                proc2.Como_buscar_datos(new Busqueda.Buscar_columna());
            }
            #endregion

            #region Remover datos
            //Comportamiento para remover el resto de la cadena
            switch (cb_AditionalAction.SelectedIndex)
            {
                case 2:
                    proc2.Como_remover_datos(new Remocion.Remover_despues());
                    break;
                case 1:
                    proc2.Como_remover_datos(new Remocion.Remover_antes());
                    break;
                default:
                    proc2.Como_remover_datos(new Remocion.No_remover());
                    break;
            }
            #endregion

            //Ejecuta el método con la estrategia escogida y devuelve el texto modificado
            textBox2.Text = Procesar_datos(proc1, proc2, cadenas);
            tab_parrafo.SelectTab(1);
        }

        private string Procesar_datos(Procesador proc1, Procesador proc2, string[] cadenas)
        {   //Por cada fila (cadena) manda a llamar al comportamiento de lectura para modificar el texto
            string texto = "";
            foreach (string cadena in cadenas)
            {   //Si se encuentra un error, se devuelve la cadena sin cambios
                try
                {
                    if (cadena == "\r") { throw new Exception(); }
                    if (ULTIMA == true) { 
                        OBJ_BUSCADO = (cadena.Length - 1).ToString();
                    }
                    texto += proc1.Leer_datos(this, proc2, cadena);
                }
                catch { texto += cadena + "\n"; }
            }

            #region Ordenar
            int orden = cb_AditionalAction2.SelectedIndex;
            if (orden == 0) return texto;

            //Si se escogio ordenar el texto, se separa por filas
            string[] lineas = texto.Split('\n');

            Array.Sort(lineas); //El orden 2 es descendente
            if (orden == 2) Array.Reverse(lineas);

            return string.Join("\n", lineas);
            #endregion
        }

        //Subir archivos
        private void btn_upload_Click(object sender, EventArgs e)
        {
            subir_archivo(textBox1);
        }

        private void B_BTN_Upload_Click(object sender, EventArgs e)
        {
            subir_archivo(A_btn_clean);
        }

        private void subir_archivo(TextBox caja_texto)
        {   //Se lee el archivo que el usuario escoja y se imprime en un textBox
            OpenFileDialog ofd = new OpenFileDialog
            {
                FilterIndex = 0,
                RestoreDirectory = true,
                InitialDirectory = "c:\\",
                Filter = "Text files (*.txt)|*.txt;"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText($@"{ofd.FileName}");
                caja_texto.Text = text;
            }
        }

        //Botones de los textbox
        private void A_btn_clean_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void A_btn_paste_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }

        private void B_btn_clean_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void B_btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text, TextDataFormat.Text);
        }

        //Cambiar de tab
        private void A_btn_B_Click(object sender, EventArgs e)
        {
            tab_parrafo.SelectedTab = tabPageB;
        }

        private void B_btn_A_Click(object sender, EventArgs e)
        {
            tab_parrafo.SelectedTab = tabPageA;
        }
        #endregion

        #region CHECAR RADIO/CHECK BUTTONS
        private void A_CB_Ultima_CheckedChanged(object sender, EventArgs e)
        {   //Activa o desactiva el input izquierdo en función de su estado
            A_NDD_Columna.Enabled = !A_CB_Ultima.Checked;
        }

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
        #endregion

        #region OTROS MÉTODOS/EVENTOS
        private void cb_Explain_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cb_Explain.SelectedItem)
            {
                case "¿Qué hace este programa?":
                    MessageBox.Show("Toma el parrafo de 'Texto a modificar' y lo modifica de acuerdo a las" +
                        " opciones que escoja en la zona de abajo. Al pulsar el botón del fondo el parrafo" +
                        " se separa por filas y a cada una se le aplica el cambio indicado. Al final, se" +
                        " imprime el nuevo parrafo en 'Texto modificado'.");
                    break;
                case "Buscar texto (por cadena exacta)":
                    MessageBox.Show("Si esta es la pestaña seleccionada, en cada fila se buscará el texto" +
                        " del recuadro 'Cadena a buscar'. Si se encuentra, se aplicará la acción de abajo." +
                        " Al escoger la opción 'solo palabras completas', buscará solo cadenas que tengan" +
                        " un simbolo (como un punto) o espacios a ambos lados.");
                    break;
                case "Buscar texto (columnas x filas)":
                    MessageBox.Show("Si esta es la pestaña seleccionada, en cada fila se cambiara la" +
                        " misma columna. Las columnas se corresponden al número que ocupa un carácter en" +
                        " una fila; por ejemplo, 'e' ocupa la columna 3 en 'Alexis'. Si se marca la opción" +
                        " del checkbox, se buscara siempre la última columna en la fila.");
                    break;
                case "Acciones de los RadioButtons":
                    MessageBox.Show("Determinan que se hace al encontrar la cadena/columna. Ejemplo donde" +
                        " se inserta 'el ' en la columna 6 de 'Comí pastel': Insertar texto antes > 'Comí" +
                        " el pastel' / Insertar texto despues > 'Comí pel astel' / Reemplazar texto >" +
                        " 'Comí el astel' / Eliminar texto > 'Comí astel'");
                    break;
                case "Acciones de los Selects":
                    MessageBox.Show("Hay 2 selects al lado de los radio buttons. El primero sirve para" +
                        " eliminar el resto de la línea (antes o despúes del punto donde se encuentra la" +
                        " cadena/columna a buscar). El segundo sirve para indicar si se deben reordenar" +
                        " las líneas (alfabeticamente) tras modificar el texto. Si se deja la primera" +
                        " opción del select seleccionada, no se realizará su acción.");
                    break;
                case "Como insertar una cadena":
                    MessageBox.Show("Si esta es la pestaña seleccionada (seccion de abajo), en cada fila" +
                        " no vacía se insertará el texto que escriba en 'Cadena a insertar'.");
                    break;
                case "Insertar una iteración de números":
                    MessageBox.Show("Si esta es la pestaña seleccionada (seccion de abajo), en cada fila" +
                        " no vacía se insertará un número. En la primera será el indicado con 'Empezar en'" +
                        " y en las siguientes aumentará con el valor de 'Incrementar en'. Ejemplo: Inicio:" +
                        " 3 / Incremento: 2 > 3, 5, 7, etc.");
                    break;
                case "Insertar una lista de valores":
                    MessageBox.Show("Si esta es la pestaña seleccionada (seccion de abajo), aparecerá otra" +
                        " caja de texto en medio. Allí debe escribir o pegar un grupo de cadenas separadas" +
                        " por filas. Al insertar los datos, cada palabra se insertará en su fila correspon" +
                        "diente en 'Texto a modificar'; por ejemplo, la de la fila 3 se inserta en la terc" +
                        "er fila no vacía.");
                    break;
                case "Subir archivos":
                    MessageBox.Show("Con el botón 'Subir Archivo' puede subir el texto de un archivo .txt" +
                        " a la caja 'Texto a modificar'. Se tratará de la misma forma que un texto pegado" +
                        " o escrito. Él botón de la sección 'Lista de valores' hace lo mismo, pero en su" +
                        " propia caja de texto.");
                    break;
                case "Limpiar y copiar":
                    MessageBox.Show("El botón 'Limpiar' borra el texto del textarea de arriba y el botón" +
                        " 'Copiar' lo copia del mismo modo que al pulsar Ctrl + C. En ambos casos la acción" +
                        " se aplica a todo el texto, incluso si no lo ha seleccionado");
                    break;
            }
        }

        private void tab_reemplazo_Selected(object sender, TabControlEventArgs e)
        {
            if (tab_reemplazo.SelectedTab.Name == "tabPage6")
                activar_tercer_caja(true);
            else //Si no es el grupo de valores
                activar_tercer_caja(false);
        }

        private void activar_tercer_caja(bool activo)
        {
            label5.Visible = activo;
            A_btn_clean.Visible = activo;
            A_btn_clean.Enabled = activo;

            this.Width = activo ? 1170 : 960;
        }

        private void tab_reemplazable_Selected(object sender, TabControlEventArgs e)
        {
            if (tab_reemplazable.SelectedTab.Name == "tabPage1") { 
                A_CB_Ultima.Checked = ULTIMA = false;
            }
        }
        #endregion

        #region IDEAS Y ERRORES
        /* Poder reemplazar el texto con un salto de línea
         * Añadir una pantalla o ícono de carga mientras se procesa el texto.
         * Desplegar un mensaje cuando no se inserta texto en el textBox1
         * Colorear el texto cambiado (con color AZUL)
         * Agregar un botón para pegar tu texto en la primera pestaña
         * Añadir los espacios en blanco que falten para insertar texto en la columna indicada
         */
        #endregion

        #region SIN USO
        private void label3_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void A_CB_Mayus_CheckedChanged(object sender, EventArgs e) { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void label13_Click(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void tab_reemplazo_TabIndexChanged(object sender, EventArgs e) { }
        #endregion
    }
}
