﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class RecepcionesCompras : Form
    {
        public RecepcionesCompras()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formulario = new AgregarRecepcionesCompras();
            formulario.ShowDialog();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formulario = new Modificar_RecepcionesCompras();
            formulario.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formulario = new EliminarRecepcionesCompras();
            formulario.ShowDialog();
        }
    }
}
