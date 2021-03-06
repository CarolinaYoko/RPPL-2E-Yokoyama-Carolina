using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FrmListaProductos : Form
    {
        public FrmListaProductos()
        {
            InitializeComponent();
        }

        private void FrmoListaProductos_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Producto, int> item in Petshop.ListaProductos)
            {
                dgProductos.Rows.Add(item.Key.tipoDeProducto, item.Key.nombre, item.Key.descripcion, item.Key.precio, item.Key.peso, item.Value);
            }
        }

        private void btnCerrarListaProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            ExportarCSV(dgProductos, "ListaDeProductos.csv");
            MessageBox.Show("Archivo CSV generado con éxito en carpeta Parcial_1/bin/Debug/net5.0-windows");
        }

        /// <summary>
        /// Crea un archivo CSV
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="archivo"></param>
        public void ExportarCSV(DataGridView dg, string archivo)
        {            
            if (dg.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(archivo);

                for (int i = 0; i <= dg.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        swOut.Write(",");
                    }
                    swOut.Write(dg.Columns[i].HeaderText);
                }

                swOut.WriteLine();
                               
                for (int j = 0; j <= dg.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }

                    dr = dg.Rows[j];

                    for (int i = 0; i <= dg.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }

                        value = dr.Cells[i].Value.ToString();                        
                        value = value.Replace(',', ' ');                        
                        value = value.Replace(Environment.NewLine, " ");
                        swOut.Write(value);
                    }
                }
                swOut.Close();
            }
        }

    }
}
