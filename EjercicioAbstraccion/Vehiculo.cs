using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    internal  abstract class Vehiculo
    {
        public string? Marca;
        public string? Modelo;
        public bool matricula;
        public bool año;

        public abstract void
            MetodoAstracto1();
        public abstract void
            MetodoAstracto2();
        public abstract void
            MetodoAbstratcto3();
    }

}
