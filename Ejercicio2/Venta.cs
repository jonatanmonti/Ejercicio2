using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    public class Venta
    {

        private Surtidor estacionVenta;

        public Surtidor EstacionVenta
        {
            get { return estacionVenta; }
            set { estacionVenta = value; }
        }

        private float totalestacion;

        public float TotalEstacion
        {
            get { return totalestacion; }
            set { totalestacion = value; }
        }

        private int cantEstacion;

        public int CantEstacion
        {
            get { return cantEstacion; }
            set { cantEstacion = value; }
        }

        private float totalSurtidor1;

        public float TotalSurtidor1
        {
            get { return totalSurtidor1; }
            set { totalSurtidor1 = value; }
        }

        private float totalSurtidor2;

        public float TotalSurtidor2
        {
            get { return totalSurtidor2; }
            set { totalSurtidor2 = value; }
        }

        private float totalSurtidor3;

        public float TotalSurtidor3
        {
            get { return totalSurtidor3; }
            set { totalSurtidor3 = value; }
        }


        public float CalcularTotal()
        {
            

            return totalestacion += cantEstacion * estacionVenta.Nafta.Precio; //calculamos el total de la estacion
        }

        public float CalcularTotalSurtidor1()
		{
            return totalSurtidor1 += CantEstacion * estacionVenta.Nafta.Precio; //calculamos el total del surtidor 1
        }

        public float CalcularTotalSurtidor2()
        {
            return totalSurtidor2 += CantEstacion * estacionVenta.Nafta.Precio; //calculamos el total del surtidor 2
        }

        public float CalcularTotalSurtidor3()
        {
            return totalSurtidor3 += CantEstacion * estacionVenta.Nafta.Precio; //calculamos el total del surtidor 3
        }

	}
}