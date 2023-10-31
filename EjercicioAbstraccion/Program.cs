using EjercicioAbstraccion;
Console.WriteLine("");
Console.WriteLine("***************************Moto***************************");
Console.WriteLine("");

Moto moto = new Moto();
moto.nombreVehiculo = "Moto";
moto.Color = "Rojo";
moto.matricula = "123455";
moto.Marca = "Ninja";
moto.año = "2000";
moto.Modelo = "POJF45";
moto.tamaño = "Grande";
moto.numeroLlantas = "2";
moto.imprimir();

Console.WriteLine("");
Console.WriteLine("***************************Avion***************************");
Console.WriteLine("");

Avion avion = new Avion();
avion.nombreVehiculo = "Avion";
avion.Color = "Gris";
avion.matricula = "00098u8u3";
avion.Marca = "Airbus";
avion.año = "1998";
avion.Volar = "True";
avion.CantidadPasajeros = "834 ";
avion.Velocidad = "860 km/h";
avion.ModeloAvion = "330";
avion.imprimir();
