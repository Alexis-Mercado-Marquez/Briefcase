using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace E2_Transporte
{
    class CamionElectrico : Camiones
    {
        float velocMax;
        float cargaMax;

        public float VelocMax
        {
            get { return velocMax; }
            set { velocMax = value; }
        }
        public float CargaMax
        {
            get { return cargaMax; }
            set { cargaMax = value; }
        }

        public CamionElectrico(string color, string chofer, float tarifa, float tarifa_est, string pago, string placa, int modelo, int capacidad, float velocMax, float cargaMax) : 
            base(color, chofer, tarifa, tarifa_est, pago, placa, modelo, capacidad)
        {
            VelocMax = velocMax;
            CargaMax = cargaMax;
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
                    MySqlCommand subir = new MySqlCommand("INSERT INTO VElectrico(VelocMax, CargaMax, ID_Vehiculo)"
                        + "VALUES(@VelocMax, @CargaMax, @ID_Vehiculo)", conexion);
                    subir.Parameters.AddWithValue("VelocMax", VelocMax);
                    subir.Parameters.AddWithValue("CargaMax", CargaMax);
                    subir.Parameters.AddWithValue("ID_Vehiculo", Id);
                    subir.CommandTimeout = 60;
                    subir.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Ha insertado exitosamente el registro del camion eléctrico");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
        }
    }
}
