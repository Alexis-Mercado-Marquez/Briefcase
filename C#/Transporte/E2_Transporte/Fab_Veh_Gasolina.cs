using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Transporte
{
    class Fab_Veh_Gasolina: IFabricaVehiculo
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

        public Fab_Veh_Gasolina(float velocMax, float capacLitros, int numCilindros) 
        {
            VelocMax = velocMax;
            CapacLitros = capacLitros;
            NumCilindros = numCilindros;
        }

        public Calafias crearCalafia(string color, string chofer, float tarifa, float tarifa_est, string placa, int modelo, int capacidad)
        { return new CalafiaGasolina(color, chofer, tarifa, tarifa_est, placa, modelo, capacidad, velocMax, capacLitros, numCilindros); }

        public Camiones crearCamion(string color, string chofer, float tarifa, float tarifa_est, string pago, string placa, int modelo, int capacidad)
        { return new CamionGasolina(color, chofer, tarifa, tarifa_est, pago, placa, modelo, capacidad, velocMax, capacLitros, numCilindros); }

        public Taxis_de_Ruta crearTaxi(string color, string chofer, float tarifa, float costo_min, string placa, int modelo)
        { return new TaxiGasolina(color, chofer, tarifa, costo_min, placa, modelo, velocMax, capacLitros, numCilindros); }

        public Transporte_Priv crearTP(string color, string chofer, float tarifa, float costo_min, string placa, int modelo, int capacidad)
        { return new TPrivadoGasolina(color, chofer, tarifa, costo_min, placa, modelo, capacidad, velocMax, capacLitros, numCilindros); }
    }
}
