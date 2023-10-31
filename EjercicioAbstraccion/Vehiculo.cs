using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    internal abstract class Vehiculo
    {
        public string? nombreVehiculo;
        public string? Color;
        public string? matricula;
        public string? Marca;
        public string? año;

        public abstract void imprimir();

        public abstract bool validar();
        
    }

}
