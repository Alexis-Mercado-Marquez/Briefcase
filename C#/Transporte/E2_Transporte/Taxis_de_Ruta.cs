using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace E2_Transporte
{
    public abstract class Taxis_de_Ruta
    {
        protected string color;
        protected string chofer;
        protected float tarifa;
        protected float costo_min;
        protected string placa;
        protected int modelo;

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

        public float Costo_Min 
        {
            get { return costo_min; }
            set { costo_min = value; }
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

        public Taxis_de_Ruta() { }
        public Taxis_de_Ruta(string color, string chofer, float tarifa, float costo_min, string placa, int modelo)
        {
            Color = color;
            Chofer = chofer;
            Tarifa = tarifa;
            Costo_Min = costo_min;
            Placa = placa;
            Modelo = modelo;
        }

        public bool Inserta_Taxi(string Motor) 
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
                    subir.Parameters.AddWithValue("TipoTrans", "Taxi");
                    subir.Parameters.AddWithValue("TipoMotor", Motor);
                    subir.Parameters.AddWithValue("Modelo", Modelo);
                    subir.Parameters.AddWithValue("Placa", Placa);
                    subir.Parameters.AddWithValue("Tarifa", Tarifa);
                    subir.Parameters.AddWithValue("Costo_Min", Costo_Min);
                    subir.Parameters.AddWithValue("Mom_Pago", "Bajada");
                    subir.Parameters.AddWithValue("Capacidad", 9);
                    subir.Parameters.AddWithValue("Tarifa_est", null);
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
    }
}
