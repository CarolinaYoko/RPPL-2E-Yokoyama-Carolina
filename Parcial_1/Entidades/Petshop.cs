﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Listado de tipos de Productos
    /// </summary>
    public enum ETipoDeProductos
    {
        Alimentos,
        Juguetes,
        Camas,
        Cuidado

    }

    /// <summary>
    /// Listados de tipo de Usuarios
    /// </summary>
    public enum EUsuarios
    {
        Empleado,
        Administrador
    }

    public enum ETransporte
    {
        Moto = 30,
        Miniflete = 50
    }

    public static class Petshop
    {

        public static List<Usuario> ListaUsuarios;
        public static List<Cliente> ListaClientes;
        public static Dictionary<Producto, int> ListaProductos;
        public static Queue<Venta> ColaVentas;
        public static Stack<Venta> PilaVentasEnviadas;
        static double recaudacionDelDia;


        /// <summary>
        /// Construye un Petshop e instancia su respectiva Lista de Usuarios, lista de clientes, lista de productos y la recaudacion del dia
        /// </summary>        
        static Petshop()
        {
            Petshop.ListaUsuarios = new List<Usuario>();
            Petshop.ListaClientes = new List<Cliente>();
            Petshop.ListaProductos = new Dictionary<Producto, int>();
            Petshop.ColaVentas = new Queue<Venta>();
            Petshop.PilaVentasEnviadas = new Stack<Venta>();
            Petshop.recaudacionDelDia = 0;

            CargarUsuarios();
            CargarClientes();
            CargarProductos();
        }

        /// <summary>
        /// Propiedad con get del atributo recaudacionDelDia
        /// </summary>
        public static double RecaudacionDelDia
        {
            get { return Petshop.recaudacionDelDia; }

        }

        /// <summary>
        /// Carga por defecto empleados y administradores
        /// </summary>
        private static void CargarUsuarios()
        {
            Empleado e1 = new Empleado("marta", "asd123", "Marta", "Rodriguez", 34323323, 40000.00);
            Empleado e2 = new Empleado("jorge", "1234", "Jorge", "Hernandez", 23999000, 50000.00);
            Administrador a1 = new Administrador("gabriel", "qwe123", "Gabriel", "Perez", 3475884, 60000, 2000);
            Administrador a2 = new Administrador("franco", "zxc123", "Franco", "Garcia", 47382992, 70000, 4000);

            Petshop.ListaUsuarios.Add(e1);
            Petshop.ListaUsuarios.Add(e2);
            Petshop.ListaUsuarios.Add(a1);
            Petshop.ListaUsuarios.Add(a2);

        }

        /// <summary>
        /// Carga por defecto clientes
        /// </summary>
        private static void CargarClientes()
        {
            Cliente c1 = new Cliente("Carolina", "Yokoyama", 42699266, 5000);
            Cliente c2 = new Cliente("Jose", "Perez", 42648826, 7000);

            Petshop.ListaClientes.Add(c1);
            Petshop.ListaClientes.Add(c2);
        }

        /// <summary>
        /// Carga por defecto productos
        /// </summary>
        private static void CargarProductos()
        {
            Producto p1 = new Producto(ETipoDeProductos.Alimentos, "Royal Caning", 600, 1, "Urinari para gatos 1kg");
            Producto p2 = new Producto(ETipoDeProductos.Alimentos, "Proplan", 500, 1,  "Para perros adultos");
            Producto p3 = new Producto(ETipoDeProductos.Alimentos, "Dog Chau", 400, 1, "Para perros adultos");
            Producto p4 = new Producto(ETipoDeProductos.Camas, "Piero Pet", 2300, 5, "Tamaño medio");
            Producto p5 = new Producto(ETipoDeProductos.Camas, "Canon Pet", 2000, 3, "Tamaño chico");
            Producto p6 = new Producto(ETipoDeProductos.Camas, "Cardeusse Pet", 2500, 7, "Tamaño grande");
            Producto p7 = new Producto(ETipoDeProductos.Cuidado, "Shamppoo Burbujas", 300, 0.5, "Para gatos y perros");
            Producto p8 = new Producto(ETipoDeProductos.Cuidado, "Pipeta", 500, 0.3 , "Para perros con peso > 6 kg ");
            Producto p9 = new Producto(ETipoDeProductos.Cuidado, "Cepillo", 400, 0.3, "Para gatos");
            Producto p10 = new Producto(ETipoDeProductos.Juguetes, "Pelota", 300, 0.2);
            Producto p11 = new Producto(ETipoDeProductos.Juguetes, "Rascador FunnyCat", 1500, 5, "Para gatos");

            ListaProductos.Add(p1, 300);
            ListaProductos.Add(p2, 300);
            ListaProductos.Add(p3, 300);
            ListaProductos.Add(p4, 300);
            ListaProductos.Add(p5, 300);
            ListaProductos.Add(p6, 300);
            ListaProductos.Add(p7, 300);
            ListaProductos.Add(p8, 300);
            ListaProductos.Add(p9, 300);
            ListaProductos.Add(p10, 300);
            ListaProductos.Add(p11, 300);
        }

        /// <summary>
        /// Descuenta del stock del producto (identificado por id) la cantidad comprada
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="cantidad"></param>
        /// <returns>true si lo logró descaontrar, sino false</returns>
        public static bool DescontarDeStock(int idProducto, int cantidad)
        {
            bool resultado = false;

            foreach (KeyValuePair<Producto, int> producto in Petshop.ListaProductos)
            {
                if (producto.Key.idProducto == idProducto)
                {
                    Petshop.ListaProductos.Remove(producto.Key);
                    Petshop.ListaProductos.Add(producto.Key, producto.Value - cantidad);
                    resultado = true;
                    break;
                }
            }

            return resultado;

        }

        /// <summary>
        /// Aumenta la recuadacion con la cantidad recibida en la venta
        /// </summary>
        /// <param name="nuevaVenta"></param>
        public static void AumentarRecaudacion(double nuevaVenta)
        {
            Petshop.recaudacionDelDia += nuevaVenta;
        }

        public static int CalcularDistancia()
        {
            Random distancia = new Random();
            return distancia.Next(1,30);

        }

        public static void AgregarALaColaVenta(Venta venta)
        {
            ColaVentas.Enqueue(venta);
        }
    


    }
}