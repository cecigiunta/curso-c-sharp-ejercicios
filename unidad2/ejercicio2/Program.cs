
//*SOLICITA POR CONSOLA UN NUMERO Y DEVUELVE SU VALOR ELEVADO AL CUBO
using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Declarar variables
            int num, resultado;
            //* Solicitar un numero
            Console.WriteLine("ingrese un numero");
            num = int.Parse(Console.ReadLine());

            //* Realizar el calculo
            resultado = num * num * num;

            //*Imprimirlo por pantalla
            Console.WriteLine("El resulado es: "+ resultado);
        }
    }
}
