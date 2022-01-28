using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco
{
    public class DatosGenerales
    {
        Fechas _fechas;
        Cliente _cliente;
        BarcoM _barcoM;
        string _tipo;
        //retornamos 
        public override string ToString()
        {
            return $"{_tipo}, Fechas: {_fechas.Descripcion},Cliente: {_cliente.Descripcion}, BarcoM: {_barcoM.Descripcion}";
        }
        //Constructor de acciones
        public DatosGenerales(Fechas fechas, Cliente cliente, BarcoM barcoM, string tipo)
        {
            _fechas = fechas;
            _cliente = cliente;
            _barcoM = barcoM;
            _tipo = tipo;
        }
    }
    
    
    
}
