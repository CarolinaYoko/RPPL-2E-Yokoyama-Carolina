﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace PetShop
{
    public partial class FrmFacturacion : Form
    {
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            lblRecaudacion.Text = Petshop.RecaudacionDelDia.ToString();
        }

        private void btnCerrarFacturacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
