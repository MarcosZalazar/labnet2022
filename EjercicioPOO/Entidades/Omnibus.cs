using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int cantidadPasajeros) : base(cantidadPasajeros)
        {

        }

        public override void Avanzar()
        {
            throw new NotImplementedException();
        }

        public override void Deternerse()
        {
            throw new NotImplementedException();
        }

    }
}
