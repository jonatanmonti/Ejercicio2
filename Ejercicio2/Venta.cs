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

		private int naftaCargar;

		public int NaftaCargar
		{
			get { return naftaCargar; }
			set { naftaCargar = value; }
		}

		private Surtidor surtidorVenta;

		public Surtidor SurtidorVenta
		{
			get { return surtidorVenta; }
			set { surtidorVenta = value; }
		}

		private Nafta naftaVenta;

		public Nafta NaftaVenta
		{
			get { return naftaVenta; }
			set { naftaVenta = value; }
		}

        


        public double CalcularTotal()
		{
			return totalestacion = naftaCargar * naftaVenta.Precio;
		}

	}
}