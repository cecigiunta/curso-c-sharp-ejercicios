//*Hacer un promedio entre las 3 notas

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            double promedio;

            Console.WriteLine("Ingrese la primer nota: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercer nota: ");
            nota3 = int.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("El promedio total es de: "+ promedio);
        }
    }
}
