using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace E2_Transporte
{
    class CalafiaHidrogeno : Calafias 
    {
        float velocMax;
        int por_Eficiencia; 

        public float VelocMax
        {
            get { return velocMax; }
            set { velocMax = value; }
        }
        public int Por_Eficiencia 
        {
            get { return por_Eficiencia; }
            set { por_Eficiencia = value; }
        }

        public CalafiaHidrogeno(string color, string chofer, float tarifa, float tarifa_est, string placa, int modelo, int capacidad, float velocMax, int por_Eficiencia) : 
            base(color, chofer, tarifa, tarifa_est, placa, modelo, capacidad)
        {
            VelocMax = velocMax;
            Por_Eficiencia = por_Eficiencia;
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
                    MySqlCommand subir = new MySqlCommand("INSERT INTO VHidrogeno(VelocMax, Por_Eficiencia, ID_Vehiculo)"
                        + "VALUES(@VelocMax, @Por_Eficiencia, @ID_Vehiculo)", conexion);
                    subir.Parameters.AddWithValue("VelocMax", VelocMax);
                    subir.Parameters.AddWithValue("Por_Eficiencia", Por_Eficiencia);
                    subir.Parameters.AddWithValue("ID_Vehiculo", Id);
                    subir.CommandTimeout = 60;
                    subir.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Ha insertado exitosamente el registro de la calafia.\nColor: " + Color + "\nNombre del chofer: " +
                        Chofer + "\nModelo: " + Modelo + "\nPlaca: " + Placa + "\nTarifa: " + Tarifa + "\nMomento de pago: " + "Bajada" +
                         "\nCapacidad: " + Capacidad + "\nVelocidad máxima: " + VelocMax + "\nPorcentaje de eficiencia: " + Por_Eficiencia);
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
        }
    }
}
