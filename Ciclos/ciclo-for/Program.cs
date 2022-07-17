//* Programa con ciclo FOR que calcula promedio.

using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0 , suma , promedio;            
            for(int i = 0; i < 5; i++ ){
                Console.WriteLine("Ingrese un n: ");
                n = int.Parse(Console.ReadLine());
                suma += n;   //Se van sumando/agregando a mi variable suma.
            }
            promedio = suma / 5;
            Console.WriteLine("el promedio de notas es de: " + promedio);
        }
    }
}
