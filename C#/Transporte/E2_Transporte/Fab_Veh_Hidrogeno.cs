using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Transporte
{
    class Fab_Veh_Hidrogeno: IFabricaVehiculo
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

        public Fab_Veh_Hidrogeno(float velocMax, int por_Eficiencia)
        {
            VelocMax = velocMax;
            Por_Eficiencia = por_Eficiencia;
        }


        public Calafias crearCalafia(string color, string chofer, float tarifa, float tarifa_est, string placa, int modelo, int capacidad)
        { return new CalafiaHidrogeno(color, chofer, tarifa, tarifa_est, placa, modelo, capacidad, velocMax, por_Eficiencia); }

        public Camiones crearCamion(string color, string chofer, float tarifa, float tarifa_est, string pago, string placa, int modelo, int capacidad)
        { return new CamionHidrogeno(color, chofer, tarifa, tarifa_est, pago, placa, modelo, capacidad, velocMax, por_Eficiencia); }

        public Taxis_de_Ruta crearTaxi(string color, string chofer, float tarifa, float costo_min, string placa, int modelo)
        { return new TaxiHidrogeno(color, chofer, tarifa, costo_min, placa, modelo, velocMax, por_Eficiencia); }

        public Transporte_Priv crearTP(string color, string chofer, float tarifa, float costo_min, string placa, int modelo, int capacidad)
        { return new TPrivadoHidrogeno(color, chofer, tarifa, costo_min, placa, modelo, capacidad, velocMax, por_Eficiencia); }
    }
}
