// Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
// Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.


using System;

namespace ej_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, cantPares, totalPares = 0;
            for(int i = 0 ; i < 5 ; i++){
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                cantPares = par(numero);
                if(cantPares == 1){
                    totalPares++;
                }
            }
            Console.WriteLine("La cantidad de pares que ingresaste es de: " + totalPares);

        }

        static int par(int n){
            if(n % 2 == 0){
                return 1 ;
            } else {
                return 0 ;
            }
        }
    }
}
