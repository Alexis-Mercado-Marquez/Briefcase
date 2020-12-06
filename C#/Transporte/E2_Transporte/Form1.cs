using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Text;
using System.Windows.Forms;

namespace E2_Transporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {   //Acceder al servidor
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {   //Para prevenir los errores
                    if ((textBox1.Text == "1JABDRPD92MA" || textBox1.Text == "Admin") && textBox2.Text == "Contraseña")
                    {   //Administrador solo hay uno
                        MessageBox.Show("Bienvenido administrador. Ahora se abrirá su panel de administración.");
                        this.Visible = false; //Se hace invisible esta forma
                        using (FormaE frmE = new FormaE())
                        {   //Se abre otra forma
                            while (1 == 1)
                                frmE.ShowDialog();
                        } 
                    }
                    else
                    {
                        using (MySqlConnection conexion = BDComun.ObtenerCon())
                        {   //Se busca si existe un LS con esos datos
                            MySqlCommand buscar = new MySqlCommand("SELECT COUNT(*) FROM xLider_Sindical WHERE RFC = @RFC AND Contrasenha = @Contrasenha", conexion);
                            buscar.Parameters.AddWithValue("RFC", textBox1.Text);
                            buscar.Parameters.AddWithValue("Contrasenha", textBox2.Text);
                            buscar.CommandTimeout = 60;
                            Int64 num = (Int64)buscar.ExecuteScalar();
                            conexion.Close();// se cierra la conexion
                            if (num == 1)
                            {   //De ser así, se le permite acceder
                                MessageBox.Show("Bien. Ya puede administrar su línea de transportes");
                                this.Visible = false; //Se hace invisible esta forma
                                using (FormaB frmB = new FormaB(textBox1.Text))
                                {   //Se abre otra forma
                                    while (1 == 1)
                                        frmB.ShowDialog();
                                }
                            }
                            else
                                MessageBox.Show("Su nombre o su contraseña son incorrectos");
                        }
                    }
                }
                catch (Exception ex)
                { MessageBox.Show("Error en la conexión: " + ex.ToString()); } //Notifica de cualquier error
            }
            else
                MessageBox.Show("Debe llenar todos lo campos para poder acceder");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
