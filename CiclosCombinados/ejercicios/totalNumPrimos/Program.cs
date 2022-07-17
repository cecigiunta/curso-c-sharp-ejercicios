//* Hacer un programa para ingresar 10 números. 
//* El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, acc = 0;

            for(int i = 0 ; i < 3 ; i++){
                int contador = 0;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            for (int j = 1; j <= numero ; j++){     //*Va a iterar desde 1 hasta el mismo valor del numero
                
                if(numero % j == 0){   //* Si J es divisor del numero...
                    contador ++;            //* Aumenta el contador. 
                }
            //* Para saber que es un numero primo, el contador solo se tendria que haber incrementado dos veces (por 1 y si mismo)
            } 
            if(contador == 2){    //* Entonces preguntamos si el contador terminó valiendo dos..
                Console.WriteLine(numero + " es un numero PRIMO");
                acc ++;

            } else {
                Console.WriteLine(numero + " NO es un numero PRIMO");
            }
            }
            Console.WriteLine("La cantidad total de numeros primos es de: " + acc);
            
        }
    }
}

