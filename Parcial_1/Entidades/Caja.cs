using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Caja
    {

        static Dictionary<Producto, int> listaProductosComprados;
        static int numeroTicket;
    

        /// <summary>
        /// Construya una caja con su lista de productos obtenidos de la seleccion
        /// </summary>
        static Caja()
        {
            Caja.listaProductosComprados = new Dictionary<Producto, int>();
            Caja.numeroTicket = 0;
            
        }



        public static Dictionary<Producto, int> ListaProductosComprados
        {
            get { return Caja.listaProductosComprados; }

        }


        /// <summary>
        /// Verifica si hay Stock del producto según la cantidad pretendida
        /// </summary>
        /// <param name="auxProducto"></param>
        /// <param name="auxCantidadProducto"></param>
        /// <returns>true si hay suficiente, sino false </returns>
        public static bool VerificarStock(Producto auxProducto, int auxCantidadProducto)
        {
            bool resultado = false;

            if ((int)auxProducto > 0)
            {
                if ((int)auxProducto > auxCantidadProducto)
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        /// <summary>
        /// Verifica si el saldo del clienta es suficiente para cubri el precio total de la compra
        /// </summary>
        /// <param name="auxCliente"></param>
        /// <param name="precioTotal"></param>
        /// <returns>true si es suficiente, sino false</returns>
        public static bool VerificarSaldo(Cliente auxCliente, double precioTotal)
        {
            bool resultado = false;

            if (precioTotal < auxCliente.Saldo)
            {
                resultado = true;
            }
            else
            {
                throw new ClienteSinDineroExcepcion();
            }

            return resultado;
        }

        /// <summary>
        /// Agrega un producto a la lista de productos a comprar
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static bool AgregarAlCarrito(Producto producto, int cantidad)
        {
            bool resultado = false;

            if (producto != null && cantidad > 0 && VerificarStock(producto, cantidad))
            {
                listaProductosComprados.Add(producto, cantidad);
                resultado = true;
            }
            return resultado;
        }

        public static double PesoTotalDeCompra()
        {
            double total = 0;

            foreach (KeyValuePair<Producto, int> producto in listaProductosComprados)
            {
                total += producto.Key.peso * producto.Value;
            }

            return total;
        }

        public static int CantidadDeProductosComprados()
        {
            int cantidad = 0;

            foreach (KeyValuePair<Producto, int> producto in listaProductosComprados)
            {
                cantidad += producto.Value;
            }

            return cantidad;
        }

        public static double PrecioTotalPorProducto(double precioProducto, int cantidad)
        {
            return precioProducto * cantidad;
        }

        public static double PrecioTotalDeCompra()
        {
            double total = 0;

            foreach (KeyValuePair<Producto, int> producto in listaProductosComprados)
            {
                total += producto.Key.precio * producto.Value;
            }

            return total;
        }

        public static void ExportarTicketTxt(string detalleVenta)
        {
            Caja.numeroTicket++;
            TextWriter archivoDeTexto = new StreamWriter("Ticket-" + Caja.numeroTicket + ".txt");
            archivoDeTexto.WriteLine(detalleVenta);
            archivoDeTexto.Close();

        }






    }
}
