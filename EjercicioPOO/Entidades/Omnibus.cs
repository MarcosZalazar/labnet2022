using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Omnibus : TransportePublico
    {
        private static int capacidadMaximaOmnibus;

        static Omnibus()
        {
            Omnibus.capacidadMaximaOmnibus = 50;
        }

        public Omnibus(int cantidadPasajeros) : base(cantidadPasajeros)
        {

        }

        public static int CapacidadMaximaOmnibus
        {
            get
            {
                return Omnibus.capacidadMaximaOmnibus;
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
            return base.MostrarInformacion()+ " pasajeros en el Omnibus";
        }

    }
}
