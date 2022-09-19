using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DecimalExtension
    {
        public static string DeterminarPar(this decimal numero)
        {
            string mensaje="El resultado es un número impar";

            if ((numero%2)==0)
            {
                mensaje = "El resultado es un número par";
            }

            return mensaje;
        }
    }
}
