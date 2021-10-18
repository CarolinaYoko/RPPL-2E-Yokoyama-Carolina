using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PetShop
{
    public partial class FrmEditarCliente : FrmAltaCliente
    {
        Cliente cliente;

        public FrmEditarCliente(Cliente auxCliente)
        {
            InitializeComponent();
            this.cliente = auxCliente;
        }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            this.btnRegistrarAlta.Text = "Editar";
            txtNombreAlta.Text = cliente.Nombre;
            txtApellidoAlta.Text = cliente.Apellido;
            txtTelefonoAlta.Text = cliente.Telefono.ToString();
            txtSaldoAlta.Text = cliente.Saldo.ToString();
        }        

        private void txtNombreAlta_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreAlta.Text) && !Petshop.HayUnNumero(txtNombreAlta.Text))
            {
                this.cliente.Nombre = txtNombreAlta.Text;
            }
            else
            {
                txtNombreAlta.Text = this.cliente.Nombre;
                MessageBox.Show("Debe completar sin espacios y con letras.");
            }
        }        
        
        private void txtApellidoAlta_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtApellidoAlta.Text) && !Petshop.HayUnNumero(txtApellidoAlta.Text))
            {
                this.cliente.Nombre = txtApellidoAlta.Text;
            }
            else
            {
                txtApellidoAlta.Text = this.cliente.Apellido;
                MessageBox.Show("Debe completar sin espacios y con letras.");
            }
        }
       
        private void txtTelefonoAlta_Validating(object sender, CancelEventArgs e)
        {
            long telefono;
            if (long.TryParse(txtTelefonoAlta.Text, out telefono))
            {
                this.cliente.Telefono = telefono;
            }
            else
            {
                txtTelefonoAlta.Text = this.cliente.Telefono.ToString();
                MessageBox.Show("Número de teléfono inválido. Debe completar el campo con valores numéricos");
            }
        }
       
        private void txtSaldoAlta_Validating(object sender, CancelEventArgs e)
        {
            float saldo;
            if (float.TryParse(txtSaldoAlta.Text, out saldo))
            {
                this.cliente.Saldo = saldo;
            }
            else
            {
                txtSaldoAlta.Text = this.cliente.Saldo.ToString();
                MessageBox.Show("Importe inválido. Debe completar el campo con valores numéricos");
            }
        }

        protected override void btnRegistrarAlta_Click(object sender, EventArgs e)
        {
            Cliente.EditarCliente(cliente);
            this.Close();
        }



    }
}
