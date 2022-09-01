using System;

namespace TPFinal_Giunta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Consigna: 
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
            // A partir de dichos datos informar:
            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que 
            // devuelva true o false según corresponda.

            int numero;
            int mayorPares = 0, contadorPares = 0;  //Variables consigna a.
            int cantImpares = 0; //Variable consigna b.
            int menorPrimos = 0 , contadorPrimos = 0, cantidadPrimos = 0; //Variables consigna c.  
            
            Console.WriteLine("Ingrese un número:");
            numero = int.Parse(Console.ReadLine());

            while(numero != 0){
                // Mayor de los numeros pares:
                if(numero % 2 == 0){
                    contadorPares++;
                    if(contadorPares == 1)  
                        mayorPares = numero ;    
                    else if(numero > mayorPares) 
                        mayorPares = numero ;     
                }
                // Cantidad de números impares
                else {
                    cantImpares++;
                }

                // Menor de los números primos

                if(esPrimo(numero)){    
                    cantidadPrimos++;
                    if(cantidadPrimos == 1){
                        menorPrimos = numero;
                        contadorPrimos = 0;
                    }
                    else if(numero < menorPrimos){
                        menorPrimos = numero;
                        contadorPrimos = 0;   
                    }
                    else {
                        contadorPrimos = 0;
                    }
                } else {
                    contadorPrimos = 0;
                }

                Console.WriteLine("Ingrese un número:");
                numero = int.Parse(Console.ReadLine());
            } 

            Console.WriteLine("El mayor de los pares es: " + mayorPares);
            Console.WriteLine("La cantidad de impares es: " + cantImpares);
            Console.WriteLine("El menor de los primos es: " + menorPrimos);
        }


        public static bool esPrimo(int numero) {
            int contadorPrimos2 = 0;

            for (int i = 1; i <= numero ; i++){  
                if(numero % i == 0 ){ 
                    contadorPrimos2 ++;         
                }
                } 
                if(contadorPrimos2 == 2 && numero != 0 && numero != 1){    
                    return true;
                } else { 
                    return false;
                }
        }
    }
}
