using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        static int ultimaOperacion;
        Cliente cliente;
        int cantidad;
        double peso;
        int numeroOperacion;


        /// <summary>
        /// Inicializa el ID autoincremental del cliente en 0
        /// </summary>
        static Venta()
        {
            Venta.ultimaOperacion = 0;
        }

        /// <summary>
        /// Construye un cliente a partir del cliente, cantidad de productos y peso total de compra
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="cantidadProductos"></param>
        /// <param name="pesoTotal"></param>
        public Venta(Cliente cliente, int cantidadProductos, double pesoTotal)
        {
            this.cliente = cliente;
            this.cantidad = cantidadProductos;
            this.peso = pesoTotal;
            this.numeroOperacion = ultimaOperacion;
            Venta.ultimaOperacion++;
        }

        /// <summary>
        /// Propiedad con get y set del atributo numero de operacion
        /// </summary>
        public int NumeroOperacion
        {
            get { return this.numeroOperacion; }            
        }

        /// <summary>
        /// Propiedad con get y set del atributo Cliente
        /// </summary>
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }

        /// <summary>
        /// Propiedad con get y set del atributo cantidad de productos
        /// </summary>
        public int CantidadDeProductos
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        /// <summary>
        /// Propiedad con get y set del atributo peso total de la compra
        /// </summary>
        public double PesoTotal
        {
            get { return this.peso; }
            set { this.peso = value; }
        }

        /// <summary>
        /// Genera el detalle de la compra realizada con los datos 
        /// del cliente y montos parciales y finales de la operacion
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="totalFinal"></param>
        /// <param name="totalEnvio"></param>
        /// <returns> Texto con el detalle</returns>
        public static string DetalleVenta(Cliente cliente, double totalFinal, double totalEnvio)
        {
            StringBuilder respuesta = new StringBuilder();
           
            respuesta.AppendLine("\nDATOS DEL CLIENTE");
            respuesta.AppendLine(cliente.MostrarDatos());
            respuesta.AppendLine("".PadRight(95, '-'));
            respuesta.AppendLine("\nPRODUCTOS");
            string encabezado = string.Format("{0,19}|{1,40}|{2,15}|{3,10}|{4,10}", "Nombre del producto", "Detalle del producto", "Precio unitario", "Cantidad", "Total");
            respuesta.AppendLine(encabezado);
            foreach (KeyValuePair<Producto, int> producto in Caja.ListaProductosComprados)
            {
                string datosProducto = string.Format("{0,19}|{1,40}|{2,15}|{3,10}|{4,10}", producto.Key.nombre, producto.Key.descripcion, producto.Key.precio, producto.Value, Caja.PrecioTotalPorProducto(producto.Key.precio,producto.Value));
                respuesta.AppendLine(datosProducto);
            }
            respuesta.AppendLine("".PadRight(95, '-'));
            respuesta.AppendLine("\nMONTOS FINALES");
            respuesta.AppendLine("Precio de total de compra: " + Caja.PrecioTotalDeCompra().ToString());
            respuesta.AppendLine("Precio de Envío: " + totalEnvio);
            respuesta.AppendLine("Precio Final: " + totalFinal);

            return respuesta.ToString();
        }

    }
}
