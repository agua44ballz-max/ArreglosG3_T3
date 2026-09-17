
using Arreglos.Logica;

Console.WriteLine("Arreglos");

MiArreglo oMiArreglo = new MiArreglo(10);

oMiArreglo.Llenar(1, 100);


Console.WriteLine("Arreglo desordenado");
Console.WriteLine(oMiArreglo);
//oMyArreglo.ToString();

Console.WriteLine("Arreglo ordenado");
oMiArreglo.Ordenar();
Console.WriteLine(oMiArreglo);

Console.ReadKey();