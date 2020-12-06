using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Text;
using System.Windows.Forms;

namespace E2_Transporte
{
    public partial class FormaE : Form
    {
        public FormaE()
        {
            InitializeComponent();
        }

        private void FormaE_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (FormaF frmF = new FormaF(true))
            { frmF.ShowDialog(); } //Se abre una forma (para crear un Líder sindical)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {   //Para capturar los errores
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   //Se busca si existe un LS con esos datos
                    MySqlCommand buscar = new MySqlCommand("SELECT COUNT(*) FROM xLider_Sindical", conexion);
                    buscar.CommandTimeout = 60;
                    Int64 num1 = (Int64)buscar.ExecuteScalar();
                    buscar = new MySqlCommand("SELECT COUNT(*) FROM xLinea", conexion);
                    buscar.CommandTimeout = 60;
                    Int64 num2 = (Int64)buscar.ExecuteScalar(); 
                    conexion.Close();// se cierra la conexion
                    if (num1 > num2)
                    {   //De ser así, se le permite acceder
                        this.Visible = false;
                        using (FormaF frmF = new FormaF(false))
                        { frmF.ShowDialog(); } //Se abre una forma (Para crear una línea)
                    }
                    else
                        MessageBox.Show("Error. Debe crear primero un Líder Sindical");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); } //Notifica de cualquier error
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false; //Se hace invisible esta forma
            using (FormaD frmD = new FormaD("Admin123"))
            {   //Se abre otra forma
                frmD.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            using (FormaH frmH = new FormaH())
            { frmH.ShowDialog(); } //Se abre una forma (para hacer consultas y actualizar registros)
        }
    }
}
