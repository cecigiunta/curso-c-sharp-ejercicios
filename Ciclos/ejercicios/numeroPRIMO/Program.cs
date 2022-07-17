//*Hacer un programa q solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no.  
//*Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;   //* Definimos una variable numero
            int con = 0;  //* Definimos una variable que va a ser nuestro contador

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero ; i++){     //*Va a iterar desde 1 hasta el mismo valor del numero
                if(numero % i == 0){   //* Si i es divisor del numero...
                    con ++;            //* Aumenta el contador. 
                }
            //* Para saber que es un numero primo, el contador solo se tendria que haber incrementado dos veces (por 1 y si mismo)
            } 
            if(con == 2){    //* Entonces preguntamos si el contador terminó valiendo dos..
                Console.WriteLine(numero + " es un numero PRIMO");
            } else {
                Console.WriteLine(numero + " NO es un numero PRIMO");
            }

        }
    }
}
