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

        static Envios()
        {
            precioMoto = 30;
            precioMiniflete = 50;         
        }                  
             

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
