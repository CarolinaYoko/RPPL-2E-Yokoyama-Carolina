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
    public partial class FrmColaDeVentas : Form
    {



        public FrmColaDeVentas()
        {
            InitializeComponent();
        }

        private void btnCerrarColaVentas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmColaDeVentas_Load(object sender, EventArgs e)
        {
            this.RecargarTextBox();

            this.RefrescarCola();

            this.RefrescarPila();

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (Petshop.ColaVentas.Count > 0)
            {
                Venta auxVenta = Petshop.ColaVentas.Dequeue();
                Petshop.PilaVentasEnviadas.Push(auxVenta);
                this.RefrescarPila();
                this.RefrescarCola();
            }
            this.RecargarTextBox();

        }

        private void RecargarTextBox()
        {
            if (Petshop.ColaVentas.Count > 0)
            {
                txtVentaEnProceso.Text = Petshop.ColaVentas.Peek().NumeroOperacion.ToString() + " - " + Petshop.ColaVentas.Peek().Cliente.Nombre;
            }
            else
            {
                txtVentaEnProceso.Text = " ";
            }
        }


        private void RefrescarCola()
        {
            lvVentasEspera.Clear();

            // Set to details view.
            lvVentasEspera.SmallImageList = imgList;
            lvVentasEspera.View = View.Details;
            // Add a column with width 20 and left alignment.
            lvVentasEspera.Columns.Add("Estado", 20, HorizontalAlignment.Left);
            lvVentasEspera.Columns.Add("Número de operación", 20, HorizontalAlignment.Left);
            lvVentasEspera.Columns.Add("Cliente", 20, HorizontalAlignment.Left);
            lvVentasEspera.Columns.Add("Cantidad de productos", 20, HorizontalAlignment.Left);
            lvVentasEspera.Columns.Add("Peso total", 20, HorizontalAlignment.Left);

            lvVentasEspera.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvVentasEspera.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (Venta venta in Petshop.ColaVentas)
            {

                ListViewItem new_item = lvVentasEspera.Items.Add("En proceso", 0);

                // Set the item's image index.

                new_item.SubItems.Add(venta.NumeroOperacion.ToString());
                new_item.SubItems.Add(venta.Cliente.Nombre.ToString());
                new_item.SubItems.Add(venta.CantidadDeProductos.ToString());
                new_item.SubItems.Add(venta.PesoTotal.ToString());


            }
        }

        private void RefrescarPila()
        {
            lvVentasEnviadas.Clear();

            // PILA DE ENVIADOS

            lvVentasEnviadas.SmallImageList = imgList;
            lvVentasEnviadas.View = View.Details;
            // Add a column with width 20 and left alignment.
            lvVentasEnviadas.Columns.Add("Estado", 20, HorizontalAlignment.Left);
            lvVentasEnviadas.Columns.Add("Número de operación", 20, HorizontalAlignment.Left);
            lvVentasEnviadas.Columns.Add("Cliente", 20, HorizontalAlignment.Left);
            lvVentasEnviadas.Columns.Add("Cantidad de productos", 20, HorizontalAlignment.Left);
            lvVentasEnviadas.Columns.Add("Peso total", 20, HorizontalAlignment.Left);

            lvVentasEnviadas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvVentasEnviadas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (Venta venta in Petshop.PilaVentasEnviadas)
            {
                ListViewItem new_item = lvVentasEnviadas.Items.Add("Enviado", 1);

                // Set the item's image index.

                new_item.SubItems.Add(venta.NumeroOperacion.ToString());
                new_item.SubItems.Add(venta.Cliente.Nombre.ToString());
                new_item.SubItems.Add(venta.CantidadDeProductos.ToString());
                new_item.SubItems.Add(venta.PesoTotal.ToString());

            }
        }

       
    }
}
