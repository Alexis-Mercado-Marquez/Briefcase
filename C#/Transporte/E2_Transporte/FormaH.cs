using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E2_Transporte
{
    public partial class FormaH : Form
    {
        private bool fin = true;
        public FormaH()
        {
            InitializeComponent();
        }

        private void FormaH_Load(object sender, EventArgs e)
        {
            string[] Arreglo = { "xLinea", "xLider_Sindical", "xVehiculo", "VDiesel", "VElectrico", "VGasolina", "VHibrido", "VHidrogeno"};
            comboBox1.Items.AddRange(Arreglo); //PASO 1
            comboBox1.SelectedItem = comboBox1.Items[0];
            Busqueda_listas("xLinea"); //PASO 2
            string[] Arreglo2 = {"=", "!=", "<", ">"};
            comboBox3.Items.AddRange(Arreglo2); //PASO 3
            comboBox3.SelectedItem = comboBox3.Items[0];
            comboBox5.Items.AddRange(Arreglo2); 
            comboBox5.SelectedItem = comboBox5.Items[0];
            comboBox7.Items.AddRange(Arreglo2); 
            comboBox7.SelectedItem = comboBox7.Items[0];
        }

        public void Busqueda_listas(string dato)
        {   //Limpieza de los comboBox
            comboBox2.Items.Clear();
            comboBox4.Items.Clear();
            comboBox6.Items.Clear();
            comboBox8.Items.Clear();
            comboBox9.Items.Clear();
            string[] xArreglo = { };
            string[] yArreglo = { };
            if (comboBox1.SelectedItem.ToString() == "xLinea"|| dato == "xLinea")
            {
                xArreglo = new string [] { "Color", "Zona", "Categoria", "HoraInicio", "HoraFinal", "ID_Lider", "Nulo"};
                if (dato == "Act" || radioButton2.Checked == true)
                    yArreglo = new string[] { "Zona", "HoraInicio", "HoraFinal", "Nulo" };
            }
            else if (comboBox1.SelectedItem.ToString() == "xLider_Sindical")
            {
                xArreglo = new string[] { "RFC", "Nombre", "Contrasenha"};
                if (dato == "Act" || radioButton2.Checked == true)
                    yArreglo = new string[] { "Nombre", "Contrasenha", "Nulo" };
            }
            else if (comboBox1.SelectedItem.ToString() == "xVehiculo")
            {
                xArreglo = new string[] { "Id", "Color", "NombreChofer", "TipoTrans", "TipoMotor", "Modelo", "Placa", "Tarifa", "Costo_Min", "Mom_Pago", "Capacidad", "Tarifa_est", "Nulo" };
                if (dato == "Act" || radioButton2.Checked == true)
                    yArreglo = new string[] { "NombreChofer", "Modelo", "Placa", "Tarifa", "Costo_Min", "Mom_Pago", "Capacidad", "Tarifa_est", "Nulo" };
            }
            else if (comboBox1.SelectedItem.ToString() == "VDiesel")
            {
                xArreglo = new string[] { "ID", "VelocMax", "CapacLitros", "NumCilindros", "ID_Vehiculo", "Nulo" };
                if (dato == "Act" || radioButton2.Checked == true)
                    yArreglo = new string[] { "VelocMax", "CapacLitros", "NumCilindros", "Nulo" };
            }
            else if (comboBox1.SelectedItem.ToString() == "VElectrico")
            {
                xArreglo = new string[] { "ID", "VelocMax", "CargaMax", "ID_Vehiculo", "Nulo" };
                if (dato == "Act" || radioButton2.Checked == true)
                    yArreglo = new string[] { "VelocMax", "CargaMax", "Nulo" };
            }
            else if (comboBox1.SelectedItem.ToString() == "VGasolina")
            {
                xArreglo = new string[] { "ID", "VelocMax", "CapacLitros", "NumCilindros", "ID_Vehiculo", "Nulo" };
                if (dato == "Act" || radioButton2.Checked == true)
                    yArreglo = new string[] { "VelocMax", "CapacLitros", "NumCilindros", "Nulo" };
            }
            else if (comboBox1.SelectedItem.ToString() == "VHibrido")
            {
                xArreglo = new string[] { "ID", "VelocMax", "CapacLitros", "NumCilindros", "CargaMax", "ID_Vehiculo", "Nulo" };
                if (dato == "Act" || radioButton2.Checked == true)
                    yArreglo = new string[] { "VelocMax", "CapacLitros", "NumCilindros", "CargaMax", "Nulo" };
            }
            else if (comboBox1.SelectedItem.ToString() == "VHidrogeno")
            {
                xArreglo = new string[] { "ID", "VelocMax", "Por_Eficiencia", "ID_Vehiculo", "Nulo" };
                if (dato == "Act" || radioButton2.Checked == true)
                    yArreglo = new string[] { "VelocMax", "CapacLitros", "NumCilindros", "CargaMax", "Nulo" };
            }
            //Se añaden las opciones a los combobox
            comboBox4.Items.AddRange(xArreglo);
            comboBox2.Items.AddRange(xArreglo);
            comboBox6.Items.AddRange(xArreglo);
            comboBox8.Items.AddRange(xArreglo);
            comboBox9.Items.AddRange(xArreglo);
            //Si es una actualización
            if (dato == "Act" || radioButton2.Checked == true)
            {
                comboBox8.Items.Clear();
                comboBox9.Items.Clear();
                comboBox8.Items.AddRange(yArreglo);
                comboBox9.Items.AddRange(yArreglo);
            }
            //Ahora se les da valores por defecto
            comboBox2.SelectedItem = comboBox2.Items[0];
            comboBox4.SelectedItem = comboBox4.Items[0];
            comboBox6.SelectedItem = comboBox6.Items[0];
            comboBox8.SelectedItem = comboBox8.Items[0];
            comboBox9.SelectedItem = comboBox9.Items[0];
        }

        private void FormaH_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fin == true)
                Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fin = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string script = Constructor_SQL();
            textBox4.Text = script;
        }

        public string Constructor_SQL()
        {
            string script = "Elección incorrecta"; //Donde va nuestro código SQL
            if (radioButton1.Checked == true)
            {
                script = "SELECT ";
                if (checkBox5.Checked == false && comboBox8.SelectedItem.ToString() == "Nulo" && comboBox9.SelectedItem.ToString() == "Nulo")
                { MessageBox.Show("Error. No ha indicado que atributo buscar"); }
                else if (checkBox5.Checked == true)
                { script += " * FROM " + comboBox1.SelectedItem.ToString(); }
                else if (comboBox8.SelectedItem.ToString() != "Nulo")
                {   //Armado del SELECT
                    if (comboBox9.SelectedItem.ToString() != "Nulo")
                        script += comboBox8.SelectedItem.ToString() + ", " + comboBox9.SelectedItem.ToString() + " FROM " + comboBox1.SelectedItem.ToString();
                    else
                        script += comboBox8.SelectedItem.ToString() + " FROM " + comboBox1.SelectedItem.ToString();
                }
                else
                    script += comboBox9.SelectedItem.ToString() + " FROM " + comboBox1.SelectedItem.ToString();
            }
            else
            {
                script = "UPDATE " + comboBox1.SelectedItem.ToString() + " SET "; 
                if (comboBox8.SelectedItem.ToString() != "Nulo" || comboBox9.SelectedItem.ToString() != "Nulo")
                {
                    string[] var1 = { textBox6.Text, textBox5.Text };
                    string[] var2 = { comboBox9.SelectedItem.ToString(), comboBox8.SelectedItem.ToString() };
                    if (var2[0] == "Color" || var2[0] == "NombreChofer" || var2[0] == "TipoTrans" || var2[0] == "TipoMotor" || var2[0] == "Placa" || var2[0] == "MomPago" || var2[0] == "Zona" || var2[0] == "Categoria" || var2[0] == "ID_Lider"
                        || var2[0] == "RFC" || var2[0] == "Nombre" || var2[0] == "Contrasenha")
                        var1[0] = "'" + textBox6.Text + "'";
                    if (var2[1] == "Color" || var2[1] == "NombreChofer" || var2[1] == "TipoTrans" || var2[1] == "TipoMotor" || var2[1] == "Placa" || var2[1] == "MomPago" || var2[1] == "Zona" || var2[1] == "Categoria" || var2[1] == "ID_Lider"
                        || var2[1] == "RFC" || var2[1] == "Nombre" || var2[1] == "Contrasenha")
                        var1[1] = "'" + textBox5.Text + "'";
                    //Se colocan los datos a insertar
                    if (comboBox8.SelectedItem.ToString() != "Nulo")
                    {   //Armado del UPDATE
                        if (comboBox9.SelectedItem.ToString() != "Nulo")
                            script += var2[0]+"="+var1[0]+", "+ var2[1] + "=" + var1[1];
                        else
                            script += var2[1] + "=" + var1[1];
                    }
                    else
                        script += var2[0] + "=" + var1[0];
                }
                else
                    MessageBox.Show("Error. No ha indicado que atributo actualizar");
            }
            if (checkBox6.Checked == true && (comboBox2.SelectedItem.ToString() != "Nulo"))
            {   //Primero hay que dar formato a las variables de texto
                string[] uno = { textBox1.Text, textBox2.Text, textBox3.Text};
                string[] dos = { comboBox2.SelectedItem.ToString(), comboBox4.SelectedItem.ToString(), comboBox6.SelectedItem.ToString() };
                if (dos[0] == "Color" || dos[0] == "NombreChofer" || dos[0] == "TipoTrans" || dos[0] == "TipoMotor" || dos[0] == "Placa" || dos[0] == "MomPago" || dos[0] == "Zona" || dos[0] == "Categoria" || dos[0] == "ID_Lider"
                    || dos[0] == "RFC" || dos[0] == "Nombre" || dos[0] == "Contrasenha")
                    uno[0] = "'" + textBox1.Text + "'";
                if (dos[1] == "Color" || dos[1] == "NombreChofer" || dos[1] == "TipoTrans" || dos[1] == "TipoMotor" || dos[1] == "Placa" || dos[1] == "MomPago" || dos[1] == "Zona" || dos[1] == "Categoria" || dos[1] == "ID_Lider"
                    || dos[1] == "RFC" || dos[1] == "Nombre" || dos[1] == "Contrasenha")
                    uno[1] = "'" + textBox2.Text + "'";
                if (dos[2] == "Color" || dos[2] == "NombreChofer" || dos[2] == "TipoTrans" || dos[2] == "TipoMotor" || dos[2] == "Placa" || dos[2] == "MomPago" || dos[2] == "Zona" || dos[2] == "Categoria" || dos[2] == "ID_Lider"
                    || dos[2] == "RFC" || dos[2] == "Nombre" || dos[2] == "Contrasenha")
                    uno[2] = "'" + textBox3.Text + "'";

                script += " WHERE " + comboBox2.SelectedItem.ToString() + comboBox3.SelectedItem.ToString() + uno[0];
                try
                {
                    if (comboBox4.SelectedItem.ToString() != "Nulo")
                    {   //Las condiciones del where (máx 3)
                        if (rBO1.Checked == true)
                            script += " OR " + comboBox4.SelectedItem.ToString() + comboBox5.SelectedItem.ToString() + uno[1];
                        else
                            script += " AND " + comboBox4.SelectedItem.ToString() + comboBox5.SelectedItem.ToString() + uno[1];
                    }
                    if (comboBox6.SelectedItem.ToString() != "Nulo")
                    {
                        if (rBO2.Checked == true)
                            script += " OR " + comboBox6.SelectedItem.ToString() + comboBox7.SelectedItem.ToString() + uno[2];
                        else
                            script += " AND " + comboBox6.SelectedItem.ToString() + comboBox7.SelectedItem.ToString() + uno[2];
                    }
                }
                catch (Exception ex)
                { MessageBox.Show("Error de parametros: " + ex.ToString()); }
            }
            if (radioButton1.Checked == true)
            {   //Orden
                if (checkBox5.Checked == true)
                    script += " ORDER BY " + comboBox2.Items[0].ToString();
                else if (comboBox8.SelectedItem.ToString() != "Nulo")
                    script += " ORDER BY " + comboBox8.SelectedItem.ToString();
                else if(comboBox9.SelectedItem.ToString() != "Nulo")
                    script += " ORDER BY " + comboBox9.SelectedItem.ToString();
                //¿Ascendente o descendente?
                if (checkBox1.Checked == true)
                    script += " ASC";
                else
                    script += " DESC";
            }
            return script;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { Busqueda_listas(""); }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En esta ventana  podrá construir varios tipos  de consultas.\n"
                + "Primero escoja  en que tabla buscar  (esquina superior izq).\n"
                + "Si quiere, filtre los resultados marcando la casilla 'Donde'\n"
                + "en cada renglo  escoja por que  parametro filtrar (izq), con\n"
                + "que compararlo (der)  y que comparación va a hacer (centro).\n"
                + "Si solo quiere evaluar 1 atributo escoja 'Nulo' en las otras\n"
                + "dos casillas de la izq. Si escoje 'Y' se deberán cumplir to-\n"
                + "das las condiciones y con 'O' solo algunas de ellas.\n"
                + "Al final elija si seleccionar los registros o actualizarlos.\n"
                + "Si los actualiza puede elegir 2 valores para reemplazar (con\n"
                + "las cajas  de opciones del fondo)  y debajo con que  valores\n"
                + "reemplazarlos. Por cierto, el formato de la hora es: 000000.\n"
                + "Si marca la casilla ¿Ascendente? los registros estaran orde-\n"
                + "nados del mayor al menor  con base en el primer atributo de.\n"
                + "la consulta.");
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            try //Por si errores
            {
                string script = Constructor_SQL();
                if (radioButton1.Checked == true)
                {
                    this.Visible = false;
                    using (FormaJ frmJ = new FormaJ(script))
                    { frmJ.ShowDialog(); } //Se abre una forma (para mostrar la consulta)
                    this.Visible = true;
                }
                else if (textBox5.Text != null || textBox6.Text != null)
                {
                    using (MySqlConnection conexion = BDComun.ObtenerCon())
                    {
                        MySqlCommand actual = new MySqlCommand(script, conexion);
                        actual.CommandTimeout = 60;
                        actual.ExecuteNonQuery();
                        MessageBox.Show("Registros actualizados exitosamente");
                    }
                } 
                else 
                    MessageBox.Show("Error. Falta específicar los datos a actualizar");
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {   //SELECCIONAR
                label11.Text = "Datos a buscar";
                textBox5.Visible = false; textBox5.Enabled = false;
                textBox6.Visible = false; textBox6.Enabled = false;

                Busqueda_listas("Con");
                tabPage1.Text = "Seleccionar";
                checkBox5.Visible = true;
                buttonC.Text = "Consultar";
            }
            else
            {   //ACTUALIZAR
                label11.Text = "Datos a modificar";
                textBox5.Visible = true; textBox5.Enabled = true;
                textBox6.Visible = true; textBox6.Enabled = true;

                Busqueda_listas("Act");
                tabPage1.Text = "Actualizar";
                checkBox5.Visible = false;
                buttonC.Text = "Actualizar";
            } //Ultimos ajustes
            comboBox8.SelectedItem = comboBox8.Items[0];
            comboBox9.SelectedItem = comboBox9.Items[0];
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {   //Este habilita o deshabilita elementos en función de si esta activado
            if (checkBox5.Checked) {
                comboBox8.Enabled = comboBox9.Enabled = true;
                textBox5.Enabled = textBox6.Enabled = true;
            } else {
                comboBox8.Enabled = comboBox9.Enabled = false;
                textBox5.Enabled = textBox6.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {   //Este habilita o deshabilita elementos en función de si esta activado
            if (checkBox6.Checked) {
                panel1.Enabled = panel2.Enabled = true;
                comboBox2.Enabled = comboBox3.Enabled = comboBox4.Enabled = true;
                comboBox5.Enabled = comboBox6.Enabled = comboBox7.Enabled = true;
                textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = true;
            } else {
                panel1.Enabled = panel2.Enabled = false;
                comboBox2.Enabled = comboBox3.Enabled = comboBox4.Enabled = false;
                comboBox5.Enabled = comboBox6.Enabled = comboBox7.Enabled = false;
                textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox8.Enabled = comboBox9.Enabled = true;
            textBox5.Enabled = textBox6.Enabled = true;
        }
    }
}
