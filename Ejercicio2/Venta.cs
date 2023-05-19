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

        private double totalestacion;

        public double TotalEstacion
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

        public double CalcularTotal()
        {
            return totalestacion += cantEstacion * estacionVenta.PrecioNaftaCargada;
        }

        public void CalcularTotalSurtidor()
		{
			
		}

	}
}