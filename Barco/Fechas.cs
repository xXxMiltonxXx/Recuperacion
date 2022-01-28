using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco
{
    public abstract class Fechas
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }
    public class FechaIniFin : Fechas
    {
        public FechaIniFin()
        {
            int num1 = 32;
            string numString = num1.ToString();

            _descripcion = "Fecha de inicio: 12/07/2007; Fecha de fin: 24/07/2007";
            _descripcion= "Tiempo consumido:"+numString;
        }

    }
}
