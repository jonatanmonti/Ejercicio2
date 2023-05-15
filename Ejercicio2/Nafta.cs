using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
	public class Nafta
	{

		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}


		private double precio;

		public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		public Nafta(string Tipo, double Precio)
		{
			this.Tipo = Tipo;
			this.Precio = Precio;
		}

		public string Visualizar
		{
			get { return Tipo + " $" + Precio.ToString(); }
		}
	}
}