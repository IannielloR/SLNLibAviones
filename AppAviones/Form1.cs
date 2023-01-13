using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibAviones.Models;

namespace AppAviones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            AvionComercial avionComercial = new AvionComercial("Pepe", "Jose", "Juanita", 200, "Aerolineas");

            MessageBox.Show(avionComercial.Mostrar());
            
        }
    }
}


