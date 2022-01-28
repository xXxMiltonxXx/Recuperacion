using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco
{
    public class Datos_completos:Constructor
    {
        public Datos_completos()
        {
            _descripcion = "Datos Completos:";
        }
        public override Fechas ConstructorFechas()
        {
            return new FechaIniFin();
        }
        public override Cliente ConstructorCliente()
        {
            return new DatosCliente();
        }
        public override BarcoM ConstructorBarcoM()
        {
            return new DatosB();
        }

    }
}
