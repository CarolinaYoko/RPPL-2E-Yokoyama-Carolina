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

        /// <summary>
        /// Muestra en textbox el próximo envío en la cola
        /// </summary>
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

        /// <summary>
        ///  Actualiza la Cola de ventas
        /// </summary>
        private void RefrescarCola()
        {
            lvVentasEspera.Clear();
            
            lvVentasEspera.SmallImageList = imgList;
            lvVentasEspera.View = View.Details;
            
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

                new_item.SubItems.Add(venta.NumeroOperacion.ToString());
                new_item.SubItems.Add(venta.Cliente.Nombre.ToString());
                new_item.SubItems.Add(venta.CantidadDeProductos.ToString());
                new_item.SubItems.Add(venta.PesoTotal.ToString());

            }
        }

        /// <summary>
        /// Actualiza la pila de los envíos realizados
        /// </summary>
        private void RefrescarPila()
        {
            lvVentasEnviadas.Clear();

            lvVentasEnviadas.SmallImageList = imgList;
            lvVentasEnviadas.View = View.Details;
           
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

                new_item.SubItems.Add(venta.NumeroOperacion.ToString());
                new_item.SubItems.Add(venta.Cliente.Nombre.ToString());
                new_item.SubItems.Add(venta.CantidadDeProductos.ToString());
                new_item.SubItems.Add(venta.PesoTotal.ToString());

            }
        }

       
    }
}
