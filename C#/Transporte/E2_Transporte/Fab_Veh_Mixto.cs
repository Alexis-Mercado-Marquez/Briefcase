using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Transporte
{
    class Fab_Veh_Mixto: IFabricaVehiculo
    {
        float velocMax;
        float capacLitros;
        int numCilindros;
        float cargaMax;

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
        public float CargaMax
        {
            get { return cargaMax; }
            set { cargaMax = value; }
        }

        public Fab_Veh_Mixto(float velocMax, float capacLitros, int numCilindros, float cargaMax) 
        {
            VelocMax = velocMax;
            CapacLitros = capacLitros;
            NumCilindros = numCilindros;
            CargaMax = cargaMax;
        }

        public Calafias crearCalafia(string color, string chofer, float tarifa, float tarifa_est, string placa, int modelo, int capacidad)
        { return new CalafiaMixta(color, chofer, tarifa, tarifa_est, placa, modelo, capacidad, velocMax, capacLitros, numCilindros, cargaMax); }

        public Camiones crearCamion(string color, string chofer, float tarifa, float tarifa_est, string pago, string placa, int modelo, int capacidad)
        { return new CamionMixto(color, chofer, tarifa, tarifa_est, pago, placa, modelo, capacidad, velocMax, capacLitros, numCilindros, cargaMax); }

        public Taxis_de_Ruta crearTaxi(string color, string chofer, float tarifa, float costo_min, string placa, int modelo)
        { return new TaxiMixto(color, chofer, tarifa, costo_min, placa, modelo, velocMax, capacLitros, numCilindros, cargaMax); }

        public Transporte_Priv crearTP(string color, string chofer, float tarifa, float costo_min, string placa, int modelo, int capacidad)
        { return new TPrivadoMixto(color, chofer, tarifa, costo_min, placa, modelo, capacidad, velocMax, capacLitros, numCilindros, cargaMax); }
    }
}
