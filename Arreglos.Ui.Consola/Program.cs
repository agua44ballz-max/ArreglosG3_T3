
using Arreglos.Logica;

Console.WriteLine("Arreglos");

MiArreglo oMiArreglo = new MiArreglo(10);



try
{

    for(int i = 0; i < oMiArreglo.N; i++)
    {
        oMiArreglo.Agregar(i*5);
    }

    Console.WriteLine(oMiArreglo);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}




//MiArreglo oMiArreglo = new MiArreglo(10);

//oMiArreglo.Llenar(1, 100);

////oMyArreglo.ToString();

//Console.WriteLine("Arreglo desordenado");
//Console.WriteLine(oMiArreglo);


//Console.WriteLine("Arreglo ordenado ascendente");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);


//Console.WriteLine("Arreglo ordenado descendente");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);

//Console.ReadKey();