//* Paga a sus empleados 15000 más una comision del 5% sobre lo facturado por c empleado.
//* Programa q permita ingresar lo facturado y calcule y emita el sueldo total a cobrar.

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int facturado, resultado;
            Console.WriteLine("Ingrese su total facturado:");
            facturado = int.Parse(Console.ReadLine());

            resultado = 15000 + ((5 *facturado) / 100);
            Console.WriteLine("El sueldo total a pagar es de: " + resultado);
        }
    }
}
