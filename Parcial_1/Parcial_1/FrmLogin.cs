using Entidades;
using PetShop; // Ver por qué hay que usar ese using a pesar de estar en el mismo proyecto
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario auxUsuario = Usuario.ValidarUsuario(txtUsuario.Text, txtPassword.Text);

                FrmMenuPrincipal FormApp = new FrmMenuPrincipal(auxUsuario);
                FormApp.Show();
                this.Hide();
                

            }
            catch (UsuarioInvalidoException usuarioEx)
            {
                this.txtUsuario.Text = string.Empty;
                this.txtPassword.Text = string.Empty;
                MessageBox.Show(usuarioEx.Message);
            }

        }

        private void lblAdministrador_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.txtUsuario.Text = Petshop.ListaUsuarios[3].NickNombreUsuario;
            this.txtPassword.Text = Petshop.ListaUsuarios[3].Contrasenia;
        }

        private void lblEmpleado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.txtUsuario.Text = Petshop.ListaUsuarios[0].NickNombreUsuario;
            this.txtPassword.Text = Petshop.ListaUsuarios[0].Contrasenia;
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
