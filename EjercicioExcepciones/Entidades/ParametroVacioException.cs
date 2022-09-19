using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParametroVacioException : Exception
    {        
        public ParametroVacioException( ) : this(String.Empty)
        {

        }
        
        public ParametroVacioException(string mensaje) : base(mensaje +$"{Environment.NewLine}Por favor, complete la carga para continuar operando")
        {

        }   
    }
}
