using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace E2_Transporte
{
    public partial class FormaF : Form
    {
        private bool fin = true;
        private bool Modo;
        private List<string> Claves;
        public FormaF(bool modo)
        {
            InitializeComponent();
            this.Modo = modo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fin = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   
                    if (this.Modo == true)
                    {   //Se crea el LS
                        MySqlCommand altas = new MySqlCommand("INSERT INTO xLider_Sindical VALUES (@RFC, @Nombre, @Contrasenha)", conexion);
                        altas.Parameters.AddWithValue("RFC", textBox1.Text);
                        altas.Parameters.AddWithValue("Nombre", textBox2.Text);
                        altas.Parameters.AddWithValue("Contrasenha", textBox3.Text);
                        altas.CommandTimeout = 60;
                        altas.ExecuteNonQuery();
                        conexion.Close();// se cierra la conexion
                        MessageBox.Show("Inserción exitosa");
                        fin = false;
                        this.Close(); //La forma se cierra preventivamente
                    }
                    else
                    {
                        string comparación = "^(([0-1]{1}[0-9]{1})|(2{1}[0-4]{1})):[0-5]{1}[0-9]{1}:[0-5]{1}[0-9]{1}$"; //Verifica que la hora sea correcta
                        if (Regex.IsMatch(textBox3.Text, comparación) && Regex.IsMatch(textBox4.Text, comparación))
                        {
                            MySqlCommand altas = new MySqlCommand("INSERT INTO xLinea VALUES (@Color, @Zona, @HoraInicio, @HoraFinal,  @Categoria, @ID_Líder)", conexion);
                            altas.Parameters.AddWithValue("Color", textBox1.Text);
                            altas.Parameters.AddWithValue("Zona", textBox2.Text);
                            altas.Parameters.AddWithValue("HoraInicio", textBox3.Text);
                            altas.Parameters.AddWithValue("HoraFinal", textBox4.Text);
                            altas.Parameters.AddWithValue("Categoria", comboBox2.SelectedItem.ToString());
                            altas.Parameters.AddWithValue("ID_Líder", Claves[comboBox1.SelectedIndex]);
                            altas.CommandTimeout = 60;
                            altas.ExecuteNonQuery();
                            conexion.Close();// se cierra la conexion
                            MessageBox.Show("Inserción exitosa");
                            fin = false;
                            this.Close(); //La forma se cierra preventivamente
                        }
                        else
                            MessageBox.Show("Error: Formato incorrecto en la hora");
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); } //Notifica de cualquier error
        }

        private void FormaF_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fin == true)
                Environment.Exit(0);
        }

        private void FormaF_Load(object sender, EventArgs e)
        {
            if (Modo == false)
            {
                this.Width = 400;
                label1.Text = "Color:";
                label2.Text = "Ruta:";
                label3.Text = "Hora inicio:\n??:??:??";
                label4.Visible = true; label5.Visible = true; 
                label6.Visible = true; label7.Visible = true; 
                comboBox1.Visible = true; comboBox1.Enabled = true;
                comboBox2.Visible = true; comboBox2.Enabled = true;
                textBox4.Visible = true; textBox4.Enabled = true;

                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   //Se insertan los LS disponibles
                    MySqlCommand obtener = new MySqlCommand("SELECT Nombre FROM xLider_Sindical WHERE RFC NOT IN(SELECT ID_Lider FROM xLinea)", conexion);
                    obtener.CommandTimeout = 60; //Se toman los nombres de los lideres sindicales sin linea asignada
                    MySqlDataReader fk; //Lee el resultado de la consulta
                    fk = obtener.ExecuteReader();
                    while (fk.Read())
                    {   //Los nombres se añaden al comboBox
                        comboBox1.Items.Add(fk[0]);
                    }
                    comboBox1.SelectedItem = comboBox1.Items[0];
                    fk.Close(); //Se reinicia el lector
                    Claves = new List<string>();
                    obtener = new MySqlCommand("SELECT RFC FROM xLider_Sindical WHERE RFC NOT IN(SELECT ID_Lider FROM xLinea)", conexion);
                    fk = obtener.ExecuteReader();
                    while (fk.Read())
                    {   //Y sus RFC se añaden a un arreglo
                        Claves.Add(fk[0].ToString());
                    }
                    conexion.Close();
                }
                string[] datos = { "Calafias", "Camiones", "Taxis de ruta", "Transporte privado", "Pendiente"};
                comboBox2.Items.AddRange(datos);
                comboBox2.SelectedItem = comboBox2.Items[4];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NADA
        }
    }
}
