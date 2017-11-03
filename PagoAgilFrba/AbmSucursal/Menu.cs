﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Accedo a dar de alta a una sucursal
        private void button1_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmSucursal.Alta nuevaAlta = new PagoAgilFrba.AbmSucursal.Alta();
            this.Hide();
            nuevaAlta.Show();
        }


        // Accedo a dar de baja a una sucursal
        private void button2_Click(object sender, EventArgs e)
        {
            // 
            PagoAgilFrba.AbmSucursal.Baja nuevaAlta = new PagoAgilFrba.AbmSucursal.Baja();
            this.Hide();
            nuevaAlta.Show();
        }


        // Accedo a modificar una sucursal

        private void button3_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmSucursal.Modificar nuevaAlta = new PagoAgilFrba.AbmSucursal.Modificar();
            this.Hide();
            nuevaAlta.Show();

        }
    }
}
