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
        double totalEnvio;
        double totalFinal;

        public FrmTotalCompra(Cliente auxCliente)
        {
            InitializeComponent();
            cliente = auxCliente;

        }

        private void FrmTotalCompra_Load(object sender, EventArgs e)
        {
            string tipo;
            double precioPorKM;

            precioPorKM = Envios.DeterminarTransporte(Caja.PesoTotalDeCompra(), Caja.CantidadDeProductosComprados(), out tipo);

            this.totalEnvio = precioPorKM * cliente.Distancia;

            this.totalFinal = this.totalEnvio + Caja.PrecioTotalDeCompra();

            lblCompraNumero.Text = Caja.PrecioTotalDeCompra().ToString();
            lblTotalNumero.Text = this.totalFinal.ToString();
            lblEnvioNumero.Text = this.totalEnvio.ToString();
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

        private void btnImprimirTicket_Click(object sender, EventArgs e)
        {
            Caja.ExportarTicketTxt(Venta.DetalleVenta(this.cliente, this.totalFinal, this.totalEnvio));
            MessageBox.Show("Ticket generado con éxito en carpeta souce...");
        }
    }
}
