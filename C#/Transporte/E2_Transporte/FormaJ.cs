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
    public partial class FormaJ : Form
    {
        private bool fin = true;
        private string Script;
        public FormaJ(string script)
        {
            InitializeComponent();
            this.Script = script;
        }

        DataTable dt = new DataTable();
        MySqlDataAdapter da;

        private void button1_Click(object sender, EventArgs e)
        {
            fin = false;
            this.Close();
        }

        private void FormaJ_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fin == true)
                Environment.Exit(0); 
        }

        private void FormaJ_Load(object sender, EventArgs e)
        {
            //Cargamos los datos
            try
            {   //Por si errores 
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   //Se insertan los LS disponibles
                    dt = new DataTable();
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    MySqlCommand db = new MySqlCommand(this.Script, conexion);
                    db.CommandTimeout = 60; //Se toman los nombres de los lideres sindicales sin linea asignada
                    da = new MySqlDataAdapter(db);
                    da.Fill(dt); //Se pasan los datos obtenidos al DatGridView
                    dataGridView1.DataSource = dt; 
                    conexion.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
        }
    }
}
