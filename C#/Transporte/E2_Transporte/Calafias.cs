using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace E2_Transporte
{
    public abstract class Calafias
    {
        protected string color;
        protected string chofer;
        protected float tarifa;
        protected float tarifa_est; //Cambiar en la BD
        protected string placa;
        protected int modelo;
        protected int capacidad;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Chofer
        {
            get { return chofer; }
            set { chofer = value; }
        }

        public float Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }

        public float Tarifa_est
        {
            get { return tarifa_est; }
            set { tarifa_est = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public int Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        public Calafias() { }
        public Calafias(string color, string chofer, float tarifa, float tarifa_est, string placa, int modelo, int capacidad)
        {
            Color = color;
            Chofer = chofer;
            Tarifa = tarifa;
            Tarifa_est = tarifa_est;
            Placa = placa;
            Modelo = modelo;
            Capacidad = capacidad;
        }

        public bool Inserta_Calafia(string Motor)
        {
            bool logro = false;
            try //Por si errores
            {
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   //Se insertan los datos del objeto en la BD
                    MySqlCommand subir = new MySqlCommand("INSERT INTO xVehiculo(Color, NombreChofer, TipoTrans, TipoMotor, Modelo, Placa, Tarifa, Costo_Min, Mom_Pago, Capacidad, Tarifa_est)"
                        + "VALUES(@Color, @NombreChofer, @TipoTrans, @TipoMotor, @Modelo, @Placa, @Tarifa, @Costo_Min, @Mom_Pago, @Capacidad, @Tarifa_est)", conexion);
                    subir.Parameters.AddWithValue("Color", Color);
                    subir.Parameters.AddWithValue("NombreChofer", Chofer);
                    subir.Parameters.AddWithValue("TipoTrans", "Calafia");
                    subir.Parameters.AddWithValue("TipoMotor", Motor);
                    subir.Parameters.AddWithValue("Modelo", Modelo);
                    subir.Parameters.AddWithValue("Placa", Placa);
                    subir.Parameters.AddWithValue("Tarifa", Tarifa);
                    subir.Parameters.AddWithValue("Costo_Min", 0);
                    subir.Parameters.AddWithValue("Mom_Pago", "Bajada");
                    subir.Parameters.AddWithValue("Capacidad", Capacidad);
                    subir.Parameters.AddWithValue("Tarifa_est", Tarifa_est);
                    subir.CommandTimeout = 60;
                    subir.ExecuteNonQuery();
                    logro = true;
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
            return logro;
        }

        public abstract void Insertar_en_BD();
            /*try //Por si errores
            {
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {
                    MySqlCommand obtener = new MySqlCommand("SELECT COUNT(*) FROM xLinea", conexion);
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }*/
    }
}
