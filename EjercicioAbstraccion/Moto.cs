using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal class Moto : Vehiculo
    {
        public string? marca;
        public string? numeroLlantas;
        public string? color;
        public string? tamaño;

        public override void imprimir()
            

        {
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Matricula: " + matricula);
            Console.WriteLine("Color: " + color);
                Console.WriteLine("Marca: " + Marca);
                Console.WriteLine("Numero: Llantas " + numeroLlantas);
                Console.WriteLine("Tamaño: " + tamaño);
            Console.WriteLine("Año: " + año);


        }

        public override bool validar()
        {
            throw new NotImplementedException();
        }
    }
}