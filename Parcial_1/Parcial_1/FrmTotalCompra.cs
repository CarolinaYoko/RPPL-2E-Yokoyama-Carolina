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
    public partial class FrmTotalCompra : Form
    {
        Cliente cliente;

        public FrmTotalCompra(Cliente auxCliente)
        {
            InitializeComponent();
            cliente = auxCliente;

        }

        private void FrmTotalCompra_Load(object sender, EventArgs e)
        {
            string tipo;
            double precioPorKM;
            double totalEnvio;
            double totalFinal;

            precioPorKM = Envios.DeterminarTransporte(Caja.PesoTotalDeCompra(), Caja.CantidadDeProductosComprados(), out tipo);

            totalEnvio = precioPorKM * cliente.Distancia;

            totalFinal = totalEnvio + Caja.PrecioTotalDeCompra();

            lblCompraNumero.Text = Caja.PrecioTotalDeCompra().ToString();
            lblTotalNumero.Text = totalFinal.ToString();
            lblEnvioNumero.Text = totalEnvio.ToString();
            lblTransporte.Text = tipo;            
           
            this.LlenarTabla();

        }

        private void LlenarTabla()
        {
            foreach (KeyValuePair<Producto, int> item in Caja.ListaProductosComprados)
            {
                dgDetalleDeCompra.Rows.Add(item.Key.nombre, item.Key.descripcion, item.Key.precio, item.Value, item.Key.precio * item.Value);

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Caja.ListaProductosComprados.Clear();
            this.Close();

        }
    }
}
