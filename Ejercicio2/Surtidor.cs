﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

		private int cantidad;

		public int Cantidad
		{
			get { return cantidad; }
			set {

				if (cantidad <= 0)
				{
					cantidad = 0;
				}
				else
				{
                    cantidad = value;
                }
            }
		}

        private string nombreNaftaCargada;

        public string NombreNaftaCargada
        {
            get { return nombreNaftaCargada; }
            set { nombreNaftaCargada = value; }
        }

        private double precioNaftaCargada;

        public double PrecioNaftaCargada
        {
            get { return precioNaftaCargada; }
            set { precioNaftaCargada = value; }
        }

        private int capacidad;

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        public Surtidor(string nombre, int cantidad, string nombreNaftaCargada,double precioNaftaCargada,int capacidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.nombreNaftaCargada=nombreNaftaCargada;
            this.precioNaftaCargada = precioNaftaCargada;
            this.capacidad = capacidad;
        }

        public string Visualizar
        {
            get { return Nombre + ": " + nombreNaftaCargada + " $ " + precioNaftaCargada; }
        }
    }
}