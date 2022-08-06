//* Hacer un programa que solicite 6 números enteros y los guarde en un vector.
//* Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double [6];
            double num, mayores = 0, acumulador = 0;
            double promedio;

            for(int i = 0; i< 6; i++){
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());
                numeros[i]= num;
                acumulador += num;
            }
            promedio = (acumulador / 6);
            Console.WriteLine("El promedio es: "+ promedio);
            for(int j = 0 ; j < 6; j++){
                if(numeros[j] > promedio){
                    Console.WriteLine("El numero "+ numeros[j] + " es mayor al promedio");
                }
            }
        }
    }
}
