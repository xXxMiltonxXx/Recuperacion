using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco
{
    public abstract class BarcoM
    {
        protected string _descripcion;
        //en esta vriable va a retornar la descripcion del color 
        public string Descripcion { get { return _descripcion; } }
    }
    public class DatosB : BarcoM
    {
        public DatosB()
        {
            int lMetros = 150;
            string lMetrosString = lMetros.ToString();
            _descripcion = "Matricula: A541E4F5";
            _descripcion = "Largo en metros" + lMetrosString;
            _descripcion = "Año de fabricación: 2005";
        }
    }
}
