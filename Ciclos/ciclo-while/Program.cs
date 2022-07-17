//* Programa con ciclo WHILE que permite ingresar numeros, incrementa el contador y corta cuando ingresa 0.
using System;

namespace ciclo_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contador = 0;
            Console.WriteLine("Ingrese un n:");
            n = int.Parse(Console.ReadLine());

            while(n != 0){
                contador ++;
                Console.WriteLine("Ingrese un n:");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingresaste " + contador + " numeros");
        }
    }
}
