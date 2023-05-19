using System;
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
        EstacionServicio estacion = new EstacionServicio();
        public Form1()
        {
            InitializeComponent();
        }

        void CrearNafta(string nombre, float precio)
        {
            Nafta Nafta = new Nafta(nombre,precio);
            estacion.Naftas.Add(Nafta);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CrearNafta("Normal", 17.20f);
            CrearNafta("Super", 18.85f);
            CrearNafta("Premium", 21.30f);

            for (int i = 0; i < 3; i++)
            {
                Surtidor Surtidor = new Surtidor("Surtidor " + (i + 1).ToString(), 50, estacion.Naftas[i], 50);
                listBox1.Items.Add(Surtidor);
                listBox1.DisplayMember = "Visualizar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaActual = new Venta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (VentaActual != null)
            {
                VentaActual.Cant = int.Parse(maskedTextBox1.Text);
                VentaActual.SurtidorVenta = (Surtidor)listBox1.SelectedItem;
                VentaActual.CalcularTotal();
                label1.Text = "Total estacion: " + VentaActual.TotalEstacion.ToString();
            }
        }
    }
}
