using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Taxi : TransportePublico
    {
        private static int capacidadMaximaTaxi;

        static Taxi()
        {
            Taxi.capacidadMaximaTaxi = 4;
        }

        public Taxi(int cantidadPasajeros) : base(cantidadPasajeros)
        {

        }

        public static int CapacidadMaximaTaxi 
        {
            get 
            {
                return Taxi.capacidadMaximaTaxi;
            }
        }

        public override void Avanzar()
        {
            throw new NotImplementedException();
        }

        public override void Detenerse()
        {
            throw new NotImplementedException();
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + " pasajeros en el taxi";
        }
    }
}
