
using Arreglos.Logica;

Console.WriteLine("Arreglos\n");

MiArreglo oMyArreglo = new(5);
oMyArreglo.Agregar(3);
oMyArreglo.Agregar(5);
oMyArreglo.Agregar(7);

oMyArreglo.Insertar(2, 0);
Console.WriteLine(oMyArreglo);
Console.WriteLine("-------------------------");

oMyArreglo.Eliminar(1);
Console.WriteLine(oMyArreglo);





//try
//{
//    for (int i = 0; i < oMyArreglo.N; i++) 
//    {
//        oMyArreglo.Agregar(i * 6);

//    }
//    oMyArreglo.Agregar(6);
//    Console.WriteLine(oMyArreglo);

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);

//}

//Console.WriteLine("Arreglos");

//MiArreglo oMyArreglo = new MiArreglo(10);

//// oMyArreglo.Llenar(1, 100);


//Console.WriteLine("Arreglo desordenado");
//Console.WriteLine(oMyArreglo);
////oMyArreglo.ToString();

//Console.WriteLine("Arreglo ordenado ascendente");
//oMyArreglo.Ordenar(true); // con o sin true debe funcionar correctamente 
//Console.WriteLine(oMyArreglo);

//Console.WriteLine("Arreglo ordenado adescendente");
//oMyArreglo.Ordenar(false);
//Console.WriteLine(oMyArreglo);


Console.ReadKey();

// Versión 03: Estructura base para la siguiente clase