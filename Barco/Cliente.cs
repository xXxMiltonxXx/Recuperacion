using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco
{
    public abstract class Cliente
    {
        protected string _descripcion;
        //en esta vriable va a retornar la descripcion del cliente
        public string Descripcion { get { return _descripcion; } }

    }
    public class DatosCliente : Cliente
    {
        public DatosCliente()
        {
            _descripcion = "Nombre del cliente: Daniel Hardman";
            _descripcion = "Cedula: 2302810536";
        }
        
    }
}
