using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace E2_Transporte
{
    public partial class FormaC : Form
    {
        private bool fin = true;
        private string Identificador;
        public FormaC(string ID)
        {
            InitializeComponent();
            this.Identificador = ID; //Para identificar al usuario
        }

        private void FormaC_Load(object sender, EventArgs e)
        {
            string[] datos = { "Calafias", "Camiones", "Taxis de ruta", "Transporte privado" };
            comboBox1.Items.AddRange(datos);
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   //Por si errores
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   //Se insertan los LS disponibles
                    /*MySqlCommand actualizar = new MySqlCommand("UPDATE xLinea SET Categoria = " + comboBox1.SelectedItem.ToString() 
                        + "WHERE ID_Lider = " + this.Identificador, conexion);*/
                    MySqlCommand actualizar = new MySqlCommand("UPDATE xLinea SET Categoria = @Categoria WHERE ID_Lider = @ID_Lider", conexion);
                    actualizar.Parameters.AddWithValue("Categoria", comboBox1.SelectedItem.ToString());
                    actualizar.Parameters.AddWithValue("ID_Lider", this.Identificador);
                    actualizar.CommandTimeout = 60; //Se toman los nombres de los lideres sindicales sin linea asignada
                    actualizar.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Listo. A continuación podrá administrar su línea de transportes");
                    fin = false; this.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); } //Notifica de cualquier error
        }

        private void FormaC_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fin == true)
                Environment.Exit(0); 
        }
    }
}
