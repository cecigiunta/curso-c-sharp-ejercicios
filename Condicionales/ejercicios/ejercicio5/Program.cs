/* Hacer un programa para ingresar 4 números. 
Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
*/

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;

            Console.WriteLine("Ingrese el primer num:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer num:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer num:");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer num:");
            num4 = int.Parse(Console.ReadLine());

            if (num1 > num2 & num2 > num3 & num3 > num4) {
                Console.WriteLine("Están ordenados de forma descendente");
            } else if (num4 > num3 & num3 > num2 & num2 > num1){
                Console.WriteLine("Estan ordenados de forma ascendentes");
            } else {
                Console.WriteLine("No están ordenados");
            }            
        }
    }
}   
