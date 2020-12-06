using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace E2_Transporte
{
    public partial class FormaD : Form
    {
        private bool fin = true;
        private string Linea;
        private string Admin;
        public FormaD(string color_linea)
        {
            InitializeComponent();
            this.Linea = color_linea;
            this.Admin = color_linea;
        }

        public Calafias[] TransporteA;
        public Camiones[] TransporteB;
        public Taxis_de_Ruta[] TransporteC;
        public Transporte_Priv[] TransporteD;
        public int[] cont;

        private void buttonS_Click(object sender, EventArgs e)
        {
            fin = false;
            this.Close();
        }

        private void FormaD_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fin == true)
                Environment.Exit(0);
        }

        private void buttonCA_Click(object sender, EventArgs e)
        {
            string motor = "Hibrido";
            IFabricaVehiculo fabrica; //Primero se crea la fabrica
            if (radioBE.Checked == true)
            { fabrica = new Fab_Veh_Electrico(float.Parse(textBox8.Text), float.Parse(textBox9.Text)); motor = "Electrico"; }
            else if (radioBG.Checked == true)
            { fabrica = new Fab_Veh_Gasolina(float.Parse(textBox8.Text), float.Parse(textBox9.Text), int.Parse(textBox10.Text)); motor = "Gasolina"; }
            else if (radioBD.Checked == true)
            { fabrica = new Fab_Veh_Diesel(float.Parse(textBox8.Text), float.Parse(textBox9.Text), int.Parse(textBox10.Text), bool.Parse(textBox11.Text)); motor = "Diesel"; }
            else if (radioBH.Checked == true)
            { fabrica = new Fab_Veh_Hidrogeno(float.Parse(textBox8.Text), int.Parse(textBox9.Text)); motor = "Hidrogeno"; }
            else //Por defecto
                fabrica = new Fab_Veh_Mixto(float.Parse(textBox8.Text), float.Parse(textBox9.Text), int.Parse(textBox10.Text), float.Parse(textBox11.Text));

            //Ahora se crean los vehículos
            try //Por si errores
            {
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   //Primero se verifica la existencia de al menos un registro
                    if (Admin == "Admin123") //¿Lo pide el admin?
                        this.Linea = comboBox1.SelectedItem.ToString();
                    MySqlCommand obtener = new MySqlCommand("SELECT COUNT(*) FROM xLinea WHERE Color = @Color", conexion);
                    obtener.Parameters.AddWithValue("Color", this.Linea);
                    Int64 contador = (Int64)obtener.ExecuteScalar();
                    if (contador == 1)
                    {
                        string dato = "";
                        obtener = new MySqlCommand("SELECT Categoria FROM xLinea WHERE Color = @Color", conexion);
                        obtener.Parameters.AddWithValue("Color", this.Linea);
                        obtener.CommandTimeout = 60;
                        MySqlDataReader fk; //Para leer el resultado de la consulta
                        fk = obtener.ExecuteReader();
                        if (fk.Read()) //Se obtiene el tipo de transporte de la linea
                            dato = fk[0].ToString();
                        //Creación de vehículos
                        bool logro = false;
                        if (dato == "Calafias")
                        {   //Se crea una calafia
                            TransporteA[cont[0]] = fabrica.crearCalafia(this.Linea, textBox2.Text, float.Parse(textBox5.Text), float.Parse(textBox7.Text), textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox1.Text));
                            logro = TransporteA[cont[0]].Inserta_Calafia(motor);
                            if (logro == true)
                                TransporteA[cont[0]].Insertar_en_BD();
                            cont[0]++; //Se incrementa el contador
                        }
                        else if (dato == "Camiones")
                        {   //Se crea una calafia
                            TransporteB[cont[1]] = fabrica.crearCamion(this.Linea, textBox2.Text, float.Parse(textBox5.Text), float.Parse(textBox7.Text), "Subida", textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox1.Text));
                            logro = TransporteB[cont[1]].Inserta_Camion(motor);
                            if (logro == true)
                                TransporteB[cont[1]].Insertar_en_BD();
                            cont[1]++; //Se incrementa el contador
                        }
                        else if (dato == "Taxis de ruta")
                        {   //Se crea una calafia
                            TransporteC[cont[2]] = fabrica.crearTaxi(this.Linea, textBox2.Text, float.Parse(textBox5.Text), float.Parse(textBox6.Text), textBox3.Text, int.Parse(textBox4.Text));
                            logro = TransporteC[cont[2]].Inserta_Taxi(motor);
                            if (logro == true)
                                TransporteC[cont[2]].Insertar_en_BD();
                            cont[2]++; //Se incrementa el contador
                        }
                        else if (dato == "Transporte privado")
                        {   //Se crea una calafia
                            TransporteD[cont[3]] = fabrica.crearTP(this.Linea, textBox2.Text, float.Parse(textBox5.Text), float.Parse(textBox6.Text), textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox1.Text));
                            logro = TransporteD[cont[3]].Inserta_TPrivado(motor);
                            if (logro == true)
                                TransporteD[cont[3]].Insertar_en_BD();
                            cont[3]++; //Se incrementa el contador
                        }
                    }
                    else
                        MessageBox.Show("No se encontro su línea");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
        }

        private void radioBE_CheckedChanged(object sender, EventArgs e)
        { Cambiar_Motor(); } //Se llama al método

        private void radioBG_CheckedChanged(object sender, EventArgs e)
        { Cambiar_Motor(); } //Se llama al método

        private void radioBD_CheckedChanged(object sender, EventArgs e)
        { Cambiar_Motor(); } //Se llama al método

        private void radioBH_CheckedChanged(object sender, EventArgs e)
        { Cambiar_Motor(); } //Se llama al método

        private void radioBM_CheckedChanged(object sender, EventArgs e)
        { Cambiar_Motor(); } //Se llama al método

        private void Cambiar_Motor()
        {   //Se cambian los datos requeridos en función del tipo de motor
            if (radioBE.Checked == true)
            {
                label10.Text = "CargaMáx";
                label11.Visible = false; label12.Visible = false;
                textBox10.Visible = false; textBox11.Visible = false;
            }
            else if (radioBG.Checked == true)
            {
                label10.Text = "CapacLitros";
                label11.Text = "NúmCilindros";
                label11.Visible = true; label12.Visible = false;
                textBox10.Visible = true; textBox11.Visible = false;
            }
            else if (radioBD.Checked == true)
            {
                label10.Text = "CapacLitros";
                label11.Text = "NúmCilindros";
                label12.Text = "¿Biodiesel?\n(true/false)";
                label11.Visible = true; label12.Visible = true;
                textBox10.Visible = true; textBox11.Visible = true;
            }
            else if (radioBH.Checked == true)
            {
                label10.Text = "Porcentaje de\neficiencia";
                label11.Visible = false; label12.Visible = false;
                textBox10.Visible = false; textBox11.Visible = false;
            }
            else //Por defecto
            {
                label10.Text = "CapacLitros";
                label11.Text = "NúmCilindros";
                label12.Text = "CargaMáx";
                label11.Visible = true; label12.Visible = true;
                textBox10.Visible = true; textBox11.Visible = true;
            }
        }

        private void FormaD_Load(object sender, EventArgs e)
        {
            TransporteA = new Calafias[20];
            TransporteB = new Camiones[20];
            TransporteC = new Taxis_de_Ruta[15];
            TransporteD = new Transporte_Priv[15];
            cont = new int[] { 0, 0, 0, 0 };
            if(Linea == "Admin123")
            {   //Si lo usa el admin
                comboBox1.Visible = true; comboBox1.Enabled = true;
                try //Por si errores
                {
                    using (MySqlConnection conexion = BDComun.ObtenerCon())
                    {
                        MySqlCommand obtener = new MySqlCommand("SELECT Color FROM xLinea", conexion);
                        obtener.CommandTimeout = 60; //Se toman los nombres de los lideres sindicales sin linea asignada
                        MySqlDataReader fk; //Para leer el resultado de la consulta
                        fk = obtener.ExecuteReader();
                        while (fk.Read()) //Se añaden las líneas al comboBox
                            comboBox1.Items.Add(fk[0].ToString());
                        conexion.Close();
                        label13.Text = "                Línea";
                    }
                }
                catch (Exception ex)
                { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
            }
        }

        private void buttonB_Click(object sender, EventArgs e) { /*Nada*/ }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {   //No permite que se inserten caracteres no numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            //Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {   //No permite que se inserten caracteres no numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            //Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {   //No permite que se inserten caracteres no numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            //Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {   //No permite que se inserten caracteres no numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            //Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {   //No permite que se inserten caracteres no numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            //Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {   //No permite que se inserten caracteres no numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            //Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {   //No permite que se inserten caracteres no numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            //Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}
