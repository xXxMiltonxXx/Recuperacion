using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Constructor> _lineas;
            _lineas = new List<Constructor>();
            _lineas.Add(new Datos_completos());
            Console.WriteLine(_lineas);
            


        }
    }
}
