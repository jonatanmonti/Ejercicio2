using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    public class Surtidor
    {
		
		
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private int capacidad;

		public int Capacidad
		{
			get { return capacidad; }
			set {

				if (capacidad <= 0)
				{
					capacidad = 0;
				}
				else
				{
                    capacidad = value;
                }
            }
		}

	}
}