﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        //prueba3
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        //Prueba.
            double sueldo = Double.Parse(txtSueldo.Text);
            double renta;
            txtRenta.Text = "";
            if (sueldo <= 325)
            {
                renta = 0;
            }
            else if (sueldo <= 700)
            {
                renta = sueldo * 0.15;
            }
            else if (sueldo <= 1100)
            {
                renta = sueldo * 0.17;
            }
            else if (sueldo <= 2000)
            {
                renta = sueldo * 0.21;
            }
            else if (sueldo <= 2900)
            {
                renta = sueldo * 0.25;
            }
            else
            {
                renta = sueldo * 0.29;
            }
            txtRenta.Text = renta.ToString();
            MessageBox.Show("Total a pagar Renta: " + renta, "Salida", MessageBoxButtons.OK);

        }
    }
}
