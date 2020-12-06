using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace E2_Transporte
{
    class TPrivadoDiesel : Transporte_Priv
    {
        float velocMax;
        float capacLitros;
        int numCilindros;
        bool bio;

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
        public bool Bio
        {
            get { return bio; }
            set { bio = value; }
        }

        public TPrivadoDiesel(string color, string chofer, float tarifa, float costo_min, string placa, int modelo, int capacidad, float velocMax, float capacLitros, int numCilindros, bool bio) : 
            base(color, chofer, tarifa, costo_min, placa, modelo, capacidad)
        {
            VelocMax = velocMax;
            CapacLitros = capacLitros;
            NumCilindros = numCilindros;
            Bio = bio;
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
                    MySqlCommand subir = new MySqlCommand("INSERT INTO VDiesel(VelocMax, CapacLitros, NumCilindros, Bio, ID_Vehiculo)"
                        + "VALUES(@VelocMax, @CapacLitros, @NumCilindros, @Bio, @ID_Vehiculo)", conexion);
                    subir.Parameters.AddWithValue("VelocMax", VelocMax);
                    subir.Parameters.AddWithValue("CapacLitros", CapacLitros);
                    subir.Parameters.AddWithValue("NumCilindros", NumCilindros);
                    subir.Parameters.AddWithValue("Bio", Bio);
                    subir.Parameters.AddWithValue("ID_Vehiculo", Id);
                    subir.CommandTimeout = 60;
                    subir.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Ha insertado exitosamente el registro del transporte privado a diesel");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error en la conexión: " + ex.ToString()); }
        }
    }
}
