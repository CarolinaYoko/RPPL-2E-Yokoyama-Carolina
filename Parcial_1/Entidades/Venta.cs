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


        static Venta()
        {
            Venta.ultimaOperacion = 0;
        }

        public Venta(Cliente cliente, int cantidadProductos, double pesoTotal)
        {
            this.cliente = cliente;
            this.cantidad = cantidadProductos;
            this.peso = pesoTotal;
            this.numeroOperacion = ultimaOperacion;
            Venta.ultimaOperacion++;
        }               

        public int NumeroOperacion
        {
            get { return this.numeroOperacion; }            
        }

        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
                     

        public int CantidadDeProductos
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
            

        public double PesoTotal
        {
            get { return this.peso; }
            set { this.peso = value; }
        }



    }
}
