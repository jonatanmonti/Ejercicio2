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

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i<=2; i++)
            {
                
                if(i == 0) {
                    Nafta nafta = new Nafta("normal", 17.20);
                    listBox1.Items.Add(nafta);
                    listBox1.DisplayMember = "Visualizar";
                }else if(i == 1)
                {
                    Nafta nafta = new Nafta("Super", 18.85);
                    listBox1.Items.Add(nafta);
                    listBox1.DisplayMember = "Visualizar";
                }
                else if(i == 2)
                {
                    Nafta nafta = new Nafta("Premium", 21.30);
                    listBox1.Items.Add(nafta);
                    listBox1.DisplayMember = "Visualizar";
                }
            }
        }
    }
}
