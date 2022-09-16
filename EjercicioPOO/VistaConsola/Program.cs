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
            int contadorOmnibus = 0;
            int contadorTaxis = 0;
            int cantidadIngresada;
            bool resultadoCarga;
            StringBuilder mensaje = new StringBuilder();
            List<TransportePublico> listaDeTransportes = new List<TransportePublico>();

            for (int i = 0; i < 5; i++)
            {
                do 
                {
                    Console.Write($"Ingrese la cantidad de pasajeros del Omnibus {i + 1} (Capacidad máxima={Omnibus.CapacidadMaximaOmnibus}): ", i);
                    resultadoCarga = int.TryParse(Console.ReadLine(), out cantidadIngresada) && Validaciones.ValidarCantidad(cantidadIngresada,Omnibus.CapacidadMaximaOmnibus);
                } while (!resultadoCarga);

                listaDeTransportes.Add(new Omnibus(cantidadIngresada));
            }

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Write($"Ingrese la cantidad de pasajeros del Taxi {i + 1}(Capacidad máxima={Taxi.CapacidadMaximaTaxi}): ", i);
                    resultadoCarga = int.TryParse(Console.ReadLine(), out cantidadIngresada) && Validaciones.ValidarCantidad(cantidadIngresada, Taxi.CapacidadMaximaTaxi);

                } while (!resultadoCarga);

                listaDeTransportes.Add(new Taxi(cantidadIngresada));
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("*************************************");
            foreach (TransportePublico transportePublico in listaDeTransportes)
            {
                mensaje.AppendFormat(transportePublico.GetType().Name + " ");
                if (transportePublico.GetType() == typeof(Omnibus))
                {
                    contadorOmnibus++;
                    mensaje = mensaje.AppendFormat(contadorOmnibus.ToString() + ": ");
                }
                else 
                {
                    contadorTaxis++;
                    mensaje = mensaje.AppendFormat(contadorTaxis.ToString() + ": ");
                }
                
                mensaje.AppendLine(transportePublico.MostrarInformacion());
            }

            Console.WriteLine(mensaje);
            Console.WriteLine("*************************************");
            Console.ReadKey();
        }
    }
}
