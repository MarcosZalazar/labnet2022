using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Logic
    {
        public static decimal Dividir(decimal dividendo, decimal divisor)
        {
            return dividendo / divisor;
        }

        public static void EmisorExcepcion()
        {
            throw new ArgumentException(); 
        }
    }
}
