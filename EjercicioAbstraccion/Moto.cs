﻿using Abstraccion;
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
        public string?  Modelo;
        public string? tamaño;

        public override void imprimir()
            

        {
            Console.WriteLine("Nombre del vehiculo: " + nombreVehiculo);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Matricula: " + matricula);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Año: " + año);
            Console.WriteLine("Numero de Llantas: " + numeroLlantas);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Tamaño: " + tamaño);

        }

        public override bool validar()
        {
            throw new NotImplementedException();
        }
    }
}