using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal class Avion : Vehiculo
    {
        public string? Volar;
        public string? CantidadPasajeros;
        public string? Velocidad;
        public string? ModeloAvion;

        public override void imprimir()


        {
            Console.WriteLine("Nombre del vehiculo: " + nombreVehiculo);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Matricula: " + matricula);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Año: " + año);
            Console.WriteLine("Puede volar: " + Volar);
            Console.WriteLine("Canntidad maxima de pasajeros: " + CantidadPasajeros);
            Console.WriteLine("Velocidad por hora: " + Velocidad);
            Console.WriteLine("ModeloAvion: " + ModeloAvion);



        }

        public override bool validar()
        {
            throw new NotImplementedException();
        }
    }
}
