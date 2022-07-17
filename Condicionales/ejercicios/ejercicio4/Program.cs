/*4. Hacer un programa para ingresar tres números y emitir un cartel 
aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero. */
using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, suma, producto;
            Console.WriteLine("Ingrese el primer numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            num3 = int.Parse(Console.ReadLine());

            suma = num1 + num2;
            producto = num2 * num3;

            if (suma > producto){
                Console.WriteLine("Es mayor: La suma es: " + suma + " y el producto es " + producto);
            } else{
                Console.WriteLine("Es menor: La suma es: " + suma + " y el producto es " + producto);
                }

        }
    }
}
