//* Hacer un programa que solicite 6 números
//* y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, maxPar = 0, minImpar = 0, numActual;
            int contadorPares = 0, contadorImpares = 0;

            for(int i = 0; i< 6 ; i++){
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if(i % 2 == 0){
                    contadorPares++;
                    if(contadorPares == 1)  //Si el contador es 1, significa que entró el primer numero par
                        maxPar = num ;      //Entonces inicializo el mayor en el primero
                    else if(num > maxPar)    //Si No es el primero y es mayor al maximo
                        maxPar = num ;          //Lo actualizo
                    
                    } else {
                    contadorImpares++;
                    if(contadorImpares ==1)
                        minImpar = num;
                    else if(num < minImpar)
                        num = minImpar;
                }
            }
                    Console.WriteLine("El menor de los impares es: " + minImpar);
                    Console.WriteLine("El mayor de los pares es: " + maxPar);
        }
    }
}
