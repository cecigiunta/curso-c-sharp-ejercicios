//*Hacer un programa que solicite 5 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, promedio =0, suma =0, contador = 0;
            Console.WriteLine("ingrese una edad:");
            edad = int.Parse(Console.ReadLine());

            for(int i = 0; i< 4; i++){
                Console.WriteLine("ingrese una edad:");
                edad = int.Parse(Console.ReadLine());
                
                if(edad >= 18){
                contador++;
                suma += edad;
                promedio = suma / contador;
                }
            }
            Console.WriteLine("El promedio de +18 es: "+ promedio);
        }
    }
}
