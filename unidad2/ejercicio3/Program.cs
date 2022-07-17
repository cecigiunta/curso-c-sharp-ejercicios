//* INGRESAR LOS KM ENTRE DOS CIUDADES Y LA VELOCIDAD PROMEDIO DE UN VEHICULO. 
//* CALCULAR Y EMITIR POR PANTALLA EL TIEMPO APROX Q TARDARÁ EN LLEGAR.
using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int km, vel, resultado;
            Console.WriteLine("Ingrese los kilómetros entre las ciudades: ");
            km= int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese su velocidad promedio: ");
            vel= int.Parse(Console.ReadLine());

            resultado = km / vel;
            Console.WriteLine("El tiempo aprox que tardará en llegar son: " + resultado + " horas.");
        }
    }
}
