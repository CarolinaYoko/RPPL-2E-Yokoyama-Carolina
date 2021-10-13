using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInvalidoException : Exception
    {
        public override string Message
        {
            get
            {
                return "El usuario ingresado no es válido. Intente nuevamente.";
            }

        }

    }
}
