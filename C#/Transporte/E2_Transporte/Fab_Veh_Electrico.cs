using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Transporte
{
    class Fab_Veh_Electrico : IFabricaVehiculo
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

        public Fab_Veh_Electrico(float velocMax, float cargaMax)
        {
            VelocMax = velocMax;
            CargaMax = cargaMax;
        }

        public Calafias crearCalafia(string color, string chofer, float tarifa, float tarifa_est, string placa, int modelo, int capacidad)
        { return new CalafiaElectrica(color, chofer, tarifa, tarifa_est, placa, modelo, capacidad, velocMax, cargaMax); }

        public Camiones crearCamion(string color, string chofer, float tarifa, float tarifa_est, string pago, string placa, int modelo, int capacidad)
        { return new CamionElectrico(color, chofer, tarifa, tarifa_est, pago, placa, modelo, capacidad, velocMax, cargaMax); }

        public Taxis_de_Ruta crearTaxi(string color, string chofer, float tarifa, float costo_min, string placa, int modelo)
        { return new TaxiElectrico(color, chofer, tarifa, costo_min, placa, modelo, velocMax, cargaMax); }

        public Transporte_Priv crearTP(string color, string chofer, float tarifa, float costo_min, string placa, int modelo, int capacidad)
        { return new TPrivadoElectrico(color, chofer, tarifa, costo_min, placa, modelo, capacidad, velocMax, cargaMax); } 
    }
}
