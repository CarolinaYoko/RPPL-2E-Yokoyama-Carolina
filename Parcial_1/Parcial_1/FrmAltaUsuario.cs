using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;

namespace PetShop
{
    public partial class FrmAltaUsuario : Form
    {
        public FrmAltaUsuario()
        {
            InitializeComponent();
            
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            this.cmbUsuario.DataSource = Enum.GetValues(typeof(EUsuarios));
            this.CambiarVistas();
        }

        protected virtual void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            double bono = 0;
            Usuario auxUsuario = null;

            if (!string.IsNullOrWhiteSpace(txtNickNombreUsuario.Text) &&
                                                !string.IsNullOrWhiteSpace(txtContraseniaUsuario.Text) &&
                                                !string.IsNullOrWhiteSpace(txtNombreUsuario.Text) &&
                                                !string.IsNullOrWhiteSpace(txtApellidoUsuario.Text) &&
                                                int.TryParse(txtDni.Text, out int dni) == true &&
                                                double.TryParse(txtSueldoUsuario.Text, out double sueldo) == true &&
                                                (!txtBonoAdmin.Visible || double.TryParse(txtBonoAdmin.Text, out bono)))
            {

                switch ((EUsuarios)cmbUsuario.SelectedItem)
                {
                    case EUsuarios.Empleado:

                        auxUsuario = new Empleado(txtNickNombreUsuario.Text,
                                                            txtContraseniaUsuario.Text,
                                                            txtNombreUsuario.Text,
                                                            txtApellidoUsuario.Text,
                                                            dni, sueldo);
                        break;

                    case EUsuarios.Administrador:

                        auxUsuario = new Administrador(txtNickNombreUsuario.Text,
                                                        txtContraseniaUsuario.Text,
                                                        txtNombreUsuario.Text,
                                                        txtApellidoUsuario.Text,
                                                        dni, sueldo, bono);
                        break;
                }
                Empleado.AgregarUsuario(auxUsuario);
                SystemSounds.Asterisk.Play();
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar o son valores no válidos");
                txtApellidoUsuario.Text = string.Empty;
                txtBonoAdmin.Text = string.Empty;
                txtContraseniaUsuario.Text = string.Empty;
                txtDni.Text = string.Empty;
                txtNickNombreUsuario.Text = string.Empty;
                txtNombreUsuario.Text = string.Empty;
                txtSueldoUsuario.Text = string.Empty;
            }
        }
        
        private void cmbUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            this.CambiarVistas();
        }

        private void btnCerrarEditarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cambia la vista según el tipo de usuario que se desea cargar
        /// </summary>
        private void CambiarVistas()
        {
            switch ((EUsuarios)cmbUsuario.SelectedItem)
            {
                case EUsuarios.Administrador:
                    txtBonoAdmin.Visible = true;
                    break;
                case EUsuarios.Empleado:
                    txtBonoAdmin.Visible = false;
                    break;
            }
        }

    }
}
