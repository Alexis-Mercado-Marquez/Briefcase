using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Transporte
{
    class Fab_Veh_Diesel: IFabricaVehiculo
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

        public Fab_Veh_Diesel(float velocMax, float capacLitros, int numCilindros, bool bio) 
        {
            VelocMax = velocMax;
            CapacLitros = capacLitros;
            NumCilindros = numCilindros;
            Bio = bio;
        }

        public Calafias crearCalafia(string color, string chofer, float tarifa, float tarifa_est, string placa, int modelo, int capacidad)
        { return new CalafiaDiesel(color, chofer, tarifa, tarifa_est, placa, modelo, capacidad, velocMax, capacLitros, numCilindros, bio); }

        public Camiones crearCamion(string color, string chofer, float tarifa, float tarifa_est, string pago, string placa, int modelo, int capacidad)
        { return new CamionDiesel(color, chofer, tarifa, tarifa_est, pago, placa, modelo, capacidad, velocMax, capacLitros, numCilindros, bio); }

        public Taxis_de_Ruta crearTaxi(string color, string chofer, float tarifa, float costo_min, string placa, int modelo)
        { return new TaxiDiesel(color, chofer, tarifa, costo_min, placa, modelo, velocMax, capacLitros, numCilindros, bio); }

        public Transporte_Priv crearTP(string color, string chofer, float tarifa, float costo_min, string placa, int modelo, int capacidad)
        { return new TPrivadoDiesel(color, chofer, tarifa, costo_min, placa, modelo, capacidad, velocMax, capacLitros, numCilindros, bio); }
    }
}
