using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Transporte
{
    interface IFabricaVehiculo
    {   
        Calafias crearCalafia(string color, string chofer, float tarifa, float tarifa_est, string placa, int modelo, int capacidad);
        Camiones crearCamion(string color, string chofer, float tarifa, float tarifa_est, string pago, string placa, int modelo, int capacidad);
        Taxis_de_Ruta crearTaxi(string color, string chofer, float tarifa, float costo_min, string placa, int modelo);
        Transporte_Priv crearTP(string color, string chofer, float tarifa, float costo_min, string placa, int modelo, int capacidad);
    }
}
