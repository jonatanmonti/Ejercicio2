using System;
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

        private int capacidad;

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        public Surtidor()
		{
			this.nombre = "";
			this.capacidad = 0;
            this.cantidad = 0;
		}

		/*public string CargarSurtidores()
		{
            
            for (int i = 0; i <= 2; i++)
            {

                if (i == 0)
                {
                    Nafta Nafta = new Nafta();
                    Nafta.Tipo = "Normal";
                    Nafta.Precio = 17.20;
                    Surtidor Surtidor = new Surtidor();
                    Surtidor.nombre = "Surtidor 1";
                    Surtidor.capacidad = 50;
                    Surtidor.cantidad = Surtidor.capacidad;
                    
                }
                else if (i == 1)
                {
                    Nafta Nafta = new Nafta();
                    Nafta.Tipo = "Super";
                    Nafta.Precio = 18.85;
                    Surtidor Surtidor = new Surtidor();
                    Surtidor.nombre = "Surtidor 2";
                    Surtidor.capacidad = 50;
                    Surtidor.cantidad = Surtidor.capacidad;
                    
                }
                else if (i == 2)
                {
                    Nafta Nafta = new Nafta();
                    Nafta.Tipo = "Premium";
                    Nafta.Precio = 21.30;
                    Surtidor Surtidor = new Surtidor();
                    Surtidor.nombre = "Surtidor 3";
                    Surtidor.capacidad = 50;
                    Surtidor.cantidad = Surtidor.capacidad;
                    
                }
            }
        }*/

    }
}