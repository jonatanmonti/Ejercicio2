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
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i<=2; i++)
            {
                
                if(i == 0) {
                    Nafta Nafta = new Nafta("Normal",17.20);
                    Surtidor Surtidor = new Surtidor("Surtidor 1", 50, Nafta.Tipo,Nafta.Precio,50);
                    listBox1.Items.Add(Surtidor);
                    listBox1.DisplayMember = "Visualizar";
                }else if(i == 1)
                {
                    Nafta Nafta = new Nafta("Super",18.85);
                    Surtidor Surtidor = new Surtidor("Surtidor 2", 50, Nafta.Tipo, Nafta.Precio, 50);
                    listBox1.Items.Add(Surtidor);
                    listBox1.DisplayMember = "Visualizar";
                }
                else if(i == 2)
                {
                    Nafta Nafta = new Nafta("Premium",21.30);
                    Surtidor Surtidor = new Surtidor("Surtidor 3", 50, Nafta.Tipo, Nafta.Precio, 50);
                    listBox1.Items.Add(Surtidor);
                    listBox1.DisplayMember = "Visualizar";
                }
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
