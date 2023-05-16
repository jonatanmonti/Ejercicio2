﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {

        private Venta VentaActual = null;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i<=2; i++)
            {
                
                if(i == 0) {
                    Nafta Nafta = new Nafta();
                    Nafta.Tipo = "Normal";
                    Nafta.Precio = 17.20;
                    Surtidor Surtidor = new Surtidor();
                    Surtidor.Nombre = "Surtidor 1";
                    Surtidor.Capacidad = 50;
                    listBox1.Items.Add(Nafta);
                    listBox1.DisplayMember = "VisualizarSurtidor";
                }else if(i == 1)
                {
                    Nafta Nafta = new Nafta();
                    Nafta.Tipo = "Super";
                    Nafta.Precio = 18.85;
                    Surtidor Surtidor = new Surtidor();
                    Surtidor.Nombre = "Surtidor 2";
                    Surtidor.Capacidad = 50;
                    listBox1.Items.Add(Nafta);
                    listBox1.DisplayMember = "VisualizarSurtidor";
                }
                else if(i == 2)
                {
                    Nafta Nafta = new Nafta();
                    Nafta.Tipo = "Premium";
                    Nafta.Precio = 21.30;
                    Surtidor Surtidor = new Surtidor();
                    Surtidor.Nombre = "Surtidor 3";
                    Surtidor.Capacidad = 50;
                    listBox1.Items.Add(Nafta);
                    listBox1.DisplayMember = "VisualizarSurtidor";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaActual = new Venta();

            VentaActual.NaftaCargar = int.Parse(maskedTextBox1.Text);
            VentaActual.NaftaVenta = (Nafta)listBox1.SelectedItem;
            label1.Text = "Total estacion: " + VentaActual.TotalEstacion.ToString();
        }
    }
}
