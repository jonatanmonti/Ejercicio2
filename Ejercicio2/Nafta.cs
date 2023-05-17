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

		private float precio;

		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		public Nafta(string nombre, float precio)
		{
			this.tipo = nombre;
			this.precio = precio;
		}
    }
}