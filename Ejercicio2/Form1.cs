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
            //creo el metodo para crear una nueva nafta

            Nafta Nafta = new Nafta(nombre,precio);
            estacion.Naftas.Add(Nafta);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //uso el metodo CrearNafta y le asignamos los valores

            CrearNafta("Normal", 17.20f);
            CrearNafta("Super", 18.85f);
            CrearNafta("Premium", 21.30f);

            //creo un for para cargar las 3 naftas a nuestra listbox

            for (int i = 0; i < 3; i++)
            {

                //creo un nuevo surtidor
                Surtidor Surtidor = new Surtidor("Surtidor " + (i + 1).ToString(), 50, estacion.Naftas[i], 50);
                //agrego el surtidor a nuestra listbox
                listBox1.Items.Add(Surtidor);
                //visualizo de forma correcta los datos en el listbox
                listBox1.DisplayMember = "Visualizar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creo una venta
            VentaActual = new Venta();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton para seleccionar la cantidad de litros que quiero cargar y calculo el total

            if (VentaActual != null) //valido si existe una venta
            {
                VentaActual.CantEstacion = int.Parse(maskedTextBox1.Text);
                VentaActual.EstacionVenta = (Surtidor)listBox1.SelectedItem;
                VentaActual.CalcularTotal();
                label1.Text = "Total estacion: " + VentaActual.TotalEstacion.ToString();

                if (listBox1.Items[0] == listBox1.SelectedItem) //if para indicar si el item seleccionado de la listbox es el primero
                {
                    VentaActual.CalcularTotalSurtidor1();
                    label2.Text = "Total surtidor 1: " + VentaActual.TotalSurtidor1.ToString(); //calculamos el total del surtidor 1
                } else if (listBox1.Items[1] == listBox1.SelectedItem) //if para indicar si el item seleccionado de la listbox es el segundo
                {
                    VentaActual.CalcularTotalSurtidor2(); //calculamos el total del surtidor 2
                    label3.Text = "Total surtidor 2: " + VentaActual.TotalSurtidor2.ToString();
                }
                else //caso contrario es el tercero
                {
                    VentaActual.CalcularTotalSurtidor3(); //calculamos el total del surtidor 3
                    label4.Text = "Total surtidor 3: " + VentaActual.TotalSurtidor3.ToString();
                }
            }
        }
    }
}
