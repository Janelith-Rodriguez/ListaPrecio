﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPrecio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogintud_Click(object sender, EventArgs e)
        {
            int CantCaracteres = 0;
            CantCaracteres = txtString.Text.Length;

            lblResultado.Text = CantCaracteres.ToString();
        }

        private void btPrueba_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "pepe es un sobrenombre".Length.ToString();
        }

        private void btMayuscula_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtString.Text.ToUpper();
        }

        private void btMinuscula_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtString.Text.ToLower();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (txtString.Text.Contains(txtBuscado.Text))
            {
                lblResultado.Text = "SI";
            }
            else
            {
                lblResultado.Text = "NO";
            }
        }

        private void txtDeletrear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < txtString.Text.Length; i = i + 1)
            {
            lblResultado.Text = lblResultado.Text + txtString.Text.Substring(i,1) + "\r\n";
            }
        }
    }
}
