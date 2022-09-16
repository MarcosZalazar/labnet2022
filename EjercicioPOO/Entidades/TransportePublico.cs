using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class TransportePublico
    {
        private int pasajeros; 

        public TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public int Pasajeros
        {
            get
            {
                return this.pasajeros;
            }
            set
            {
                this.pasajeros=value;
            }
        }

        public abstract void Avanzar();

        public abstract void Detenerse();

        public virtual string MostrarInformacion()
        {
            return $"{this.Pasajeros}";
        }
    }
}
