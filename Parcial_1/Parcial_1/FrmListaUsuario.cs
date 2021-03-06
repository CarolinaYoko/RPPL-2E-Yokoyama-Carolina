using System;
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
    public partial class FrmListaUsuario : Form
    {
        static Usuario usuarioSeleccion;
        public FrmListaUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Propiedad get del atributo usuarioSeleccion
        /// </summary>
        public static Usuario UsuarioSeleccion
        {
            get { return FrmListaUsuario.usuarioSeleccion; }           
        }

        /// <summary>
        /// Actualiza la informacion del DataGrid
        /// </summary>
        public void ActualizarDataGrid()
        {
            List<Usuario> auxLista = new List<Usuario>();

            switch ((EUsuarios)cmbTipo.SelectedItem)
            {
                case EUsuarios.Administrador:
                    auxLista = Administrador.FiltrarAdministradores();
                    break;
                case EUsuarios.Empleado:
                    auxLista = Empleado.FiltrarEmpleados();
                    break;
            }

            dgUsuario.DataSource = auxLista;
            dgUsuario.AutoGenerateColumns = true;
            dgUsuario.Columns["UsuarioActivo"].Visible = false;
            
            if (auxLista.Count > 0)
            {               
                dgUsuario.CurrentCell = dgUsuario.Rows[0].Cells[1];
                dgUsuario.Rows[0].Selected = true;

            }

            dgUsuario.Refresh();                        
        }


        /// <summary>
        /// Trae el dato seleccionado en el DataGrid
        /// </summary>
        private void SeleccionarDato()
        {
            int indiceFila = dgUsuario.CurrentRow is not null ? dgUsuario.CurrentRow.Index : -1;

            if (indiceFila >= 0)
            {
                DataGridViewRow fila = dgUsuario.Rows[indiceFila];
                int auxId = int.Parse(fila.Cells["IDUsuario"].Value.ToString());

                FrmListaUsuario.usuarioSeleccion = Empleado.BuscarEmpleadoPorId(auxId);
            }
            else
            {
                FrmListaUsuario.usuarioSeleccion = null;
            }

        }

        private void btnCerrarListaUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListaUsuario_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(EUsuarios));
            this.ActualizarDataGrid();
            this.SeleccionarDato();
        }

        private void FrmListaUsuario_Leave(object sender, EventArgs e)
        {
            this.SeleccionarDato();
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ActualizarDataGrid();
        }

        private void FrmListaUsuario_Activated(object sender, EventArgs e)
        {
            this.ActualizarDataGrid();
            this.SeleccionarDato();
            this.cmbTipo.DataSource = Enum.GetValues(typeof(EUsuarios));
        }


    }
}
