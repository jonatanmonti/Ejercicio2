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

        private float totalSurtidor;

        public float TotalSurtidor
        {
            get { return totalSurtidor; }
            set { totalSurtidor = value; }
        }

        private int cantSurtidor;

        public int CantSurtidor
        {
            get { return cantSurtidor; }
            set { cantSurtidor = value; }
        }

        public float CalcularTotal()
        {
            

            return totalestacion += cantEstacion * estacionVenta.Nafta.Precio;
        }

        public float CalcularTotalSurtidor()
		{
            return totalSurtidor += cantSurtidor * estacionVenta.Nafta.Precio;
		}

	}
}