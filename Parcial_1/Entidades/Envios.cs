using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Envios
    {

        private static double precioMoto;
        private static double precioMiniflete;       

        /// <summary>
        /// Establece los precios de envíos en moto y miniflete por KM
        /// </summary>
        static Envios()
        {
            precioMoto = 30;
            precioMiniflete = 50;         
        }                  
             
        /// <summary>
        /// Determina si el envío se hara en moto o miniflete en funcion de la cantidad de productos y peso total 
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="cantidad"></param>
        /// <param name="tipoTransporte"></param>
        /// <returns>Precio por KM del transporte que corresponda, sino -1</returns>
        public static double DeterminarTransporte(double peso, int cantidad, out string tipoTransporte)
        {
            double precio = -1;
            tipoTransporte = string.Empty;

            if (peso > 0)
            {               
                if (peso > 10 || cantidad > 40)
                {
                    precio = Envios.precioMiniflete;
                    tipoTransporte = "Miniflete";
                }
                else 
                {
                    precio = Envios.precioMoto;
                    tipoTransporte = "Moto";
                }
            }

            return precio;
        }





    }

}
