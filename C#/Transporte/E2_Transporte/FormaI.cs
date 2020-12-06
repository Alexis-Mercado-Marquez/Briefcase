using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace E2_Transporte
{
    public partial class FormaI : Form
    {
        private bool fin = true;
        private int Id;
        private MySqlCommand Busqueda;
        public FormaI(MySqlCommand busqueda, int id)
        {
            InitializeComponent();
            this.Busqueda = busqueda;
            Id = id; //Id para hacer la actualización
        }

        DataTable dt = new DataTable();
        MySqlDataAdapter da;

        private void button1_Click(object sender, EventArgs e)
        {
            fin = false;
            this.Close();
        }

        private void FormaI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fin == true)
                Environment.Exit(0);
        }

        private void FormaI_Load(object sender, EventArgs e)
        {   //Cargar los datos
            cargar_grilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = BDComun.ObtenerCon())
            {   //Y se inserta el registro de su motor
                MySqlCommand subir = new MySqlCommand("UPDATE xVehiculo SET NombreChofer = @Dato WHERE Id = @Id", conexion);
                if (comboBox1.SelectedItem.ToString() == "Modelo")
                    subir = new MySqlCommand("UPDATE xVehiculo SET Modelo = @Dato WHERE Id = @Id", conexion);
                else if (comboBox1.SelectedItem.ToString() == "Placa")
                    subir = new MySqlCommand("UPDATE xVehiculo SET Placa = @Dato WHERE Id = @Id", conexion);
                else if (comboBox1.SelectedItem.ToString() == "Tarifa")
                    subir = new MySqlCommand("UPDATE xVehiculo SET Tarifa = @Dato WHERE Id = @Id", conexion);
                else if (comboBox1.SelectedItem.ToString() == "Capacidad")
                    subir = new MySqlCommand("UPDATE xVehiculo SET Capacidad = @Dato WHERE Id = @Id", conexion);
                subir.Parameters.AddWithValue("Dato", textBox1.Text);
                subir.Parameters.AddWithValue("Id", Id);
                subir.CommandTimeout = 60;
                subir.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Registro exitosamente actualizado ");
                cargar_grilla();
            }
        }

        private void cargar_grilla()
        {   //Carga los datos de vehículos del color de líder
            try //Por si errores 
            {
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   //Aqui se llena la tabla
                    dt = new DataTable();
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    da = new MySqlDataAdapter(Busqueda);
                    da.Fill(dt); //En esta y la sig linea se pasan los datos obtenidos al DatGridView
                    dataGridView1.DataSource = dt;
                    conexion.Close();
                    //Se cargan los posibles atributos modificables en el comboBox
                    comboBox1.Items.Add("NombreChofer");
                    comboBox1.Items.Add("Modelo");
                    comboBox1.Items.Add("Placa");
                    comboBox1.Items.Add("Tarifa");
                    comboBox1.Items.Add("Capacidad");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
        }
    }
}
