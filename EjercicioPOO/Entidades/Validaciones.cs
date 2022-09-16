using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validaciones
    {
        public static bool ValidarCantidad(int cantidadPasajeros,int maximoPasajeros) 
        {
            return cantidadPasajeros > 0 && cantidadPasajeros <= maximoPasajeros;
        }
    }
}
