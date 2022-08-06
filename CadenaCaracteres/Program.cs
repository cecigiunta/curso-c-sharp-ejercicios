//Programa que pide nombre letra por letra y al finalizar muestra "Hola nombre"

using System;

namespace CadenaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cadena de Caracteres: 
            char [] nombre = new char[10];
            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese su nombre letra por letra. Corta con punto(.)");
            letra = char.Parse(Console.ReadLine());

            while (letra != '.' && indice < 10)
            {
                nombre [indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            nombre [indice]  = '\0';

            Console.Write("Hola ");
            indice = 0;
            while(nombre[indice] != '\0'){
                Console.Write(nombre[indice]);
                indice++;
            }
        }
    }
}
