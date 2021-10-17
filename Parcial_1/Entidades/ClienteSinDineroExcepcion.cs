using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteSinDineroExcepcion : Exception
    {
       /// <summary>
       /// Sobreescribe el metodo Message para mostrar otro mensaje de advertencia
       /// </summary>
        public override string Message
        {
            get
            {
                return "El cliente no tiene saldo suficiente para realizar la operación";
            }
        }

    }
}
