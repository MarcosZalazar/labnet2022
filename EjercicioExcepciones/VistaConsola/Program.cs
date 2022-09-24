using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace VistaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultado = Logic.Dividir(10, 4);
            Console.WriteLine(resultado);
            Console.ReadKey();
            
        }
    }
}
