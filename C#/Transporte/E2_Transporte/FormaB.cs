using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace E2_Transporte
{
    public partial class FormaB : Form
    {
        private string Identificador;
        private string linea;
        public FormaB(string ID)
        {
            InitializeComponent();
            this.Identificador = ID; //Para identificar al usuario
        }

        DataTable dt = new DataTable();
        MySqlDataAdapter da;

        private void FormaB_Load(object sender, EventArgs e)
        {
            try
            {   //Por si errores 
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   //Se insertan los LS disponibles
                    MySqlCommand revisar = new MySqlCommand("SELECT Categoria FROM xLinea WHERE ID_Lider =@ID_lider", conexion);
                    revisar.Parameters.AddWithValue("ID_Lider", this.Identificador);
                    revisar.CommandTimeout = 60; //Se toman los nombres de los lideres sindicales sin linea asignada
                    MySqlDataReader fk; //Para leer el resultado de la consulta
                    fk = revisar.ExecuteReader();
                    string pendiente = "";
                    if (fk.Read())
                        pendiente = fk[0].ToString();
                    conexion.Close();
                    //Se revisa si la linea del líder tiene un tipo de transporte asignado
                    if (pendiente == "Pendiente")
                    {
                        this.Visible = false;
                        using (FormaC frmC = new FormaC(Identificador))
                        { frmC.ShowDialog(); } //Se abre una forma (para asignar un tipo de transporte)
                    }
                }

                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   //Se pone el color que le corresponde
                    MySqlCommand revisar = new MySqlCommand("SELECT Color FROM xLinea WHERE ID_Lider =@ID_lider", conexion);
                    revisar.Parameters.AddWithValue("ID_Lider", this.Identificador);
                    revisar.CommandTimeout = 60; //Se toman los nombres de los lideres sindicales sin linea asignada
                    MySqlDataReader fk; //Para leer el resultado de la consulta
                    fk = revisar.ExecuteReader();
                    if (fk.Read())
                        linea = fk[0].ToString();
                    conexion.Close();
                    this.Text = "Línea de vehículos " + linea;
                }

                Actualizar_Tabla();
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
        }

        private void FormaB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {   //Actualiza la tabla
            Actualizar_Tabla();
        }

        public void Actualizar_Tabla()
        {
            using (MySqlConnection conexion = BDComun.ObtenerCon())
            {   //Aqui se llena la tabla
                dt = new DataTable();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                MySqlCommand db = new MySqlCommand("SELECT * FROM xVehiculo WHERE Color = (SELECT Color FROM xLinea WHERE ID_lider = @ID_lider)", conexion);
                db.Parameters.AddWithValue("ID_Lider", this.Identificador);
                da = new MySqlDataAdapter(db);
                da.Fill(dt);
                dataGridView1.DataSource = dt; //Se pasan los datos obtenidos al DatGridView
            }
        }

        private void AnadirV_Click(object sender, EventArgs e)
        {
            this.Visible = false; //Se hace invisible esta forma
            using (FormaD frmD = new FormaD(linea))
            {   //Se abre otra forma
                frmD.ShowDialog();
            }
        }

        private void ActualV_Click(object sender, EventArgs e)
        {
            try //Por si errores 
            {
                Int64 contador;
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {
                    //Primero se verifica la existencia de al menos un registro
                    MySqlCommand obtener = new MySqlCommand("SELECT COUNT(*) FROM xVehiculo WHERE Color = "
                    + "(SELECT Color FROM xLinea WHERE ID_lider = @ID_lider) AND Id = @Id", conexion);
                    obtener.Parameters.AddWithValue("ID_Lider", this.Identificador);
                    obtener.Parameters.AddWithValue("Id", textBox1.Text);
                    contador = (Int64)obtener.ExecuteScalar();
                    conexion.Close();
                }
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {
                    MySqlCommand obtener = new MySqlCommand("SELECT TipoMotor FROM xVehiculo WHERE Id = @Id", conexion);
                    obtener.Parameters.AddWithValue("Id", textBox1.Text);
                    MySqlDataReader fk; //Para leer el resultado de la consulta
                    fk = obtener.ExecuteReader();
                    string el_dato = "";
                    if (fk.Read())
                        el_dato = fk[0].ToString();
                    conexion.Close();

                    if (contador != 0)
                    {
                        //obtener = new MySqlCommand("SELECT * FROM xVehiculo WHERE Id = @Id", conexion);
                        if (el_dato == "Diesel")
                            obtener = new MySqlCommand("SELECT xVehiculo.*, VDiesel.* FROM xVehiculo JOIN VDiesel ON VDiesel.ID_Vehiculo = xVehiculo.Id WHERE xVehiculo.Id = @Id", conexion);
                        else if (el_dato == "Electrico")
                            obtener = new MySqlCommand("SELECT xVehiculo.*, VElectrico.* FROM xVehiculo JOIN VElectrico ON VElectrico.ID_Vehiculo = xVehiculo.Id WHERE xVehiculo.Id = @Id", conexion);
                        else if (el_dato == "Gasolina")
                            obtener = new MySqlCommand("SELECT xVehiculo.*, VGasolina.* FROM xVehiculo JOIN VGasolina ON VGasolina.ID_Vehiculo = xVehiculo.Id WHERE xVehiculo.Id = @Id", conexion);
                        else if (el_dato == "Hidrogeno")
                            obtener = new MySqlCommand("SELECT xVehiculo.*, VHidrogeno.* FROM xVehiculo JOIN VHidrogeno ON VHidrogeno.ID_Vehiculo = xVehiculo.Id WHERE xVehiculo.Id = @Id", conexion);
                        else
                            obtener = new MySqlCommand("SELECT xVehiculo.*, VHibrido.* FROM xVehiculo JOIN VHibrido ON VHibrido.ID_Vehiculo = xVehiculo.Id WHERE xVehiculo.Id = @Id", conexion);
                        obtener.Parameters.AddWithValue("Id", textBox1.Text);
                        using (FormaI frmI = new FormaI(obtener,int.Parse(textBox1.Text)))
                        {   //Se abre otra forma
                            this.Visible = false;
                            frmI.ShowDialog();
                        }
                    }
                    else
                        MessageBox.Show("No se encontro ningún vehículo con ese Id");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
        }
    }
}
