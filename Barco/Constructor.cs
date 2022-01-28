using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco
{
    public abstract class Constructor
    {
        //operaciones que va a realizar
        //que tipo de habilidad, tiempo, color va a generar las Acciones
        protected string _descripcion;
        public abstract Fechas ConstructorFechas();
        public abstract Cliente ConstructorCliente();
        public abstract BarcoM ConstructorBarcoM();
        public override string ToString()
        {
            return _descripcion;
        }
        public DatosGenerales ConstrutorDatosGenerales()
        {
            Fechas fechas = ConstructorFechas();
            Cliente cliente = ConstructorCliente();
            BarcoM barcoM = ConstructorBarcoM();
            return new DatosGenerales(fechas, cliente, barcoM, _descripcion);
        }

    }
}
