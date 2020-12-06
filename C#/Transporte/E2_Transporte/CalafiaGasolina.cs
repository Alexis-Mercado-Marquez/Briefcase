using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace E2_Transporte
{
    class CalafiaGasolina : Calafias
    {
        float velocMax;
        float capacLitros;
        int numCilindros;

        public float VelocMax
        {
            get { return velocMax; }
            set { velocMax = value; }
        }
        public float CapacLitros
        {
            get { return capacLitros; }
            set { capacLitros = value; }
        }
        public int NumCilindros
        {
            get { return numCilindros; }
            set { numCilindros = value; }
        }

        public CalafiaGasolina(string color, string chofer, float tarifa, float tarifa_est, string placa, int modelo, int capacidad, float velocMax, float capacLitros, int numCilindros) :
            base(color, chofer, tarifa, tarifa_est, placa, modelo, capacidad)
        {
            VelocMax = velocMax;
            CapacLitros = capacLitros;
            NumCilindros = numCilindros;
        }

        public override void Insertar_en_BD()
        {
            try //Por si errores
            {
                int Id = 0;
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   //Se busca el ID del vehículo
                    MySqlCommand subir = new MySqlCommand("SELECT MAX(ID) FROM xVehiculo", conexion);
                    subir.CommandTimeout = 60;
                    MySqlDataReader fk; //Para leer el resultado de la consulta
                    fk = subir.ExecuteReader();
                    if (fk.Read()) //Guarda el Id del ultimo registro insertado
                        Id = int.Parse(fk[0].ToString());
                }
                using (MySqlConnection conexion = BDComun.ObtenerCon())
                {   //Y se inserta el registro de su motor
                    MySqlCommand subir = new MySqlCommand("INSERT INTO VGasolina(VelocMax, CapacLitros, NumCilindros, ID_Vehiculo)"
                    + "VALUES(@VelocMax, @CapacLitros, @NumCilindros, @ID_Vehiculo)", conexion);
                    subir.Parameters.AddWithValue("VelocMax", VelocMax);
                    subir.Parameters.AddWithValue("CapacLitros", CapacLitros);
                    subir.Parameters.AddWithValue("NumCilindros", NumCilindros);
                    subir.Parameters.AddWithValue("ID_Vehiculo", Id);
                    subir.CommandTimeout = 60;
                    subir.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Ha insertado exitosamente el registro de la calafia.\nColor: " + Color + "\nNombre del chofer: " +
                        Chofer + "\nModelo: " + Modelo + "\nPlaca: " + Placa + "\nTarifa: " + Tarifa + "\nMomento de pago: " + "Bajada" +
                         "\nCapacidad: " + Capacidad + "\nVelocidad máxima: " + VelocMax + "\nLitros del tanque: " + CapacLitros + "\nCilindros: " + NumCilindros);
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
        }
    }
}
