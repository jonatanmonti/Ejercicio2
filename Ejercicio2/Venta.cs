using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    public class Venta
    {

		private double totalestacion;

		public double TotalEstacion
		{
			get { return totalestacion; }
			set { totalestacion = value; }
		}

		private int cant;

		public int Cant
		{
			get { return cant; }
			set { cant = value; }
		}

		private Surtidor surtidorVenta;

		public Surtidor SurtidorVenta
		{
			get { return surtidorVenta; }
			set { surtidorVenta = value; }
		}

        public double CalcularTotal()
		{
			return totalestacion += cant * surtidorVenta.PrecioNaftaCargada;
		}

	}
}