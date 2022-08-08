//* 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
//* El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido 
//* reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
//* CADENA FUENTE: “La mar estaba serena"
//* CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
//* CADENA RESULTADO: “Li mir estibi sereni"

using System;

namespace reemplazoCaracter
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*
                RESOLUCIÓN LARGA: 
            char letra1, letra2;
            char[] frase = new char [30];
            int indice = 0;

            char letra;

            Console.WriteLine("Ingrese una letra");
            letra = char.Parse(Console.ReadLine());
            while (letra != '0' && indice < 30)
            {
                frase[indice] = letra;
                Console.WriteLine("Ingrese otra letra");
                letra = char.Parse(Console.ReadLine());
                indice++; //Incrementa para q la letra se vaya guardando en c indice
                
            }
            frase[indice] = '\0';  //Determinamos con \0 el final de la cadena
            Console.WriteLine("La frase es: " );
            indice = 0;

            while (frase[indice] != '\0'){
                Console.Write(frase[indice]);
                indice++;
            }

            Console.WriteLine("Ingrese letra a reemplazar: ");
            letra1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva");
            letra2 = char.Parse(Console.ReadLine());

            indice = 0; 

            while (frase[indice] != '\0')
            {
                if(frase[indice] == letra1){  //Voy a recorrer la cadena y cada vez q encuentre la letra, la reemplazo por la otra
                    frase[indice] = letra2;
                    indice++;
                }
                Console.WriteLine("La frase nueva es :" );
                indice = 0;
                while(frase[indice] != '\0'){
                    Console.Write(frase[indice]);
                    indice++;
                }
            }
            */



            //* RESOLUCIÓN CORTA CON STRING Y MÉTODO REPLACE
            string frase;
            char letra1, letra2;
            Console.WriteLine("Ingrese la frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a reemplazar: ");
            letra1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva");
            letra2 = char.Parse(Console.ReadLine());

            frase = frase.Replace(letra1, letra2);  //metodos de string

            Console.WriteLine("La cadena nueva es: " );
            Console.WriteLine(frase);
        }
    }
}
